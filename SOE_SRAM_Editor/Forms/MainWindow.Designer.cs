﻿namespace SOE_SRAM_Editor
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SaveTab = new System.Windows.Forms.TabControl();
            this.StatsTab = new System.Windows.Forms.TabPage();
            this.DogStatsBox = new System.Windows.Forms.GroupBox();
            this.BoyStatsBox = new System.Windows.Forms.GroupBox();
            this.MoneyGroup = new System.Windows.Forms.GroupBox();
            this.CreditsTextBox = new System.Windows.Forms.TextBox();
            this.CoinsTextBox = new System.Windows.Forms.TextBox();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.JewelsLabel = new System.Windows.Forms.Label();
            this.TalonsLabel = new System.Windows.Forms.Label();
            this.JewelsTextBox = new System.Windows.Forms.TextBox();
            this.TalonsTextBox = new System.Windows.Forms.TextBox();
            this.NamesGroup = new System.Windows.Forms.GroupBox();
            this.BoyNameLabel = new System.Windows.Forms.Label();
            this.DogNameLabel = new System.Windows.Forms.Label();
            this.BoyNameTextBox = new System.Windows.Forms.TextBox();
            this.DogNameTextBox = new System.Windows.Forms.TextBox();
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.BoneCheckBox = new System.Windows.Forms.CheckBox();
            this.AlchemyTab = new System.Windows.Forms.TabPage();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.TradingItems = new System.Windows.Forms.TabPage();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlotMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlot1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlotSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSlot2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlotSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSlot3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlotSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSlot4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableLimitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExperimentalSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EnableLimitsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LimitsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveSlotLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RegionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenSRAMDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveTab.SuspendLayout();
            this.StatsTab.SuspendLayout();
            this.MoneyGroup.SuspendLayout();
            this.NamesGroup.SuspendLayout();
            this.EquipmentTab.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveTab
            // 
            this.SaveTab.Controls.Add(this.StatsTab);
            this.SaveTab.Controls.Add(this.EquipmentTab);
            this.SaveTab.Controls.Add(this.AlchemyTab);
            this.SaveTab.Controls.Add(this.InventoryTab);
            this.SaveTab.Controls.Add(this.TradingItems);
            this.SaveTab.Location = new System.Drawing.Point(12, 27);
            this.SaveTab.Name = "SaveTab";
            this.SaveTab.SelectedIndex = 0;
            this.SaveTab.Size = new System.Drawing.Size(592, 365);
            this.SaveTab.TabIndex = 0;
            // 
            // StatsTab
            // 
            this.StatsTab.Controls.Add(this.DogStatsBox);
            this.StatsTab.Controls.Add(this.BoyStatsBox);
            this.StatsTab.Controls.Add(this.MoneyGroup);
            this.StatsTab.Controls.Add(this.NamesGroup);
            this.StatsTab.Location = new System.Drawing.Point(4, 22);
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatsTab.Size = new System.Drawing.Size(584, 339);
            this.StatsTab.TabIndex = 0;
            this.StatsTab.Text = "Stats";
            this.StatsTab.UseVisualStyleBackColor = true;
            // 
            // DogStatsBox
            // 
            this.DogStatsBox.Location = new System.Drawing.Point(6, 250);
            this.DogStatsBox.Name = "DogStatsBox";
            this.DogStatsBox.Size = new System.Drawing.Size(572, 79);
            this.DogStatsBox.TabIndex = 7;
            this.DogStatsBox.TabStop = false;
            this.DogStatsBox.Text = "DogStats";
            // 
            // BoyStatsBox
            // 
            this.BoyStatsBox.Location = new System.Drawing.Point(6, 165);
            this.BoyStatsBox.Name = "BoyStatsBox";
            this.BoyStatsBox.Size = new System.Drawing.Size(572, 79);
            this.BoyStatsBox.TabIndex = 6;
            this.BoyStatsBox.TabStop = false;
            this.BoyStatsBox.Text = "Boy Stats";
            // 
            // MoneyGroup
            // 
            this.MoneyGroup.Controls.Add(this.CreditsTextBox);
            this.MoneyGroup.Controls.Add(this.CoinsTextBox);
            this.MoneyGroup.Controls.Add(this.CreditsLabel);
            this.MoneyGroup.Controls.Add(this.CoinsLabel);
            this.MoneyGroup.Controls.Add(this.JewelsLabel);
            this.MoneyGroup.Controls.Add(this.TalonsLabel);
            this.MoneyGroup.Controls.Add(this.JewelsTextBox);
            this.MoneyGroup.Controls.Add(this.TalonsTextBox);
            this.MoneyGroup.Location = new System.Drawing.Point(6, 87);
            this.MoneyGroup.Name = "MoneyGroup";
            this.MoneyGroup.Size = new System.Drawing.Size(572, 72);
            this.MoneyGroup.TabIndex = 5;
            this.MoneyGroup.TabStop = false;
            this.MoneyGroup.Text = "Money";
            // 
            // CreditsTextBox
            // 
            this.CreditsTextBox.Location = new System.Drawing.Point(279, 45);
            this.CreditsTextBox.Name = "CreditsTextBox";
            this.CreditsTextBox.Size = new System.Drawing.Size(248, 20);
            this.CreditsTextBox.TabIndex = 7;
            this.CreditsTextBox.Text = "0";
            // 
            // CoinsTextBox
            // 
            this.CoinsTextBox.Location = new System.Drawing.Point(279, 19);
            this.CoinsTextBox.Name = "CoinsTextBox";
            this.CoinsTextBox.Size = new System.Drawing.Size(248, 20);
            this.CoinsTextBox.TabIndex = 6;
            this.CoinsTextBox.Text = "0";
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Location = new System.Drawing.Point(533, 49);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(39, 13);
            this.CreditsLabel.TabIndex = 5;
            this.CreditsLabel.Text = "Credits";
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.AutoSize = true;
            this.CoinsLabel.Location = new System.Drawing.Point(533, 22);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(33, 13);
            this.CoinsLabel.TabIndex = 4;
            this.CoinsLabel.Text = "Coins";
            // 
            // JewelsLabel
            // 
            this.JewelsLabel.AutoSize = true;
            this.JewelsLabel.Location = new System.Drawing.Point(238, 49);
            this.JewelsLabel.Name = "JewelsLabel";
            this.JewelsLabel.Size = new System.Drawing.Size(39, 13);
            this.JewelsLabel.TabIndex = 3;
            this.JewelsLabel.Text = "Jewels";
            // 
            // TalonsLabel
            // 
            this.TalonsLabel.AutoSize = true;
            this.TalonsLabel.Location = new System.Drawing.Point(238, 23);
            this.TalonsLabel.Name = "TalonsLabel";
            this.TalonsLabel.Size = new System.Drawing.Size(39, 13);
            this.TalonsLabel.TabIndex = 2;
            this.TalonsLabel.Text = "Talons";
            // 
            // JewelsTextBox
            // 
            this.JewelsTextBox.Location = new System.Drawing.Point(7, 46);
            this.JewelsTextBox.Name = "JewelsTextBox";
            this.JewelsTextBox.Size = new System.Drawing.Size(225, 20);
            this.JewelsTextBox.TabIndex = 1;
            this.JewelsTextBox.Text = "0";
            // 
            // TalonsTextBox
            // 
            this.TalonsTextBox.Location = new System.Drawing.Point(7, 20);
            this.TalonsTextBox.Name = "TalonsTextBox";
            this.TalonsTextBox.Size = new System.Drawing.Size(225, 20);
            this.TalonsTextBox.TabIndex = 0;
            this.TalonsTextBox.Text = "0";
            // 
            // NamesGroup
            // 
            this.NamesGroup.Controls.Add(this.BoyNameLabel);
            this.NamesGroup.Controls.Add(this.DogNameLabel);
            this.NamesGroup.Controls.Add(this.BoyNameTextBox);
            this.NamesGroup.Controls.Add(this.DogNameTextBox);
            this.NamesGroup.Location = new System.Drawing.Point(6, 6);
            this.NamesGroup.Name = "NamesGroup";
            this.NamesGroup.Size = new System.Drawing.Size(572, 75);
            this.NamesGroup.TabIndex = 4;
            this.NamesGroup.TabStop = false;
            this.NamesGroup.Text = "Names";
            // 
            // BoyNameLabel
            // 
            this.BoyNameLabel.AutoSize = true;
            this.BoyNameLabel.Location = new System.Drawing.Point(508, 22);
            this.BoyNameLabel.Name = "BoyNameLabel";
            this.BoyNameLabel.Size = new System.Drawing.Size(56, 13);
            this.BoyNameLabel.TabIndex = 2;
            this.BoyNameLabel.Text = "Boy Name";
            // 
            // DogNameLabel
            // 
            this.DogNameLabel.AutoSize = true;
            this.DogNameLabel.Location = new System.Drawing.Point(508, 48);
            this.DogNameLabel.Name = "DogNameLabel";
            this.DogNameLabel.Size = new System.Drawing.Size(58, 13);
            this.DogNameLabel.TabIndex = 3;
            this.DogNameLabel.Text = "Dog Name";
            // 
            // BoyNameTextBox
            // 
            this.BoyNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.BoyNameTextBox.Name = "BoyNameTextBox";
            this.BoyNameTextBox.Size = new System.Drawing.Size(498, 20);
            this.BoyNameTextBox.TabIndex = 0;
            this.BoyNameTextBox.Text = "Boy";
            // 
            // DogNameTextBox
            // 
            this.DogNameTextBox.Location = new System.Drawing.Point(6, 45);
            this.DogNameTextBox.Name = "DogNameTextBox";
            this.DogNameTextBox.Size = new System.Drawing.Size(498, 20);
            this.DogNameTextBox.TabIndex = 1;
            this.DogNameTextBox.Text = "Dog";
            // 
            // EquipmentTab
            // 
            this.EquipmentTab.Controls.Add(this.BoneCheckBox);
            this.EquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.EquipmentTab.Name = "EquipmentTab";
            this.EquipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.EquipmentTab.Size = new System.Drawing.Size(584, 339);
            this.EquipmentTab.TabIndex = 1;
            this.EquipmentTab.Text = "Equipment";
            this.EquipmentTab.UseVisualStyleBackColor = true;
            // 
            // BoneCheckBox
            // 
            this.BoneCheckBox.AutoSize = true;
            this.BoneCheckBox.Location = new System.Drawing.Point(3, 6);
            this.BoneCheckBox.Name = "BoneCheckBox";
            this.BoneCheckBox.Size = new System.Drawing.Size(51, 17);
            this.BoneCheckBox.TabIndex = 0;
            this.BoneCheckBox.Text = "Bone";
            this.BoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlchemyTab
            // 
            this.AlchemyTab.Location = new System.Drawing.Point(4, 22);
            this.AlchemyTab.Name = "AlchemyTab";
            this.AlchemyTab.Size = new System.Drawing.Size(584, 339);
            this.AlchemyTab.TabIndex = 2;
            this.AlchemyTab.Text = "Alchemy";
            this.AlchemyTab.UseVisualStyleBackColor = true;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(584, 339);
            this.InventoryTab.TabIndex = 3;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // TradingItems
            // 
            this.TradingItems.Location = new System.Drawing.Point(4, 22);
            this.TradingItems.Name = "TradingItems";
            this.TradingItems.Size = new System.Drawing.Size(584, 339);
            this.TradingItems.TabIndex = 4;
            this.TradingItems.Text = "Trading Items";
            this.TradingItems.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.SaveSlotMenu,
            this.AboutMenu,
            this.experimentalToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(616, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuItem,
            this.FileSeparator1,
            this.SaveFileMenuItem,
            this.FileSeparator2,
            this.ExitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenFileMenuItem.Text = "Open";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // FileSeparator1
            // 
            this.FileSeparator1.Name = "FileSeparator1";
            this.FileSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveFileMenuItem
            // 
            this.SaveFileMenuItem.Name = "SaveFileMenuItem";
            this.SaveFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveFileMenuItem.Text = "Save";
            this.SaveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // FileSeparator2
            // 
            this.FileSeparator2.Name = "FileSeparator2";
            this.FileSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // SaveSlotMenu
            // 
            this.SaveSlotMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveSlot1MenuItem,
            this.SaveSlotSeparator1,
            this.SaveSlot2MenuItem,
            this.SaveSlotSeparator2,
            this.SaveSlot3MenuItem,
            this.SaveSlotSeparator3,
            this.SaveSlot4MenuItem});
            this.SaveSlotMenu.Name = "SaveSlotMenu";
            this.SaveSlotMenu.Size = new System.Drawing.Size(66, 20);
            this.SaveSlotMenu.Text = "Save Slot";
            // 
            // SaveSlot1MenuItem
            // 
            this.SaveSlot1MenuItem.Name = "SaveSlot1MenuItem";
            this.SaveSlot1MenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveSlot1MenuItem.Text = "Save Slot 1";
            this.SaveSlot1MenuItem.Click += new System.EventHandler(this.SaveSlot1MenuItem_Click);
            // 
            // SaveSlotSeparator1
            // 
            this.SaveSlotSeparator1.Name = "SaveSlotSeparator1";
            this.SaveSlotSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // SaveSlot2MenuItem
            // 
            this.SaveSlot2MenuItem.Name = "SaveSlot2MenuItem";
            this.SaveSlot2MenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveSlot2MenuItem.Text = "Save Slot 2";
            this.SaveSlot2MenuItem.Click += new System.EventHandler(this.SaveSlot2MenuItem_Click);
            // 
            // SaveSlotSeparator2
            // 
            this.SaveSlotSeparator2.Name = "SaveSlotSeparator2";
            this.SaveSlotSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // SaveSlot3MenuItem
            // 
            this.SaveSlot3MenuItem.Name = "SaveSlot3MenuItem";
            this.SaveSlot3MenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveSlot3MenuItem.Text = "Save Slot 3";
            this.SaveSlot3MenuItem.Click += new System.EventHandler(this.SaveSlot3MenuItem_Click);
            // 
            // SaveSlotSeparator3
            // 
            this.SaveSlotSeparator3.Name = "SaveSlotSeparator3";
            this.SaveSlotSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // SaveSlot4MenuItem
            // 
            this.SaveSlot4MenuItem.Name = "SaveSlot4MenuItem";
            this.SaveSlot4MenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveSlot4MenuItem.Text = "Save Slot 4";
            this.SaveSlot4MenuItem.Click += new System.EventHandler(this.SaveSlot4MenuItem_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // experimentalToolStripMenuItem
            // 
            this.experimentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisableLimitsMenuItem,
            this.ExperimentalSeparator1,
            this.EnableLimitsMenuItem});
            this.experimentalToolStripMenuItem.Name = "experimentalToolStripMenuItem";
            this.experimentalToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.experimentalToolStripMenuItem.Text = "Experimental";
            // 
            // DisableLimitsMenuItem
            // 
            this.DisableLimitsMenuItem.Name = "DisableLimitsMenuItem";
            this.DisableLimitsMenuItem.Size = new System.Drawing.Size(147, 22);
            this.DisableLimitsMenuItem.Text = "Disable Limits";
            this.DisableLimitsMenuItem.Click += new System.EventHandler(this.DisableLimitsMenuItem_Click);
            // 
            // ExperimentalSeparator1
            // 
            this.ExperimentalSeparator1.Name = "ExperimentalSeparator1";
            this.ExperimentalSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // EnableLimitsMenuItem
            // 
            this.EnableLimitsMenuItem.Name = "EnableLimitsMenuItem";
            this.EnableLimitsMenuItem.Size = new System.Drawing.Size(147, 22);
            this.EnableLimitsMenuItem.Text = "Enable Limits";
            this.EnableLimitsMenuItem.Click += new System.EventHandler(this.EnableLimitsMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LimitsLabel,
            this.SaveSlotLabel,
            this.RegionLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 400);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(616, 22);
            this.StatusStrip.TabIndex = 2;
            // 
            // LimitsLabel
            // 
            this.LimitsLabel.Name = "LimitsLabel";
            this.LimitsLabel.Size = new System.Drawing.Size(84, 17);
            this.LimitsLabel.Text = "Limits Enabled";
            // 
            // SaveSlotLabel
            // 
            this.SaveSlotLabel.Name = "SaveSlotLabel";
            this.SaveSlotLabel.Size = new System.Drawing.Size(63, 17);
            this.SaveSlotLabel.Text = "Save Slot 1";
            // 
            // RegionLabel
            // 
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(100, 17);
            this.RegionLabel.Text = "No SRAM Loaded";
            // 
            // OpenSRAMDialog
            // 
            this.OpenSRAMDialog.DefaultExt = "srm";
            this.OpenSRAMDialog.Filter = "Secret of Evermore SRAM Files|*.srm";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 422);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SaveTab);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Secret of Evermore SRAM Editor - No SRAM Loaded";
            this.SaveTab.ResumeLayout(false);
            this.StatsTab.ResumeLayout(false);
            this.MoneyGroup.ResumeLayout(false);
            this.MoneyGroup.PerformLayout();
            this.NamesGroup.ResumeLayout(false);
            this.NamesGroup.PerformLayout();
            this.EquipmentTab.ResumeLayout(false);
            this.EquipmentTab.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SaveTab;
        private System.Windows.Forms.TabPage StatsTab;
        private System.Windows.Forms.TabPage EquipmentTab;
        private System.Windows.Forms.TabPage AlchemyTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage TradingItems;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSlotMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveSlot1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSlot2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSlot3MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSlot4MenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.Label DogNameLabel;
        private System.Windows.Forms.Label BoyNameLabel;
        private System.Windows.Forms.TextBox DogNameTextBox;
        private System.Windows.Forms.TextBox BoyNameTextBox;
        private System.Windows.Forms.CheckBox BoneCheckBox;
        private System.Windows.Forms.GroupBox NamesGroup;
        private System.Windows.Forms.GroupBox MoneyGroup;
        private System.Windows.Forms.GroupBox DogStatsBox;
        private System.Windows.Forms.GroupBox BoyStatsBox;
        private System.Windows.Forms.TextBox CreditsTextBox;
        private System.Windows.Forms.TextBox CoinsTextBox;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.Label JewelsLabel;
        private System.Windows.Forms.Label TalonsLabel;
        private System.Windows.Forms.TextBox JewelsTextBox;
        private System.Windows.Forms.TextBox TalonsTextBox;
        private System.Windows.Forms.ToolStripMenuItem experimentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisableLimitsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnableLimitsMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LimitsLabel;
        private System.Windows.Forms.ToolStripSeparator SaveSlotSeparator1;
        private System.Windows.Forms.ToolStripSeparator SaveSlotSeparator2;
        private System.Windows.Forms.ToolStripSeparator SaveSlotSeparator3;
        private System.Windows.Forms.ToolStripSeparator ExperimentalSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel SaveSlotLabel;
        private System.Windows.Forms.ToolStripStatusLabel RegionLabel;
        private System.Windows.Forms.OpenFileDialog OpenSRAMDialog;
    }
}

