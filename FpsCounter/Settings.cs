using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FpsCounter
{
    public partial class Settings : Form
    {
        private FpsCounter FpsCounter;
        private KeysConverter keysConverter = new KeysConverter();
        public Settings(FpsCounter fpsCounter)
        {
            InitializeComponent();
            FpsCounter = fpsCounter;
        }

        /// <summary>
        /// Adding fontfamilies, fontstyles and font sizes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FontComboBox.Items.Add(font.Name);
            }
            foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
            {
                FontStyleComboBox.Items.Add(style);
            }
            FontSizeComboBox.Items.Add(8.0);
            FontSizeComboBox.Items.Add(9.0);
            FontSizeComboBox.Items.Add(10.0);
            FontSizeComboBox.Items.Add(11.0);
            FontSizeComboBox.Items.Add(12.0);
            FontSizeComboBox.Items.Add(14.0);
            FontSizeComboBox.Items.Add(16.0);
            FontSizeComboBox.Items.Add(18.0);
            FontSizeComboBox.Items.Add(20.0);
            FontSizeComboBox.Items.Add(22.0);
            FontSizeComboBox.Items.Add(24.0);
            FontSizeComboBox.Items.Add(26.0);
            FontSizeComboBox.Items.Add(28.0);
            FontSizeComboBox.Items.Add(36.0);
            FontSizeComboBox.Items.Add(48.0);
            FontSizeComboBox.Items.Add(72.0);
            FontComboBox.Text = Properties.Settings.Default.FontFamily.Name;
            FontStyleComboBox.Text = Properties.Settings.Default.FontStyle.ToString();
            FontSizeComboBox.Text = Properties.Settings.Default.FontSize.ToString();
            HotKeyTextBox.Text = Properties.Settings.Default.HotKeyModifierString + keysConverter.ConvertToString(Properties.Settings.Default.HotKey);
            AvgLimitTrackBar.Value = Properties.Settings.Default.AVGFPSLimit;
            if (Properties.Settings.Default.AVGFPS)
            {
                AVGFPSRadioButton.Checked = true;
            }
            else
            {
                FPSRadioButton.Checked = true;
            }

        }

        /// <summary>
        /// Changes fontfamily
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsCounter.FpsLabel.Font = new Font(FontComboBox.Text, FpsCounter.FpsLabel.Font.Size);
            Properties.Settings.Default.FontFamily = new Font(FontComboBox.Text, FpsCounter.FpsLabel.Font.Size);
        }

        /// <summary>
        /// Replaces all combo entries of the fontfamily with the correct fonts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = FontComboBox.Font;

            foreach (FontFamily fontFamilie in FontFamily.Families)
            {
                if (FontComboBox.Items[e.Index].ToString() == fontFamilie.Name)
                {
                    if (fontFamilie.IsStyleAvailable(FontStyle.Regular))
                        font = new Font(fontFamilie, font.Size);
                    break;
                }

            }
            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, FontComboBox.Items[e.Index].ToString(),
              font, e.Bounds, FontComboBox.ForeColor, TextFormatFlags.Left);
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Changes font style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsCounter.FpsLabel.Font = new Font(FontComboBox.Text, FpsCounter.FpsLabel.Font.Size, (FontStyle)Enum.Parse(typeof(FontStyle), FontStyleComboBox.Text, true));
            Properties.Settings.Default.FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), FontStyleComboBox.Text, true);
        }

        /// <summary>
        /// Changes text size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            FpsCounter.FpsLabel.Font = new Font(FontComboBox.Text, Convert.ToSingle(((ComboBox)sender).Text));
            Properties.Settings.Default.FontSize = Convert.ToSingle(((ComboBox)sender).Text);
        }

        /// <summary>
        /// Sets text color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextColor_Click(object sender, EventArgs e)
        {
            ColorDialogFps.ShowDialog();
            FpsCounter.FpsLabel.ForeColor = ColorDialogFps.Color;
            Properties.Settings.Default.TextColor = ColorDialogFps.Color;
        }

        /// <summary>
        /// Sets background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialogFps.ShowDialog();
            FpsCounter.FpsLabel.BackColor = ColorDialogFps.Color;
            Properties.Settings.Default.BackgroundColor = ColorDialogFps.Color;
        }

        /// <summary>
        /// Makes background transparent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundTransparent_Click(object sender, EventArgs e)
        {
            FpsCounter.FpsLabel.BackColor = Color.FromArgb(255, 1, 1, 1);
            Properties.Settings.Default.BackgroundColor = Color.FromArgb(255, 1, 1, 1);
        }

        /// <summary>
        /// Resets text and background colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorReset_Click(object sender, EventArgs e)
        {
            FpsCounter.FpsLabel.BackColor = Color.FromArgb(255, 1, 1, 1);
            Properties.Settings.Default.BackgroundColor = Color.FromArgb(255, 1, 1, 1);
            FpsCounter.FpsLabel.ForeColor = Color.Gray;
            Properties.Settings.Default.TextColor = Color.Gray;
        }

        /// <summary>
        /// Position Fps top left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            FpsCounter.Location = new Point(0);
            Properties.Settings.Default.Position = new Point(0);
        }

        /// <summary>
        /// Position Fps top right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopRightButton_Click(object sender, EventArgs e)
        {
            FpsCounter.Location = new Point(Screen.PrimaryScreen.Bounds.Width - FpsCounter.FpsLabel.Size.Width);
            Properties.Settings.Default.Position = new Point(Screen.PrimaryScreen.Bounds.Width - FpsCounter.FpsLabel.Size.Width);
        }

        /// <summary>
        /// Position Fps bottom left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            FpsCounter.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - FpsCounter.FpsLabel.Size.Height);
            Properties.Settings.Default.Position = new Point(0, Screen.PrimaryScreen.Bounds.Height - FpsCounter.FpsLabel.Size.Height);
        }

        /// <summary>
        /// Position Fps bottom right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            FpsCounter.Location = new Point(Screen.PrimaryScreen.Bounds.Width - FpsCounter.FpsLabel.Size.Width, Screen.PrimaryScreen.Bounds.Height - FpsCounter.FpsLabel.Size.Width);
            Properties.Settings.Default.Position = new Point(Screen.PrimaryScreen.Bounds.Width - FpsCounter.FpsLabel.Size.Width, Screen.PrimaryScreen.Bounds.Height - FpsCounter.FpsLabel.Size.Width);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Enables titlebar dragging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Saves hotkey, modifiers and saves to settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeHotKeyButton_Click(object sender, EventArgs e)
        {
            FpsCounter.GlobalHotKeyUnRegister();
            if (HotKeyTextBox.Text.Contains(Keys.Alt.ToString()) || HotKeyTextBox.Text.Contains(Keys.Control.ToString()) || HotKeyTextBox.Text.Contains(Keys.Shift.ToString()))
            {
                string[] gettingModifiers = HotKeyTextBox.Text.Split('+');
                int globalModifier;
                switch (gettingModifiers[0])
                { // All used modifiers
                    case "Alt ":
                        globalModifier = 0x0001;
                        Properties.Settings.Default.HotKeyModifierString = "Alt + ";
                        break;
                    case "Control, Alt ":
                        globalModifier = 0x0003;
                        Properties.Settings.Default.HotKeyModifierString = "Control, Alt + ";
                        break;
                    case "Control ":
                        globalModifier = 0x0002;
                        Properties.Settings.Default.HotKeyModifierString = "Control + ";
                        break;
                    case "Shift ":
                        globalModifier = 0x0004;
                        Properties.Settings.Default.HotKeyModifierString = "Shift + ";
                        break;
                    case "Shift, Control ":
                        globalModifier = 0x0006;
                        Properties.Settings.Default.HotKeyModifierString = "Shift, Control + ";
                        break;
                    case "Shift, Alt ":
                        globalModifier = 0x0005;
                        Properties.Settings.Default.HotKeyModifierString = "Shift, Alt + ";
                        break;
                    case "Shift, Control, Alt ":
                        globalModifier = 0x0007;
                        Properties.Settings.Default.HotKeyModifierString = "Shift, Control, Alt + ";
                        break;
                    default:
                        globalModifier = 0x0000;
                        break;
                }
                if (gettingModifiers.Length > 1)
                {
                    var key = keysConverter.ConvertFromString(gettingModifiers[1]);
                    FpsCounter.GlobalHotKeyRegister((int)key, globalModifier);
                    Properties.Settings.Default.HotKey = (int)key;
                    Properties.Settings.Default.HotKeyModifier = globalModifier;
                }
            }
            else
            {
                var key = keysConverter.ConvertFromString(HotKeyTextBox.Text);
                FpsCounter.GlobalHotKeyRegister((int)key, 0x0000);
                Properties.Settings.Default.HotKey = (int)key;
                Properties.Settings.Default.HotKeyModifier = 0x0000;
                Properties.Settings.Default.HotKeyModifierString = "";
            }

        }

        /// <summary>
        /// Search for keypress to write it in textbox
        /// Search for modifiers to stop double writing -> Control + Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HotKeyTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string keysPressed;
            if (e.Alt || e.Control || e.Shift)
            {
                keysPressed = ModifierKeys + " + " + e.KeyCode.ToString();
                string[] removingModifiers = keysPressed.Split('+');
                if (removingModifiers[1].Contains(Keys.Alt.ToString()) || removingModifiers[1].Contains(Keys.Shift.ToString()) || removingModifiers[1].Contains(Keys.Control.ToString()) || removingModifiers[1].Contains("Menu"))
                {
                    HotKeyTextBox.Text = ModifierKeys.ToString();
                }
                else
                {
                    HotKeyTextBox.Text = keysPressed;
                }
            }
            else
            {
                HotKeyTextBox.Text = e.KeyCode.ToString();
            }
        }

        private void AVGFPSRadioButton_Click(object sender, EventArgs e)
        {
            if (AVGFPSRadioButton.Checked)
            {
                AvgLimitTrackBar.Visible = true;
                AvgFpsLimitLabel.Visible = true;
                Program.avgFpsCheck = true;
                Properties.Settings.Default.AVGFPS = true;
            }
        }

        private void FPSRadioButton_Click(object sender, EventArgs e)
        {
            if (FPSRadioButton.Checked)
            {
                AvgLimitTrackBar.Visible = false;
                AvgFpsLimitLabel.Visible = false;
                Program.avgFpsCheck = false;
                Properties.Settings.Default.AVGFPS = false;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void AvgLimitTrackBar_Scroll(object sender, EventArgs e)
        {
            if (AvgLimitTrackBar.Value == 21)
            {
                AvgLimitToolTip.SetToolTip(AvgLimitTrackBar, "∞");
                Program.avgFpsQueueUnlimited = true;
                Properties.Settings.Default.AVGFPSUnlimited = true;
            }
            else
            {
                AvgLimitToolTip.SetToolTip(AvgLimitTrackBar, AvgLimitTrackBar.Value.ToString());
                Program.avgFpsQueueLimit = AvgLimitTrackBar.Value;
                Program.avgFpsQueueUnlimited = false;
                Properties.Settings.Default.AVGFPSUnlimited = false;
            }
            Properties.Settings.Default.AVGFPSLimit = AvgLimitTrackBar.Value;

        }

        private void AvgLimitTrackBar_MouseHover(object sender, EventArgs e)
        {
            if (AvgLimitTrackBar.Value == 21)
            {
                AvgLimitToolTip.SetToolTip(AvgLimitTrackBar, "∞");
            }
            else
            {
                AvgLimitToolTip.SetToolTip(AvgLimitTrackBar, AvgLimitTrackBar.Value.ToString());
            }
        }
    }
}
