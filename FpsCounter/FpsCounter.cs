using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FpsCounter
{
    public partial class FpsCounter : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        private Settings settings;
        public string positionForm;


        public FpsCounter()
        {
            InitializeComponent();
            settings = new Settings(this);
            BackColor = Color.FromArgb(255, 1, 1, 1);
            TransparencyKey = Color.FromArgb(255, 1, 1, 1);
            FpsLabel.Font = new Font(Properties.Settings.Default.FontFamily.FontFamily, Properties.Settings.Default.FontSize, Properties.Settings.Default.FontStyle);
            FpsLabel.ForeColor = Properties.Settings.Default.TextColor;
            FpsLabel.BackColor = Properties.Settings.Default.BackgroundColor;
            StartPosition = FormStartPosition.Manual;
            Location = Properties.Settings.Default.Position;
            Boolean hotKeyRegistered = RegisterHotKey(Handle, 1, Properties.Settings.Default.HotKeyModifier, Properties.Settings.Default.HotKey);
            FormClickThrough();
        }

        protected override void WndProc(ref Message m)
        {
            // Catch when a HotKey is pressed 
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    settings.Show();
                    settings.BringToFront();
                }
            }

            base.WndProc(ref m);
        }

        private void WindowHandle_Tick(object sender, EventArgs e)
        {

            FpsLabel.Text = Program.Fps();
            Size = FpsLabel.Size;
            switch (positionForm)
            {
                case "Top Right":
                    if (Location.X + Width != (Screen.PrimaryScreen.Bounds.Width))
                    {
                        Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width);
                    }
                    break;
                case "Bottom Right":
                    if (Location.X + Width != (Screen.PrimaryScreen.Bounds.Width))
                    {
                        Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width);
                    }
                    if (Location.Y + Height != (Screen.PrimaryScreen.Bounds.Height))
                    {
                        Location = new Point(Screen.PrimaryScreen.Bounds.Width - Size.Width, Screen.PrimaryScreen.Bounds.Height - Size.Height);
                    }
                    break;
            }
           
        }

        /// <summary>
        /// Hotkey Registering
        /// </summary>
        /// <param name="key"></param>
        /// <param name="modifier"></param>
        public void GlobalHotKeyRegister(int key, int modifier)
        {
            RegisterHotKey(Handle, 1, modifier, key);
        }

        /// <summary>
        /// Hotkey Unregistering
        /// </summary>
        public void GlobalHotKeyUnRegister()
        {
            UnregisterHotKey(Handle, 1);
        }

        private void FormClickThrough()
        {
            int initialStyle = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, initialStyle | 0x80000 | 0x20);

        }
    }
}
