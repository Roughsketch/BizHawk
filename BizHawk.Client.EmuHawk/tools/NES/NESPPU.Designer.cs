﻿namespace BizHawk.Client.EmuHawk
{
	partial class NesPPU
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NesPPU));
			this.PatternGroup = new System.Windows.Forms.GroupBox();
			this.Table1PaletteLabel = new System.Windows.Forms.Label();
			this.Table0PaletteLabel = new System.Windows.Forms.Label();
			this.PatternView = new BizHawk.Client.EmuHawk.PatternViewer();
			this.PatternContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.PatternSaveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PatternImageToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PatternRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PalettesGroup = new System.Windows.Forms.GroupBox();
			this.PaletteView = new BizHawk.Client.EmuHawk.PaletteViewer();
			this.PaletteContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.PaletteSaveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PaletteImageToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PaletteRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DetailsBox = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Value5Label = new System.Windows.Forms.Label();
			this.Value4Label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ZoomBox = new System.Windows.Forms.PictureBox();
			this.Value3Label = new System.Windows.Forms.Label();
			this.Value2Label = new System.Windows.Forms.Label();
			this.ValueLabel = new System.Windows.Forms.Label();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.SpriteViewerBox = new System.Windows.Forms.GroupBox();
			this.SpriteView = new BizHawk.Client.EmuHawk.SpriteViewer();
			this.SpriteContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SpriteSaveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SpriteImageToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SpriteRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtScanline = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.RefreshRate = new System.Windows.Forms.TrackBar();
			this.NesPPUMenu = new MenuStripEx();
			this.FileSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SavePaletteScreenshotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SavePatternScreenshotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveSpriteScreenshotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CopyPaletteToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyPatternToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopySpriteToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PatternSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0PaletteSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P0MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P6MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table0P7MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1PaletteSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P0MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P6MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Table1P7MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.AutoLoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveWindowPositionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AlwaysOnTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FloatingWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NesPPUStatusBar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.Messagetimer = new System.Windows.Forms.Timer(this.components);
			this.PatternGroup.SuspendLayout();
			this.PatternContext.SuspendLayout();
			this.PalettesGroup.SuspendLayout();
			this.PaletteContext.SuspendLayout();
			this.DetailsBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZoomBox)).BeginInit();
			this.SpriteViewerBox.SuspendLayout();
			this.SpriteContext.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RefreshRate)).BeginInit();
			this.NesPPUMenu.SuspendLayout();
			this.NesPPUStatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// PatternGroup
			// 
			this.PatternGroup.Controls.Add(this.Table1PaletteLabel);
			this.PatternGroup.Controls.Add(this.Table0PaletteLabel);
			this.PatternGroup.Controls.Add(this.PatternView);
			this.PatternGroup.Location = new System.Drawing.Point(293, 37);
			this.PatternGroup.Name = "PatternGroup";
			this.PatternGroup.Size = new System.Drawing.Size(272, 169);
			this.PatternGroup.TabIndex = 0;
			this.PatternGroup.TabStop = false;
			this.PatternGroup.Text = "Pattern Tables";
			// 
			// Table1PaletteLabel
			// 
			this.Table1PaletteLabel.AutoSize = true;
			this.Table1PaletteLabel.Location = new System.Drawing.Point(129, 150);
			this.Table1PaletteLabel.Name = "Table1PaletteLabel";
			this.Table1PaletteLabel.Size = new System.Drawing.Size(52, 13);
			this.Table1PaletteLabel.TabIndex = 2;
			this.Table1PaletteLabel.Text = "Palette: 0";
			// 
			// Table0PaletteLabel
			// 
			this.Table0PaletteLabel.AutoSize = true;
			this.Table0PaletteLabel.Location = new System.Drawing.Point(6, 150);
			this.Table0PaletteLabel.Name = "Table0PaletteLabel";
			this.Table0PaletteLabel.Size = new System.Drawing.Size(52, 13);
			this.Table0PaletteLabel.TabIndex = 1;
			this.Table0PaletteLabel.Text = "Palette: 0";
			// 
			// PatternView
			// 
			this.PatternView.BackColor = System.Drawing.Color.Transparent;
			this.PatternView.ContextMenuStrip = this.PatternContext;
			this.PatternView.Location = new System.Drawing.Point(7, 20);
			this.PatternView.Name = "PatternView";
			this.PatternView.Size = new System.Drawing.Size(256, 128);
			this.PatternView.TabIndex = 0;
			this.PatternView.Text = "Pattern Tables";
			this.PatternView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PatternView_Click);
			this.PatternView.MouseEnter += new System.EventHandler(this.PatternView_MouseEnter);
			this.PatternView.MouseLeave += new System.EventHandler(this.PatternView_MouseLeave);
			this.PatternView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PatternView_MouseMove);
			// 
			// PatternContext
			// 
			this.PatternContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatternSaveImageMenuItem,
            this.PatternImageToClipboardMenuItem,
            this.PatternRefreshMenuItem});
			this.PatternContext.Name = "PatternContext";
			this.PatternContext.Size = new System.Drawing.Size(177, 70);
			// 
			// PatternSaveImageMenuItem
			// 
			this.PatternSaveImageMenuItem.Name = "PatternSaveImageMenuItem";
			this.PatternSaveImageMenuItem.Size = new System.Drawing.Size(176, 22);
			this.PatternSaveImageMenuItem.Text = "&Save Image...";
			this.PatternSaveImageMenuItem.Click += new System.EventHandler(this.SavePatternScreenshotMenuItem_Click);
			// 
			// PatternImageToClipboardMenuItem
			// 
			this.PatternImageToClipboardMenuItem.Name = "PatternImageToClipboardMenuItem";
			this.PatternImageToClipboardMenuItem.Size = new System.Drawing.Size(176, 22);
			this.PatternImageToClipboardMenuItem.Text = "Image to &Clipboard";
			this.PatternImageToClipboardMenuItem.Click += new System.EventHandler(this.CopyPatternToClipboardMenuItem_Click);
			// 
			// PatternRefreshMenuItem
			// 
			this.PatternRefreshMenuItem.Name = "PatternRefreshMenuItem";
			this.PatternRefreshMenuItem.Size = new System.Drawing.Size(176, 22);
			this.PatternRefreshMenuItem.Text = "&Refresh";
			this.PatternRefreshMenuItem.Click += new System.EventHandler(this.PatternRefreshMenuItem_Click);
			// 
			// PalettesGroup
			// 
			this.PalettesGroup.Controls.Add(this.PaletteView);
			this.PalettesGroup.Location = new System.Drawing.Point(12, 271);
			this.PalettesGroup.Name = "PalettesGroup";
			this.PalettesGroup.Size = new System.Drawing.Size(272, 65);
			this.PalettesGroup.TabIndex = 1;
			this.PalettesGroup.TabStop = false;
			this.PalettesGroup.Text = "Palettes";
			// 
			// PaletteView
			// 
			this.PaletteView.BackColor = System.Drawing.Color.Transparent;
			this.PaletteView.ContextMenuStrip = this.PaletteContext;
			this.PaletteView.Location = new System.Drawing.Point(6, 19);
			this.PaletteView.Name = "PaletteView";
			this.PaletteView.Size = new System.Drawing.Size(256, 32);
			this.PaletteView.TabIndex = 0;
			this.PaletteView.Text = "Palettes";
			this.PaletteView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaletteView_MouseClick);
			this.PaletteView.MouseEnter += new System.EventHandler(this.PaletteView_MouseEnter);
			this.PaletteView.MouseLeave += new System.EventHandler(this.PaletteView_MouseLeave);
			this.PaletteView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaletteView_MouseMove);
			// 
			// PaletteContext
			// 
			this.PaletteContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaletteSaveImageMenuItem,
            this.PaletteImageToClipboardMenuItem,
            this.PaletteRefreshMenuItem});
			this.PaletteContext.Name = "PaletteContext";
			this.PaletteContext.Size = new System.Drawing.Size(177, 70);
			// 
			// PaletteSaveImageMenuItem
			// 
			this.PaletteSaveImageMenuItem.Name = "PaletteSaveImageMenuItem";
			this.PaletteSaveImageMenuItem.Size = new System.Drawing.Size(176, 22);
			this.PaletteSaveImageMenuItem.Text = "&Save Image...";
			this.PaletteSaveImageMenuItem.Click += new System.EventHandler(this.SavePaletteScreenshotMenuItem_Click);
			// 
			// PaletteImageToClipboardMenuItem
			// 
			this.PaletteImageToClipboardMenuItem.Name = "PaletteImageToClipboardMenuItem";
			this.PaletteImageToClipboardMenuItem.Size = new System.Drawing.Size(176, 22);
			this.PaletteImageToClipboardMenuItem.Text = "Image to &Clipboard";
			this.PaletteImageToClipboardMenuItem.Click += new System.EventHandler(this.CopyPaletteToClipboardMenuItem_Click);
			// 
			// PaletteRefreshMenuItem
			// 
			this.PaletteRefreshMenuItem.Name = "PaletteRefreshMenuItem";
			this.PaletteRefreshMenuItem.Size = new System.Drawing.Size(176, 22);
			this.PaletteRefreshMenuItem.Text = "&Refresh";
			this.PaletteRefreshMenuItem.Click += new System.EventHandler(this.PaletteRefreshMenuItem_Click);
			// 
			// DetailsBox
			// 
			this.DetailsBox.Controls.Add(this.label2);
			this.DetailsBox.Controls.Add(this.Value5Label);
			this.DetailsBox.Controls.Add(this.Value4Label);
			this.DetailsBox.Controls.Add(this.label1);
			this.DetailsBox.Controls.Add(this.ZoomBox);
			this.DetailsBox.Controls.Add(this.Value3Label);
			this.DetailsBox.Controls.Add(this.Value2Label);
			this.DetailsBox.Controls.Add(this.ValueLabel);
			this.DetailsBox.Controls.Add(this.AddressLabel);
			this.DetailsBox.Location = new System.Drawing.Point(12, 95);
			this.DetailsBox.Name = "DetailsBox";
			this.DetailsBox.Size = new System.Drawing.Size(272, 170);
			this.DetailsBox.TabIndex = 2;
			this.DetailsBox.TabStop = false;
			this.DetailsBox.Text = "Details";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Shift-click to remember selection";
			// 
			// Value5Label
			// 
			this.Value5Label.AutoSize = true;
			this.Value5Label.Location = new System.Drawing.Point(144, 148);
			this.Value5Label.Name = "Value5Label";
			this.Value5Label.Size = new System.Drawing.Size(43, 13);
			this.Value5Label.TabIndex = 9;
			this.Value5Label.Text = "Value 5";
			// 
			// Value4Label
			// 
			this.Value4Label.AutoSize = true;
			this.Value4Label.Location = new System.Drawing.Point(144, 120);
			this.Value4Label.Name = "Value4Label";
			this.Value4Label.Size = new System.Drawing.Size(43, 13);
			this.Value4Label.TabIndex = 8;
			this.Value4Label.Text = "Value 4";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Hover over item to view details";
			// 
			// ZoomBox
			// 
			this.ZoomBox.Location = new System.Drawing.Point(196, 16);
			this.ZoomBox.Name = "ZoomBox";
			this.ZoomBox.Size = new System.Drawing.Size(64, 64);
			this.ZoomBox.TabIndex = 6;
			this.ZoomBox.TabStop = false;
			this.ZoomBox.Text = "Details";
			// 
			// Value3Label
			// 
			this.Value3Label.AutoSize = true;
			this.Value3Label.Location = new System.Drawing.Point(144, 92);
			this.Value3Label.Name = "Value3Label";
			this.Value3Label.Size = new System.Drawing.Size(43, 13);
			this.Value3Label.TabIndex = 5;
			this.Value3Label.Text = "Value 3";
			// 
			// Value2Label
			// 
			this.Value2Label.AutoSize = true;
			this.Value2Label.Location = new System.Drawing.Point(10, 148);
			this.Value2Label.Name = "Value2Label";
			this.Value2Label.Size = new System.Drawing.Size(43, 13);
			this.Value2Label.TabIndex = 3;
			this.Value2Label.Text = "Value 2";
			// 
			// ValueLabel
			// 
			this.ValueLabel.AutoSize = true;
			this.ValueLabel.Location = new System.Drawing.Point(10, 120);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(43, 13);
			this.ValueLabel.TabIndex = 2;
			this.ValueLabel.Text = "Value 1";
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(10, 92);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(45, 13);
			this.AddressLabel.TabIndex = 1;
			this.AddressLabel.Text = "Address";
			// 
			// SpriteViewerBox
			// 
			this.SpriteViewerBox.Controls.Add(this.SpriteView);
			this.SpriteViewerBox.Location = new System.Drawing.Point(293, 212);
			this.SpriteViewerBox.Name = "SpriteViewerBox";
			this.SpriteViewerBox.Size = new System.Drawing.Size(272, 124);
			this.SpriteViewerBox.TabIndex = 5;
			this.SpriteViewerBox.TabStop = false;
			this.SpriteViewerBox.Text = "Sprites";
			// 
			// SpriteView
			// 
			this.SpriteView.BackColor = System.Drawing.Color.Transparent;
			this.SpriteView.ContextMenuStrip = this.SpriteContext;
			this.SpriteView.Location = new System.Drawing.Point(6, 18);
			this.SpriteView.Name = "SpriteView";
			this.SpriteView.Size = new System.Drawing.Size(256, 96);
			this.SpriteView.TabIndex = 0;
			this.SpriteView.Text = "Sprites";
			this.SpriteView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpriteView_MouseClick);
			this.SpriteView.MouseEnter += new System.EventHandler(this.SpriteView_MouseEnter);
			this.SpriteView.MouseLeave += new System.EventHandler(this.SpriteView_MouseLeave);
			this.SpriteView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpriteView_MouseMove);
			// 
			// SpriteContext
			// 
			this.SpriteContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpriteSaveImageMenuItem,
            this.SpriteImageToClipboardMenuItem,
            this.SpriteRefreshMenuItem});
			this.SpriteContext.Name = "SpriteContext";
			this.SpriteContext.Size = new System.Drawing.Size(177, 70);
			// 
			// SpriteSaveImageMenuItem
			// 
			this.SpriteSaveImageMenuItem.Name = "SpriteSaveImageMenuItem";
			this.SpriteSaveImageMenuItem.Size = new System.Drawing.Size(176, 22);
			this.SpriteSaveImageMenuItem.Text = "&Save Image...";
			this.SpriteSaveImageMenuItem.Click += new System.EventHandler(this.SaveSpriteScreenshotMenuItem_Click);
			// 
			// SpriteImageToClipboardMenuItem
			// 
			this.SpriteImageToClipboardMenuItem.Name = "SpriteImageToClipboardMenuItem";
			this.SpriteImageToClipboardMenuItem.Size = new System.Drawing.Size(176, 22);
			this.SpriteImageToClipboardMenuItem.Text = "Image to &Clipboard";
			this.SpriteImageToClipboardMenuItem.Click += new System.EventHandler(this.CopySpriteToClipboardMenuItem_Click);
			// 
			// SpriteRefreshMenuItem
			// 
			this.SpriteRefreshMenuItem.Name = "SpriteRefreshMenuItem";
			this.SpriteRefreshMenuItem.Size = new System.Drawing.Size(176, 22);
			this.SpriteRefreshMenuItem.Text = "&Refresh";
			this.SpriteRefreshMenuItem.Click += new System.EventHandler(this.SpriteRefreshMenuItem_Click);
			// 
			// txtScanline
			// 
			this.txtScanline.Location = new System.Drawing.Point(7, 16);
			this.txtScanline.Name = "txtScanline";
			this.txtScanline.Size = new System.Drawing.Size(60, 20);
			this.txtScanline.TabIndex = 6;
			this.txtScanline.Text = "0";
			this.txtScanline.TextChanged += new System.EventHandler(this.ScanlineTextbox_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtScanline);
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(75, 52);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Scanline";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.RefreshRate);
			this.groupBox2.Location = new System.Drawing.Point(93, 37);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(191, 52);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Refresh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(140, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Less";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "More";
			// 
			// RefreshRate
			// 
			this.RefreshRate.AutoSize = false;
			this.RefreshRate.LargeChange = 2;
			this.RefreshRate.Location = new System.Drawing.Point(39, 15);
			this.RefreshRate.Maximum = 8;
			this.RefreshRate.Minimum = 1;
			this.RefreshRate.Name = "RefreshRate";
			this.RefreshRate.Size = new System.Drawing.Size(104, 31);
			this.RefreshRate.TabIndex = 0;
			this.RefreshRate.TickFrequency = 8;
			this.RefreshRate.Value = 1;
			// 
			// NesPPUMenu
			// 
			this.NesPPUMenu.ClickThrough = true;
			this.NesPPUMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSubMenu,
            this.PatternSubMenu,
            this.SettingsSubMenu});
			this.NesPPUMenu.Location = new System.Drawing.Point(0, 0);
			this.NesPPUMenu.Name = "NesPPUMenu";
			this.NesPPUMenu.Size = new System.Drawing.Size(574, 24);
			this.NesPPUMenu.TabIndex = 10;
			this.NesPPUMenu.Text = "menuStrip1";
			// 
			// FileSubMenu
			// 
			this.FileSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePaletteScreenshotMenuItem,
            this.SavePatternScreenshotMenuItem,
            this.SaveSpriteScreenshotMenuItem,
            this.toolStripSeparator1,
            this.CopyPaletteToClipboardMenuItem,
            this.CopyPatternToClipboardMenuItem,
            this.CopySpriteToClipboardMenuItem,
            this.toolStripSeparator2,
            this.ExitMenuItem});
			this.FileSubMenu.Name = "FileSubMenu";
			this.FileSubMenu.Size = new System.Drawing.Size(37, 20);
			this.FileSubMenu.Text = "&File";
			// 
			// SavePaletteScreenshotMenuItem
			// 
			this.SavePaletteScreenshotMenuItem.Name = "SavePaletteScreenshotMenuItem";
			this.SavePaletteScreenshotMenuItem.Size = new System.Drawing.Size(212, 22);
			this.SavePaletteScreenshotMenuItem.Text = "Save Palette Screenshot...";
			this.SavePaletteScreenshotMenuItem.Click += new System.EventHandler(this.SavePaletteScreenshotMenuItem_Click);
			// 
			// SavePatternScreenshotMenuItem
			// 
			this.SavePatternScreenshotMenuItem.Name = "SavePatternScreenshotMenuItem";
			this.SavePatternScreenshotMenuItem.Size = new System.Drawing.Size(212, 22);
			this.SavePatternScreenshotMenuItem.Text = "Save Pattern Screenshot...";
			this.SavePatternScreenshotMenuItem.Click += new System.EventHandler(this.SavePatternScreenshotMenuItem_Click);
			// 
			// SaveSpriteScreenshotMenuItem
			// 
			this.SaveSpriteScreenshotMenuItem.Name = "SaveSpriteScreenshotMenuItem";
			this.SaveSpriteScreenshotMenuItem.Size = new System.Drawing.Size(212, 22);
			this.SaveSpriteScreenshotMenuItem.Text = "Save Sprite Screenshot...";
			this.SaveSpriteScreenshotMenuItem.Click += new System.EventHandler(this.SaveSpriteScreenshotMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
			// 
			// CopyPaletteToClipboardMenuItem
			// 
			this.CopyPaletteToClipboardMenuItem.Name = "CopyPaletteToClipboardMenuItem";
			this.CopyPaletteToClipboardMenuItem.Size = new System.Drawing.Size(212, 22);
			this.CopyPaletteToClipboardMenuItem.Text = "Copy Palette to Clipboard";
			this.CopyPaletteToClipboardMenuItem.Click += new System.EventHandler(this.CopyPaletteToClipboardMenuItem_Click);
			// 
			// CopyPatternToClipboardMenuItem
			// 
			this.CopyPatternToClipboardMenuItem.Name = "CopyPatternToClipboardMenuItem";
			this.CopyPatternToClipboardMenuItem.Size = new System.Drawing.Size(212, 22);
			this.CopyPatternToClipboardMenuItem.Text = "Copy Pattern to Clipboard";
			this.CopyPatternToClipboardMenuItem.Click += new System.EventHandler(this.CopyPatternToClipboardMenuItem_Click);
			// 
			// CopySpriteToClipboardMenuItem
			// 
			this.CopySpriteToClipboardMenuItem.Name = "CopySpriteToClipboardMenuItem";
			this.CopySpriteToClipboardMenuItem.Size = new System.Drawing.Size(212, 22);
			this.CopySpriteToClipboardMenuItem.Text = "Copy Sprite to Clipboard";
			this.CopySpriteToClipboardMenuItem.Click += new System.EventHandler(this.CopySpriteToClipboardMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.Size = new System.Drawing.Size(212, 22);
			this.ExitMenuItem.Text = "E&xit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// PatternSubMenu
			// 
			this.PatternSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Table0PaletteSubMenu,
            this.Table1PaletteSubMenu});
			this.PatternSubMenu.Name = "PatternSubMenu";
			this.PatternSubMenu.Size = new System.Drawing.Size(57, 20);
			this.PatternSubMenu.Text = "&Pattern";
			// 
			// Table0PaletteSubMenu
			// 
			this.Table0PaletteSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Table0P0MenuItem,
            this.Table0P1MenuItem,
            this.Table0P2MenuItem,
            this.Table0P3MenuItem,
            this.Table0P4MenuItem,
            this.Table0P5MenuItem,
            this.Table0P6MenuItem,
            this.Table0P7MenuItem});
			this.Table0PaletteSubMenu.Name = "Table0PaletteSubMenu";
			this.Table0PaletteSubMenu.Size = new System.Drawing.Size(151, 22);
			this.Table0PaletteSubMenu.Text = "Table 0 Palette";
			this.Table0PaletteSubMenu.DropDownOpened += new System.EventHandler(this.Table0PaletteSubMenu_DropDownOpened);
			// 
			// Table0P0MenuItem
			// 
			this.Table0P0MenuItem.Name = "Table0P0MenuItem";
			this.Table0P0MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P0MenuItem.Text = "0";
			this.Table0P0MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P1MenuItem
			// 
			this.Table0P1MenuItem.Name = "Table0P1MenuItem";
			this.Table0P1MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P1MenuItem.Text = "1";
			this.Table0P1MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P2MenuItem
			// 
			this.Table0P2MenuItem.Name = "Table0P2MenuItem";
			this.Table0P2MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P2MenuItem.Text = "2";
			this.Table0P2MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P3MenuItem
			// 
			this.Table0P3MenuItem.Name = "Table0P3MenuItem";
			this.Table0P3MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P3MenuItem.Text = "3";
			this.Table0P3MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P4MenuItem
			// 
			this.Table0P4MenuItem.Name = "Table0P4MenuItem";
			this.Table0P4MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P4MenuItem.Text = "4";
			this.Table0P4MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P5MenuItem
			// 
			this.Table0P5MenuItem.Name = "Table0P5MenuItem";
			this.Table0P5MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P5MenuItem.Text = "5";
			this.Table0P5MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P6MenuItem
			// 
			this.Table0P6MenuItem.Name = "Table0P6MenuItem";
			this.Table0P6MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P6MenuItem.Text = "6";
			this.Table0P6MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table0P7MenuItem
			// 
			this.Table0P7MenuItem.Name = "Table0P7MenuItem";
			this.Table0P7MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table0P7MenuItem.Text = "7";
			this.Table0P7MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1PaletteSubMenu
			// 
			this.Table1PaletteSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Table1P0MenuItem,
            this.Table1P1MenuItem,
            this.Table1P2MenuItem,
            this.Table1P3MenuItem,
            this.Table1P4MenuItem,
            this.Table1P5MenuItem,
            this.Table1P6MenuItem,
            this.Table1P7MenuItem});
			this.Table1PaletteSubMenu.Name = "Table1PaletteSubMenu";
			this.Table1PaletteSubMenu.Size = new System.Drawing.Size(151, 22);
			this.Table1PaletteSubMenu.Text = "Table 1 Palette";
			this.Table1PaletteSubMenu.DropDownOpened += new System.EventHandler(this.Table1PaletteSubMenu_DropDownOpened);
			// 
			// Table1P0MenuItem
			// 
			this.Table1P0MenuItem.Name = "Table1P0MenuItem";
			this.Table1P0MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P0MenuItem.Text = "0";
			this.Table1P0MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P1MenuItem
			// 
			this.Table1P1MenuItem.Name = "Table1P1MenuItem";
			this.Table1P1MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P1MenuItem.Text = "1";
			this.Table1P1MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P2MenuItem
			// 
			this.Table1P2MenuItem.Name = "Table1P2MenuItem";
			this.Table1P2MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P2MenuItem.Text = "2";
			this.Table1P2MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P3MenuItem
			// 
			this.Table1P3MenuItem.Name = "Table1P3MenuItem";
			this.Table1P3MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P3MenuItem.Text = "3";
			this.Table1P3MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P4MenuItem
			// 
			this.Table1P4MenuItem.Name = "Table1P4MenuItem";
			this.Table1P4MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P4MenuItem.Text = "4";
			this.Table1P4MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P5MenuItem
			// 
			this.Table1P5MenuItem.Name = "Table1P5MenuItem";
			this.Table1P5MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P5MenuItem.Text = "5";
			this.Table1P5MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P6MenuItem
			// 
			this.Table1P6MenuItem.Name = "Table1P6MenuItem";
			this.Table1P6MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P6MenuItem.Text = "6";
			this.Table1P6MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// Table1P7MenuItem
			// 
			this.Table1P7MenuItem.Name = "Table1P7MenuItem";
			this.Table1P7MenuItem.Size = new System.Drawing.Size(80, 22);
			this.Table1P7MenuItem.Text = "7";
			this.Table1P7MenuItem.Click += new System.EventHandler(this.Palette_Click);
			// 
			// SettingsSubMenu
			// 
			this.SettingsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoLoadMenuItem,
            this.SaveWindowPositionMenuItem,
            this.AlwaysOnTopMenuItem,
            this.FloatingWindowMenuItem});
			this.SettingsSubMenu.Name = "SettingsSubMenu";
			this.SettingsSubMenu.Size = new System.Drawing.Size(61, 20);
			this.SettingsSubMenu.Text = "&Settings";
			this.SettingsSubMenu.DropDownOpened += new System.EventHandler(this.SettingsSubMenu_DropDownOpened);
			// 
			// AutoLoadMenuItem
			// 
			this.AutoLoadMenuItem.Name = "AutoLoadMenuItem";
			this.AutoLoadMenuItem.Size = new System.Drawing.Size(191, 22);
			this.AutoLoadMenuItem.Text = "Autoload";
			this.AutoLoadMenuItem.Click += new System.EventHandler(this.AutoloadMenuItem_Click);
			// 
			// SaveWindowPositionMenuItem
			// 
			this.SaveWindowPositionMenuItem.Name = "SaveWindowPositionMenuItem";
			this.SaveWindowPositionMenuItem.Size = new System.Drawing.Size(191, 22);
			this.SaveWindowPositionMenuItem.Text = "Save Window Position";
			this.SaveWindowPositionMenuItem.Click += new System.EventHandler(this.SaveWindowPositionMenuItem_Click);
			// 
			// AlwaysOnTopMenuItem
			// 
			this.AlwaysOnTopMenuItem.Name = "AlwaysOnTopMenuItem";
			this.AlwaysOnTopMenuItem.Size = new System.Drawing.Size(191, 22);
			this.AlwaysOnTopMenuItem.Text = "Always On Top";
			this.AlwaysOnTopMenuItem.Click += new System.EventHandler(this.AlwaysOnTopMenuItem_Click);
			// 
			// FloatingWindowMenuItem
			// 
			this.FloatingWindowMenuItem.Name = "FloatingWindowMenuItem";
			this.FloatingWindowMenuItem.Size = new System.Drawing.Size(191, 22);
			this.FloatingWindowMenuItem.Text = "Floating Window";
			this.FloatingWindowMenuItem.Click += new System.EventHandler(this.FloatingWindowMenuItem_Click);
			// 
			// NesPPUStatusBar
			// 
			this.NesPPUStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.NesPPUStatusBar.Location = new System.Drawing.Point(0, 349);
			this.NesPPUStatusBar.Name = "NesPPUStatusBar";
			this.NesPPUStatusBar.Size = new System.Drawing.Size(574, 22);
			this.NesPPUStatusBar.SizingGrip = false;
			this.NesPPUStatusBar.TabIndex = 11;
			this.NesPPUStatusBar.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(348, 17);
			this.toolStripStatusLabel1.Text = "Use CTRL+C to copy the pane under the mouse to the clipboard.";
			// 
			// Messagetimer
			// 
			this.Messagetimer.Interval = 5000;
			this.Messagetimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
			// 
			// NesPPU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 371);
			this.Controls.Add(this.NesPPUStatusBar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.SpriteViewerBox);
			this.Controls.Add(this.NesPPUMenu);
			this.Controls.Add(this.DetailsBox);
			this.Controls.Add(this.PalettesGroup);
			this.Controls.Add(this.PatternGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.NesPPUMenu;
			this.MinimumSize = new System.Drawing.Size(580, 370);
			this.Name = "NesPPU";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NES PPU Viewer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NesPPU_FormClosed);
			this.Load += new System.EventHandler(this.NesPPU_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NesPPU_KeyDown);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NesPPU_MouseClick);
			this.PatternGroup.ResumeLayout(false);
			this.PatternGroup.PerformLayout();
			this.PatternContext.ResumeLayout(false);
			this.PalettesGroup.ResumeLayout(false);
			this.PaletteContext.ResumeLayout(false);
			this.DetailsBox.ResumeLayout(false);
			this.DetailsBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZoomBox)).EndInit();
			this.SpriteViewerBox.ResumeLayout(false);
			this.SpriteContext.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RefreshRate)).EndInit();
			this.NesPPUMenu.ResumeLayout(false);
			this.NesPPUMenu.PerformLayout();
			this.NesPPUStatusBar.ResumeLayout(false);
			this.NesPPUStatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox PatternGroup;
		private System.Windows.Forms.GroupBox PalettesGroup;
		private PaletteViewer PaletteView;
		private System.Windows.Forms.GroupBox DetailsBox;
		private System.Windows.Forms.Label ValueLabel;
		private System.Windows.Forms.Label AddressLabel;
		private PatternViewer PatternView;
		private System.Windows.Forms.Label Table1PaletteLabel;
		private System.Windows.Forms.Label Table0PaletteLabel;
		private System.Windows.Forms.Label Value2Label;
		private System.Windows.Forms.GroupBox SpriteViewerBox;
		private SpriteViewer SpriteView;
		private System.Windows.Forms.TextBox txtScanline;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label Value3Label;
		private System.Windows.Forms.PictureBox ZoomBox;
		private System.Windows.Forms.Label Value5Label;
		private System.Windows.Forms.Label Value4Label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TrackBar RefreshRate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private MenuStripEx NesPPUMenu;
		private System.Windows.Forms.ToolStripMenuItem SettingsSubMenu;
		private System.Windows.Forms.ToolStripMenuItem AutoLoadMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveWindowPositionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PatternSubMenu;
		private System.Windows.Forms.ToolStripMenuItem Table0PaletteSubMenu;
		private System.Windows.Forms.ToolStripMenuItem Table0P0MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P1MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P2MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P3MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P4MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P5MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P6MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table0P7MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1PaletteSubMenu;
		private System.Windows.Forms.ToolStripMenuItem Table1P0MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P1MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P2MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P3MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P4MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P5MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P6MenuItem;
		private System.Windows.Forms.ToolStripMenuItem Table1P7MenuItem;
		private System.Windows.Forms.ToolStripMenuItem FileSubMenu;
		private System.Windows.Forms.ToolStripMenuItem SavePaletteScreenshotMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SavePatternScreenshotMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveSpriteScreenshotMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ContextMenuStrip PaletteContext;
		private System.Windows.Forms.ToolStripMenuItem PaletteSaveImageMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PaletteRefreshMenuItem;
		private System.Windows.Forms.ContextMenuStrip PatternContext;
		private System.Windows.Forms.ToolStripMenuItem PatternSaveImageMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PatternRefreshMenuItem;
		private System.Windows.Forms.ContextMenuStrip SpriteContext;
		private System.Windows.Forms.ToolStripMenuItem SpriteSaveImageMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SpriteRefreshMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SpriteImageToClipboardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PatternImageToClipboardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PaletteImageToClipboardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyPaletteToClipboardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyPatternToClipboardMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopySpriteToClipboardMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.StatusStrip NesPPUStatusBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Timer Messagetimer;
		private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FloatingWindowMenuItem;
	}
}