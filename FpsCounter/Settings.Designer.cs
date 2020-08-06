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
            this.FontSetting.SuspendLayout();
            this.ColorSettings.SuspendLayout();
            this.HotKeySettings.SuspendLayout();
            this.PositionSettings.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontSetting
            // 
            this.FontSetting.Controls.Add(this.FontSizeComboBox);
            this.FontSetting.Controls.Add(this.FontStyleComboBox);
            this.FontSetting.Controls.Add(this.FontComboBox);
            this.FontSetting.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.FontSetting.Location = new System.Drawing.Point(12, 33);
            this.FontSetting.Name = "FontSetting";
            this.FontSetting.Size = new System.Drawing.Size(460, 88);
            this.FontSetting.TabIndex = 0;
            this.FontSetting.TabStop = false;
            this.FontSetting.Text = "Font";
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.FontSizeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontSizeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.FontSizeComboBox.FormattingEnabled = true;
            this.FontSizeComboBox.Location = new System.Drawing.Point(291, 25);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(121, 26);
            this.FontSizeComboBox.TabIndex = 3;
            this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // FontStyleComboBox
            // 
            this.FontStyleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FontStyleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontStyleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.FontStyleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontStyleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
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
            this.FontComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.FontComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FontComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
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
            this.ColorSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.ColorSettings.Location = new System.Drawing.Point(12, 127);
            this.ColorSettings.Name = "ColorSettings";
            this.ColorSettings.Size = new System.Drawing.Size(225, 121);
            this.ColorSettings.TabIndex = 1;
            this.ColorSettings.TabStop = false;
            this.ColorSettings.Text = "Colors";
            // 
            // ColorReset
            // 
            this.ColorReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ColorReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ColorReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ColorReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.ColorReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorReset.Location = new System.Drawing.Point(119, 25);
            this.ColorReset.Name = "ColorReset";
            this.ColorReset.Size = new System.Drawing.Size(100, 30);
            this.ColorReset.TabIndex = 3;
            this.ColorReset.Text = "Reset";
            this.ColorReset.UseVisualStyleBackColor = false;
            this.ColorReset.Click += new System.EventHandler(this.ColorReset_Click);
            // 
            // BackgroundTransparent
            // 
            this.BackgroundTransparent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundTransparent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundTransparent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundTransparent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BackgroundTransparent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundTransparent.Location = new System.Drawing.Point(119, 76);
            this.BackgroundTransparent.Name = "BackgroundTransparent";
            this.BackgroundTransparent.Size = new System.Drawing.Size(100, 30);
            this.BackgroundTransparent.TabIndex = 2;
            this.BackgroundTransparent.Text = "Transparent";
            this.BackgroundTransparent.UseVisualStyleBackColor = false;
            this.BackgroundTransparent.Click += new System.EventHandler(this.BackgroundTransparent_Click);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundColor.Location = new System.Drawing.Point(6, 76);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(100, 30);
            this.BackgroundColor.TabIndex = 1;
            this.BackgroundColor.Text = "Background";
            this.BackgroundColor.UseVisualStyleBackColor = false;
            this.BackgroundColor.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // TextColor
            // 
            this.TextColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TextColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TextColor.FlatAppearance.BorderSize = 0;
            this.TextColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TextColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.TextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextColor.Location = new System.Drawing.Point(6, 25);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(100, 30);
            this.TextColor.TabIndex = 0;
            this.TextColor.Text = "Text";
            this.TextColor.UseVisualStyleBackColor = false;
            this.TextColor.Click += new System.EventHandler(this.TextColor_Click);
            // 
            // HotKeySettings
            // 
            this.HotKeySettings.Controls.Add(this.ChangeHotKeyButton);
            this.HotKeySettings.Controls.Add(this.HotKeyTextBox);
            this.HotKeySettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeySettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.HotKeySettings.Location = new System.Drawing.Point(13, 254);
            this.HotKeySettings.Name = "HotKeySettings";
            this.HotKeySettings.Size = new System.Drawing.Size(224, 112);
            this.HotKeySettings.TabIndex = 2;
            this.HotKeySettings.TabStop = false;
            this.HotKeySettings.Text = "Hotkey";
            // 
            // ChangeHotKeyButton
            // 
            this.ChangeHotKeyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ChangeHotKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ChangeHotKeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ChangeHotKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.ChangeHotKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeHotKeyButton.Location = new System.Drawing.Point(79, 70);
            this.ChangeHotKeyButton.Name = "ChangeHotKeyButton";
            this.ChangeHotKeyButton.Size = new System.Drawing.Size(65, 30);
            this.ChangeHotKeyButton.TabIndex = 1;
            this.ChangeHotKeyButton.Text = "Change";
            this.ChangeHotKeyButton.UseVisualStyleBackColor = false;
            this.ChangeHotKeyButton.Click += new System.EventHandler(this.ChangeHotKeyButton_Click);
            // 
            // HotKeyTextBox
            // 
            this.HotKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.HotKeyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
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
            this.PositionSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.PositionSettings.Location = new System.Drawing.Point(243, 127);
            this.PositionSettings.Name = "PositionSettings";
            this.PositionSettings.Size = new System.Drawing.Size(228, 121);
            this.PositionSettings.TabIndex = 3;
            this.PositionSettings.TabStop = false;
            this.PositionSettings.Text = "Position";
            // 
            // BottomRightButton
            // 
            this.BottomRightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BottomRightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BottomRightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BottomRightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BottomRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomRightButton.Location = new System.Drawing.Point(122, 76);
            this.BottomRightButton.Name = "BottomRightButton";
            this.BottomRightButton.Size = new System.Drawing.Size(100, 30);
            this.BottomRightButton.TabIndex = 3;
            this.BottomRightButton.Text = "Bottom Right";
            this.BottomRightButton.UseVisualStyleBackColor = false;
            this.BottomRightButton.Click += new System.EventHandler(this.BottomRightButton_Click);
            // 
            // BottomLeftButton
            // 
            this.BottomLeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BottomLeftButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BottomLeftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BottomLeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BottomLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomLeftButton.Location = new System.Drawing.Point(6, 76);
            this.BottomLeftButton.Name = "BottomLeftButton";
            this.BottomLeftButton.Size = new System.Drawing.Size(100, 30);
            this.BottomLeftButton.TabIndex = 2;
            this.BottomLeftButton.Text = "Bottom Left";
            this.BottomLeftButton.UseVisualStyleBackColor = false;
            this.BottomLeftButton.Click += new System.EventHandler(this.BottomLeftButton_Click);
            // 
            // TopRightButton
            // 
            this.TopRightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TopRightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TopRightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TopRightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.TopRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopRightButton.Location = new System.Drawing.Point(122, 25);
            this.TopRightButton.Name = "TopRightButton";
            this.TopRightButton.Size = new System.Drawing.Size(100, 30);
            this.TopRightButton.TabIndex = 1;
            this.TopRightButton.Text = "Top Right";
            this.TopRightButton.UseVisualStyleBackColor = false;
            this.TopRightButton.Click += new System.EventHandler(this.TopRightButton_Click);
            // 
            // TopLeftButton
            // 
            this.TopLeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TopLeftButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TopLeftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TopLeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.TopLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopLeftButton.Location = new System.Drawing.Point(6, 25);
            this.TopLeftButton.Name = "TopLeftButton";
            this.TopLeftButton.Size = new System.Drawing.Size(100, 30);
            this.TopLeftButton.TabIndex = 0;
            this.TopLeftButton.Text = "Top Left";
            this.TopLeftButton.UseVisualStyleBackColor = false;
            this.TopLeftButton.Click += new System.EventHandler(this.TopLeftButton_Click);
            // 
            // ColorDialogFps
            // 
            this.ColorDialogFps.FullOpen = true;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
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
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(170)))));
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
            this.TitleName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.TitleName.Location = new System.Drawing.Point(0, 0);
            this.TitleName.Margin = new System.Windows.Forms.Padding(0);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(57, 28);
            this.TitleName.TabIndex = 0;
            this.TitleName.Text = "Settings";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(508, 396);
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
    }
}