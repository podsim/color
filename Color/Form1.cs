using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Color
{
    public partial class Form1 : Form
    {
        private Point _cursor, _point;
        private Bitmap _bmp;
        private Graphics _graphic;
        private System.Drawing.Color _color;
        private bool _monitorCheck;
        private readonly List<string> _history;

        public Form1()
        {
            InitializeComponent();
            _history = new List<string>();
            HideList();
            LoadHistory();
        }

        private void Init()
        {
            _bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Right, Screen.PrimaryScreen.Bounds.Bottom);
            _point = new Point(0, 0);

            numericR.KeyDown += NumericKeyDown;
            numericG.KeyDown += NumericKeyDown;
            numericB.KeyDown += NumericKeyDown;

            timer1.Enabled = false;
            _monitorCheck = false;
            notifyIcon1.Visible = false;
        }

        private void NumericKeyDown(object sender, KeyEventArgs e)
        {
            var tb = sender as NumericUpDown;
            if (tb == null)
                return;
            int i;
            if (int.TryParse(tb.Text, out i))
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        i = i + 1;
                        break;
                    case Keys.Down:
                        i = i - 1;
                        break;
                }
                tb.Text = i.ToString();
            }
            UpdateColor();
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            // Get the color from mouse (Y, X)
            _cursor = Cursor.Position;
            _graphic = Graphics.FromImage(_bmp);
            _graphic.CopyFromScreen(_point, _point, _bmp.Size);
            _color = _bmp.GetPixel(_cursor.X, _cursor.Y);

            UpdateColorData(_color);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Init();
        }

        // Update info about current color
        private void UpdateColorData(System.Drawing.Color color)
        {
            pictureColorBox.BackColor = color;

            numericR.Text = color.R.ToString();
            numericG.Text = color.G.ToString();
            numericB.Text = color.B.ToString();

            textBoxHtml.Text = String.Format("#{0}", color.Name.Substring(2, color.Name.Length - 2));
        }

        // Разрешение на редактирование полей цветов
        private void CanEditInfo(bool b)
        {
            if (labelTip.Visible)
                labelTip.Visible = false;

            textBoxHtml.ReadOnly = !b;
            numericR.ReadOnly = !b;
            numericG.ReadOnly = !b;
            numericB.ReadOnly = !b;
        }

        // On/Off monitoring mouse
        private void ChBMonitorMouseCheckedChanged(object sender, EventArgs e)
        {
            _monitorCheck = chBMonitorMouse.Checked;
            timer1.Enabled = _monitorCheck;
            CanEditInfo(!_monitorCheck);
        }

        // On/Off "Stay on top"
        private void ChBStayTopCheckedChanged(object sender, EventArgs e)
        {
            TopMost = chBStayTop.Checked;
        }

        // Minimize to tray
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                return;
            notifyIcon1.Visible = true;
            Hide();
        }

        // Maximize from tray
        private void NotifyIcon1MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateColor()
        {
            int i;
            var r = int.TryParse(numericR.Text, out i) ? i : 0;
            var g = int.TryParse(numericG.Text, out i) ? i : 0;
            var b = int.TryParse(numericB.Text, out i) ? i : 0;

            UpdateColorData(System.Drawing.Color.FromArgb(r, g, b));
            CanEditInfo(true);
        }

        private void BtnShowClick(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void BtnNameColorShowClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHtml.Text))
                return;

            var clrName = textBoxHtml.Text[0] == '#'
                              ? string.Format("ff{0}", textBoxHtml.Text.Substring(1, textBoxHtml.Text.Length - 1))
                              : string.Format("ff{0}", textBoxHtml.Text);

            int r, g, b;

            try
            {
                r = int.Parse(clrName.Substring(2, 2), NumberStyles.HexNumber);
                g = int.Parse(clrName.Substring(4, 2), NumberStyles.HexNumber);
                b = int.Parse(clrName.Substring(6, 2), NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                r = 0;
                g = 0;
                b = 0;
                MessageBox.Show("Входная строка имела неверный формат", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CanEditInfo(true);
            UpdateColorData(System.Drawing.Color.FromArgb(r, g, b));
            textBoxHtml.Text = string.Format("#{0}", clrName.Substring(2, clrName.Length - 2));
            textBoxHtml.Focus();
        }

        private void BtnListVisibleClick(object sender, EventArgs e)
        {
            if (btnListVisible.Text == ">>")
                ShowList();
            else
                HideList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveHistory();
        }

        #region Keys and Mouse Press

        private void LabelTipMouseDown(object sender, MouseEventArgs e)
        {
            PictureColorBoxMouseDown(sender, e);
        }

        private void LabelTipMouseUp(object sender, MouseEventArgs e)
        {
            PictureColorBoxMouseUp(sender, e);
        }

        private void PictureColorBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (_monitorCheck)
                return;
            if (e.Button != MouseButtons.Left)
                return;
            timer1.Enabled = true;
            CanEditInfo(false);
        }

        private void PictureColorBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (_monitorCheck)
                return;
            if (e.Button != MouseButtons.Left)
                return;
            timer1.Enabled = false;
            CanEditInfo(true);
        }

        #endregion

        #region Color History Methods

        private void RefreshHistoryListView()
        {
            listViewHistory.Clear();

            foreach (var item in _history)
                listViewHistory.Items.Add(item);
        }

        private void ShowList()
        {
            Width = 437;
            RefreshHistoryListView();
            listViewHistory.Visible = true;
            btnAddColor.Visible = true;
            btnDelColor.Visible = true;
            label1.Visible = true;
            btnListVisible.Text = "<<";
        }

        private void HideList()
        {
            Width = 309;
            listViewHistory.Visible = false;
            btnAddColor.Visible = false;
            btnDelColor.Visible = false;
            label1.Visible = false;
            btnListVisible.Text = ">>";
        }

        private void LoadHistory()
        {
            if (File.Exists(string.Format("{0}\\{1}", Application.StartupPath, "History.dat")))
            {
                using (var rd = File.OpenText(string.Format("{0}\\{1}", Application.StartupPath, "History.dat")))
                {
                    while (!rd.EndOfStream)
                        _history.Add(rd.ReadLine());
                }
            }
            else
                File.Create(string.Format("{0}\\{1}", Application.StartupPath, "History.dat"));
        }

        private void SaveHistory()
        {
            using (var rd = File.CreateText(string.Format("{0}\\{1}", Application.StartupPath, "History.dat")))
            {
                foreach (var item in _history)
                {
                    rd.WriteLine(item);
                }
            }
        }

        private void BtnAddColorClick(object sender, EventArgs e)
        {
            if (pictureColorBox.BackColor.Name == "Control")
                return;
            var clr = pictureColorBox.BackColor;
            _history.Add(clr.Name);

            RefreshHistoryListView();
        }

        private void BtnDelColorClick(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedItems.Count == 0)
                return;

            var sitem = listViewHistory.SelectedItems[0];
            _history.Remove(sitem.Text);

            RefreshHistoryListView();
        }

        private void ListViewHistorySelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedItems.Count == 0)
                return;

            var sitem = listViewHistory.SelectedItems[0].Text;
            int r, g, b;

            try
            {
                r = int.Parse(sitem.Substring(2, 2), NumberStyles.HexNumber);
                g = int.Parse(sitem.Substring(4, 2), NumberStyles.HexNumber);
                b = int.Parse(sitem.Substring(6, 2), NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                r = 0;
                g = 0;
                b = 0;
            }

            CanEditInfo(true);
            UpdateColorData(System.Drawing.Color.FromArgb(r, g, b));
            textBoxHtml.Text = string.Format("#{0}", sitem.Substring(2, sitem.Length - 2));
        }

        #endregion
    }
}
