namespace FpsCounter
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FontSetting = new System.Windows.Forms.GroupBox();
            this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.FontStyleComboBox = new System.Windows.Forms.ComboBox();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.ColorSettings = new System.Windows.Forms.GroupBox();
            this.ColorReset = new System.Windows.Forms.Button();
            this.BackgroundTransparent = new System.Windows.Forms.Button();
            this.BackgroundColor = new System.Windows.Forms.Button();
            this.TextColor = new System.Windows.Forms.Button();
            this.HotKeySettings = new System.Windows.Forms.GroupBox();
            this.ChangeHotKeyButton = new System.Windows.Forms.Button();
            this.HotKeyTextBox = new System.Windows.Forms.TextBox();
            this.PositionSettings = new System.Windows.Forms.GroupBox();
            this.BottomRightButton = new System.Windows.Forms.Button();
            this.BottomLeftButton = new System.Windows.Forms.Button();
            this.TopRightButton = new System.Windows.Forms.Button();
            this.TopLeftButton = new System.Windows.Forms.Button();
            this.ColorDialogFps = new System.Windows.Forms.ColorDialog();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FontSetting.SuspendLayout();
            this.ColorSettings.SuspendLayout();
            this.HotKeySettings.SuspendLayout();
            this.PositionSettings.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontSetting
            // 
            this.FontSetting.Controls.Add(this.FontSizeComboBox);
            this.FontSetting.Controls.Add(this.FontStyleComboBox);
            this.FontSetting.Controls.Add(this.FontComboBox);
            this.FontSetting.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSetting.Location = new System.Drawing.Point(12, 33);
            this.FontSetting.Name = "FontSetting";
            this.FontSetting.Size = new System.Drawing.Size(460, 88);
            this.FontSetting.TabIndex = 0;
            this.FontSetting.TabStop = false;
            this.FontSetting.Text = "Font";
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.FormattingEnabled = true;
            this.FontSizeComboBox.Location = new System.Drawing.Point(291, 25);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(121, 26);
            this.FontSizeComboBox.TabIndex = 3;
            this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // FontStyleComboBox
            // 
            this.FontStyleComboBox.FormattingEnabled = true;
            this.FontStyleComboBox.Location = new System.Drawing.Point(164, 25);
            this.FontStyleComboBox.Name = "FontStyleComboBox";
            this.FontStyleComboBox.Size = new System.Drawing.Size(121, 26);
            this.FontStyleComboBox.TabIndex = 2;
            this.FontStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // FontComboBox
            // 
            this.FontComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FontComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Location = new System.Drawing.Point(6, 25);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(152, 27);
            this.FontComboBox.Sorted = true;
            this.FontComboBox.TabIndex = 1;
            this.FontComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.FontComboBox_DrawItem);
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // ColorSettings
            // 
            this.ColorSettings.Controls.Add(this.ColorReset);
            this.ColorSettings.Controls.Add(this.BackgroundTransparent);
            this.ColorSettings.Controls.Add(this.BackgroundColor);
            this.ColorSettings.Controls.Add(this.TextColor);
            this.ColorSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSettings.Location = new System.Drawing.Point(12, 127);
            this.ColorSettings.Name = "ColorSettings";
            this.ColorSettings.Size = new System.Drawing.Size(225, 121);
            this.ColorSettings.TabIndex = 1;
            this.ColorSettings.TabStop = false;
            this.ColorSettings.Text = "Colors";
            // 
            // ColorReset
            // 
            this.ColorReset.Location = new System.Drawing.Point(119, 25);
            this.ColorReset.Name = "ColorReset";
            this.ColorReset.Size = new System.Drawing.Size(100, 30);
            this.ColorReset.TabIndex = 3;
            this.ColorReset.Text = "Reset";
            this.ColorReset.UseVisualStyleBackColor = true;
            this.ColorReset.Click += new System.EventHandler(this.ColorReset_Click);
            // 
            // BackgroundTransparent
            // 
            this.BackgroundTransparent.Location = new System.Drawing.Point(119, 76);
            this.BackgroundTransparent.Name = "BackgroundTransparent";
            this.BackgroundTransparent.Size = new System.Drawing.Size(100, 30);
            this.BackgroundTransparent.TabIndex = 2;
            this.BackgroundTransparent.Text = "Transparent";
            this.BackgroundTransparent.UseVisualStyleBackColor = true;
            this.BackgroundTransparent.Click += new System.EventHandler(this.BackgroundTransparent_Click);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.Location = new System.Drawing.Point(6, 76);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(100, 30);
            this.BackgroundColor.TabIndex = 1;
            this.BackgroundColor.Text = "Background";
            this.BackgroundColor.UseVisualStyleBackColor = true;
            this.BackgroundColor.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // TextColor
            // 
            this.TextColor.Location = new System.Drawing.Point(6, 25);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(100, 30);
            this.TextColor.TabIndex = 0;
            this.TextColor.Text = "Text";
            this.TextColor.UseVisualStyleBackColor = true;
            this.TextColor.Click += new System.EventHandler(this.TextColor_Click);
            // 
            // HotKeySettings
            // 
            this.HotKeySettings.Controls.Add(this.ChangeHotKeyButton);
            this.HotKeySettings.Controls.Add(this.HotKeyTextBox);
            this.HotKeySettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeySettings.Location = new System.Drawing.Point(13, 254);
            this.HotKeySettings.Name = "HotKeySettings";
            this.HotKeySettings.Size = new System.Drawing.Size(224, 112);
            this.HotKeySettings.TabIndex = 2;
            this.HotKeySettings.TabStop = false;
            this.HotKeySettings.Text = "Hotkey";
            // 
            // ChangeHotKeyButton
            // 
            this.ChangeHotKeyButton.Location = new System.Drawing.Point(79, 70);
            this.ChangeHotKeyButton.Name = "ChangeHotKeyButton";
            this.ChangeHotKeyButton.Size = new System.Drawing.Size(65, 30);
            this.ChangeHotKeyButton.TabIndex = 1;
            this.ChangeHotKeyButton.Text = "Change";
            this.ChangeHotKeyButton.UseVisualStyleBackColor = true;
            this.ChangeHotKeyButton.Click += new System.EventHandler(this.ChangeHotKeyButton_Click);
            // 
            // HotKeyTextBox
            // 
            this.HotKeyTextBox.Location = new System.Drawing.Point(6, 35);
            this.HotKeyTextBox.Name = "HotKeyTextBox";
            this.HotKeyTextBox.ReadOnly = true;
            this.HotKeyTextBox.Size = new System.Drawing.Size(212, 26);
            this.HotKeyTextBox.TabIndex = 0;
            this.HotKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HotKeyTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HotKeyTextBox_PreviewKeyDown);
            // 
            // PositionSettings
            // 
            this.PositionSettings.Controls.Add(this.BottomRightButton);
            this.PositionSettings.Controls.Add(this.BottomLeftButton);
            this.PositionSettings.Controls.Add(this.TopRightButton);
            this.PositionSettings.Controls.Add(this.TopLeftButton);
            this.PositionSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionSettings.Location = new System.Drawing.Point(243, 127);
            this.PositionSettings.Name = "PositionSettings";
            this.PositionSettings.Size = new System.Drawing.Size(228, 121);
            this.PositionSettings.TabIndex = 3;
            this.PositionSettings.TabStop = false;
            this.PositionSettings.Text = "Position";
            // 
            // BottomRightButton
            // 
            this.BottomRightButton.Location = new System.Drawing.Point(122, 76);
            this.BottomRightButton.Name = "BottomRightButton";
            this.BottomRightButton.Size = new System.Drawing.Size(100, 30);
            this.BottomRightButton.TabIndex = 3;
            this.BottomRightButton.Text = "Bottom Right";
            this.BottomRightButton.UseVisualStyleBackColor = true;
            this.BottomRightButton.Click += new System.EventHandler(this.BottomRightButton_Click);
            // 
            // BottomLeftButton
            // 
            this.BottomLeftButton.Location = new System.Drawing.Point(6, 76);
            this.BottomLeftButton.Name = "BottomLeftButton";
            this.BottomLeftButton.Size = new System.Drawing.Size(100, 30);
            this.BottomLeftButton.TabIndex = 2;
            this.BottomLeftButton.Text = "Bottom Left";
            this.BottomLeftButton.UseVisualStyleBackColor = true;
            this.BottomLeftButton.Click += new System.EventHandler(this.BottomLeftButton_Click);
            // 
            // TopRightButton
            // 
            this.TopRightButton.Location = new System.Drawing.Point(122, 25);
            this.TopRightButton.Name = "TopRightButton";
            this.TopRightButton.Size = new System.Drawing.Size(100, 30);
            this.TopRightButton.TabIndex = 1;
            this.TopRightButton.Text = "Top Right";
            this.TopRightButton.UseVisualStyleBackColor = true;
            this.TopRightButton.Click += new System.EventHandler(this.TopRightButton_Click);
            // 
            // TopLeftButton
            // 
            this.TopLeftButton.Location = new System.Drawing.Point(6, 25);
            this.TopLeftButton.Name = "TopLeftButton";
            this.TopLeftButton.Size = new System.Drawing.Size(100, 30);
            this.TopLeftButton.TabIndex = 0;
            this.TopLeftButton.Text = "Top Left";
            this.TopLeftButton.UseVisualStyleBackColor = true;
            this.TopLeftButton.Click += new System.EventHandler(this.TopLeftButton_Click);
            // 
            // ColorDialogFps
            // 
            this.ColorDialogFps.FullOpen = true;
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.ExitButton);
            this.TitleBar.Controls.Add(this.TitleName);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(508, 30);
            this.TitleBar.TabIndex = 4;
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(480, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 28);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleName
            // 
            this.TitleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.Location = new System.Drawing.Point(0, 0);
            this.TitleName.Margin = new System.Windows.Forms.Padding(0);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(57, 28);
            this.TitleName.TabIndex = 0;
            this.TitleName.Text = "Settings";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(287, 254);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(154, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(154, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 396);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PositionSettings);
            this.Controls.Add(this.HotKeySettings);
            this.Controls.Add(this.ColorSettings);
            this.Controls.Add(this.FontSetting);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.FontSetting.ResumeLayout(false);
            this.ColorSettings.ResumeLayout(false);
            this.HotKeySettings.ResumeLayout(false);
            this.HotKeySettings.PerformLayout();
            this.PositionSettings.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FontSetting;
        private System.Windows.Forms.ComboBox FontSizeComboBox;
        private System.Windows.Forms.ComboBox FontStyleComboBox;
        public System.Windows.Forms.ComboBox FontComboBox;
        private System.Windows.Forms.GroupBox ColorSettings;
        private System.Windows.Forms.GroupBox HotKeySettings;
        private System.Windows.Forms.GroupBox PositionSettings;
        private System.Windows.Forms.ColorDialog ColorDialogFps;
        private System.Windows.Forms.Button BackgroundColor;
        private System.Windows.Forms.Button TextColor;
        private System.Windows.Forms.Button BackgroundTransparent;
        private System.Windows.Forms.Button ColorReset;
        private System.Windows.Forms.Button BottomRightButton;
        private System.Windows.Forms.Button BottomLeftButton;
        private System.Windows.Forms.Button TopRightButton;
        private System.Windows.Forms.Button TopLeftButton;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox HotKeyTextBox;
        private System.Windows.Forms.Button ChangeHotKeyButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}