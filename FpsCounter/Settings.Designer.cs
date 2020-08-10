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
            this.components = new System.ComponentModel.Container();
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
            this.FpsTypeSettings = new System.Windows.Forms.GroupBox();
            this.FPSRadioButton = new System.Windows.Forms.RadioButton();
            this.AVGFPSRadioButton = new System.Windows.Forms.RadioButton();
            this.AvgLimitTrackBar = new System.Windows.Forms.TrackBar();
            this.AvgLimitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AvgFpsLimitLabel = new System.Windows.Forms.Label();
            this.FontSetting.SuspendLayout();
            this.ColorSettings.SuspendLayout();
            this.HotKeySettings.SuspendLayout();
            this.PositionSettings.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.FpsTypeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvgLimitTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FontSetting
            // 
            this.FontSetting.Controls.Add(this.FontSizeComboBox);
            this.FontSetting.Controls.Add(this.FontStyleComboBox);
            this.FontSetting.Controls.Add(this.FontComboBox);
            this.FontSetting.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.FontSetting.Location = new System.Drawing.Point(12, 30);
            this.FontSetting.Name = "FontSetting";
            this.FontSetting.Size = new System.Drawing.Size(472, 90);
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
            this.FontSizeComboBox.Location = new System.Drawing.Point(334, 32);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(120, 26);
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
            this.FontStyleComboBox.Location = new System.Drawing.Point(196, 32);
            this.FontStyleComboBox.Name = "FontStyleComboBox";
            this.FontStyleComboBox.Size = new System.Drawing.Size(120, 26);
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
            this.FontComboBox.Location = new System.Drawing.Point(18, 32);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(160, 27);
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
            this.ColorSettings.Location = new System.Drawing.Point(12, 120);
            this.ColorSettings.Name = "ColorSettings";
            this.ColorSettings.Size = new System.Drawing.Size(230, 130);
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
            this.ColorReset.Location = new System.Drawing.Point(120, 30);
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
            this.BackgroundTransparent.Location = new System.Drawing.Point(120, 80);
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
            this.BackgroundColor.Location = new System.Drawing.Point(10, 80);
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
            this.TextColor.Location = new System.Drawing.Point(10, 30);
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
            this.HotKeySettings.Location = new System.Drawing.Point(12, 250);
            this.HotKeySettings.Name = "HotKeySettings";
            this.HotKeySettings.Size = new System.Drawing.Size(230, 130);
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
            this.ChangeHotKeyButton.Location = new System.Drawing.Point(65, 80);
            this.ChangeHotKeyButton.Name = "ChangeHotKeyButton";
            this.ChangeHotKeyButton.Size = new System.Drawing.Size(100, 30);
            this.ChangeHotKeyButton.TabIndex = 1;
            this.ChangeHotKeyButton.Text = "Change";
            this.ChangeHotKeyButton.UseVisualStyleBackColor = false;
            this.ChangeHotKeyButton.Click += new System.EventHandler(this.ChangeHotKeyButton_Click);
            // 
            // HotKeyTextBox
            // 
            this.HotKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.HotKeyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.HotKeyTextBox.Location = new System.Drawing.Point(10, 40);
            this.HotKeyTextBox.Name = "HotKeyTextBox";
            this.HotKeyTextBox.ReadOnly = true;
            this.HotKeyTextBox.Size = new System.Drawing.Size(210, 26);
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
            this.PositionSettings.Location = new System.Drawing.Point(254, 120);
            this.PositionSettings.Name = "PositionSettings";
            this.PositionSettings.Size = new System.Drawing.Size(230, 130);
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
            this.BottomRightButton.Location = new System.Drawing.Point(120, 80);
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
            this.BottomLeftButton.Location = new System.Drawing.Point(10, 80);
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
            this.TopRightButton.Location = new System.Drawing.Point(120, 30);
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
            this.TopLeftButton.Location = new System.Drawing.Point(10, 30);
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
            this.TitleBar.Size = new System.Drawing.Size(496, 30);
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
            this.ExitButton.Location = new System.Drawing.Point(468, 0);
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
            // FpsTypeSettings
            // 
            this.FpsTypeSettings.Controls.Add(this.AvgFpsLimitLabel);
            this.FpsTypeSettings.Controls.Add(this.AvgLimitTrackBar);
            this.FpsTypeSettings.Controls.Add(this.FPSRadioButton);
            this.FpsTypeSettings.Controls.Add(this.AVGFPSRadioButton);
            this.FpsTypeSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FpsTypeSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.FpsTypeSettings.Location = new System.Drawing.Point(254, 250);
            this.FpsTypeSettings.Name = "FpsTypeSettings";
            this.FpsTypeSettings.Size = new System.Drawing.Size(230, 130);
            this.FpsTypeSettings.TabIndex = 7;
            this.FpsTypeSettings.TabStop = false;
            this.FpsTypeSettings.Text = "Fps Type";
            // 
            // FPSRadioButton
            // 
            this.FPSRadioButton.AutoSize = true;
            this.FPSRadioButton.Location = new System.Drawing.Point(148, 40);
            this.FPSRadioButton.Name = "FPSRadioButton";
            this.FPSRadioButton.Size = new System.Drawing.Size(48, 22);
            this.FPSRadioButton.TabIndex = 8;
            this.FPSRadioButton.TabStop = true;
            this.FPSRadioButton.Text = "FPS";
            this.FPSRadioButton.UseVisualStyleBackColor = true;
            this.FPSRadioButton.Click += new System.EventHandler(this.FPSRadioButton_Click);
            // 
            // AVGFPSRadioButton
            // 
            this.AVGFPSRadioButton.AutoSize = true;
            this.AVGFPSRadioButton.Checked = true;
            this.AVGFPSRadioButton.Location = new System.Drawing.Point(34, 40);
            this.AVGFPSRadioButton.Name = "AVGFPSRadioButton";
            this.AVGFPSRadioButton.Size = new System.Drawing.Size(78, 22);
            this.AVGFPSRadioButton.TabIndex = 7;
            this.AVGFPSRadioButton.TabStop = true;
            this.AVGFPSRadioButton.Text = "AVG FPS";
            this.AVGFPSRadioButton.UseVisualStyleBackColor = true;
            this.AVGFPSRadioButton.Click += new System.EventHandler(this.AVGFPSRadioButton_Click);
            // 
            // AvgLimitTrackBar
            // 
            this.AvgLimitTrackBar.Location = new System.Drawing.Point(34, 82);
            this.AvgLimitTrackBar.Maximum = 21;
            this.AvgLimitTrackBar.Minimum = 2;
            this.AvgLimitTrackBar.Name = "AvgLimitTrackBar";
            this.AvgLimitTrackBar.Size = new System.Drawing.Size(162, 45);
            this.AvgLimitTrackBar.TabIndex = 9;
            this.AvgLimitTrackBar.Value = 2;
            this.AvgLimitTrackBar.Scroll += new System.EventHandler(this.AvgLimitTrackBar_Scroll);
            this.AvgLimitTrackBar.MouseHover += new System.EventHandler(this.AvgLimitTrackBar_MouseHover);
            // 
            // AvgFpsLimitLabel
            // 
            this.AvgFpsLimitLabel.AutoSize = true;
            this.AvgFpsLimitLabel.Location = new System.Drawing.Point(36, 63);
            this.AvgFpsLimitLabel.Name = "AvgFpsLimitLabel";
            this.AvgFpsLimitLabel.Size = new System.Drawing.Size(160, 18);
            this.AvgFpsLimitLabel.TabIndex = 10;
            this.AvgFpsLimitLabel.Text = "Avg of how many frames";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(496, 392);
            this.Controls.Add(this.FpsTypeSettings);
            this.Controls.Add(this.PositionSettings);
            this.Controls.Add(this.HotKeySettings);
            this.Controls.Add(this.ColorSettings);
            this.Controls.Add(this.FontSetting);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.FontSetting.ResumeLayout(false);
            this.ColorSettings.ResumeLayout(false);
            this.HotKeySettings.ResumeLayout(false);
            this.HotKeySettings.PerformLayout();
            this.PositionSettings.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.FpsTypeSettings.ResumeLayout(false);
            this.FpsTypeSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvgLimitTrackBar)).EndInit();
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
        private System.Windows.Forms.GroupBox FpsTypeSettings;
        private System.Windows.Forms.RadioButton FPSRadioButton;
        private System.Windows.Forms.RadioButton AVGFPSRadioButton;
        private System.Windows.Forms.TrackBar AvgLimitTrackBar;
        private System.Windows.Forms.ToolTip AvgLimitToolTip;
        private System.Windows.Forms.Label AvgFpsLimitLabel;
    }
}