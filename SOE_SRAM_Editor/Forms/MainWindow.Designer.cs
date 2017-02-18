namespace SOE_SRAM_Editor
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
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.AlchemyTab = new System.Windows.Forms.TabPage();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.Pouch = new System.Windows.Forms.TabPage();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlotMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlot1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlot2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlot3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSlot4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BoyNameTextBox = new System.Windows.Forms.TextBox();
            this.DogNameTextBox = new System.Windows.Forms.TextBox();
            this.BoyNameLabel = new System.Windows.Forms.Label();
            this.DogNameLabel = new System.Windows.Forms.Label();
            this.BoneCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveTab.SuspendLayout();
            this.StatsTab.SuspendLayout();
            this.EquipmentTab.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveTab
            // 
            this.SaveTab.Controls.Add(this.StatsTab);
            this.SaveTab.Controls.Add(this.EquipmentTab);
            this.SaveTab.Controls.Add(this.AlchemyTab);
            this.SaveTab.Controls.Add(this.InventoryTab);
            this.SaveTab.Controls.Add(this.Pouch);
            this.SaveTab.Location = new System.Drawing.Point(12, 27);
            this.SaveTab.Name = "SaveTab";
            this.SaveTab.SelectedIndex = 0;
            this.SaveTab.Size = new System.Drawing.Size(592, 331);
            this.SaveTab.TabIndex = 0;
            // 
            // StatsTab
            // 
            this.StatsTab.Controls.Add(this.DogNameLabel);
            this.StatsTab.Controls.Add(this.BoyNameLabel);
            this.StatsTab.Controls.Add(this.DogNameTextBox);
            this.StatsTab.Controls.Add(this.BoyNameTextBox);
            this.StatsTab.Location = new System.Drawing.Point(4, 22);
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatsTab.Size = new System.Drawing.Size(584, 305);
            this.StatsTab.TabIndex = 0;
            this.StatsTab.Text = "Stats";
            this.StatsTab.UseVisualStyleBackColor = true;
            // 
            // EquipmentTab
            // 
            this.EquipmentTab.Controls.Add(this.BoneCheckBox);
            this.EquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.EquipmentTab.Name = "EquipmentTab";
            this.EquipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.EquipmentTab.Size = new System.Drawing.Size(584, 305);
            this.EquipmentTab.TabIndex = 1;
            this.EquipmentTab.Text = "Equipment";
            this.EquipmentTab.UseVisualStyleBackColor = true;
            // 
            // AlchemyTab
            // 
            this.AlchemyTab.Location = new System.Drawing.Point(4, 22);
            this.AlchemyTab.Name = "AlchemyTab";
            this.AlchemyTab.Size = new System.Drawing.Size(584, 305);
            this.AlchemyTab.TabIndex = 2;
            this.AlchemyTab.Text = "Alchemy";
            this.AlchemyTab.UseVisualStyleBackColor = true;
            // 
            // InventoryTab
            // 
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(584, 305);
            this.InventoryTab.TabIndex = 3;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // Pouch
            // 
            this.Pouch.Location = new System.Drawing.Point(4, 22);
            this.Pouch.Name = "Pouch";
            this.Pouch.Size = new System.Drawing.Size(584, 305);
            this.Pouch.TabIndex = 4;
            this.Pouch.Text = "Trading Items";
            this.Pouch.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.SaveSlotMenu,
            this.AboutMenu});
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
            this.Separator1,
            this.SaveFileMenuItem,
            this.Separator2,
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
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveFileMenuItem
            // 
            this.SaveFileMenuItem.Name = "SaveFileMenuItem";
            this.SaveFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveFileMenuItem.Text = "Save";
            this.SaveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(149, 6);
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
            this.SaveSlot2MenuItem,
            this.SaveSlot3MenuItem,
            this.SaveSlot4MenuItem});
            this.SaveSlotMenu.Name = "SaveSlotMenu";
            this.SaveSlotMenu.Size = new System.Drawing.Size(66, 20);
            this.SaveSlotMenu.Text = "Save Slot";
            // 
            // SaveSlot1MenuItem
            // 
            this.SaveSlot1MenuItem.Name = "SaveSlot1MenuItem";
            this.SaveSlot1MenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveSlot1MenuItem.Text = "Save Slot 1";
            this.SaveSlot1MenuItem.Click += new System.EventHandler(this.SaveSlot1MenuItem_Click);
            // 
            // SaveSlot2MenuItem
            // 
            this.SaveSlot2MenuItem.Name = "SaveSlot2MenuItem";
            this.SaveSlot2MenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveSlot2MenuItem.Text = "Save Slot 2";
            this.SaveSlot2MenuItem.Click += new System.EventHandler(this.SaveSlot2MenuItem_Click);
            // 
            // SaveSlot3MenuItem
            // 
            this.SaveSlot3MenuItem.Name = "SaveSlot3MenuItem";
            this.SaveSlot3MenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveSlot3MenuItem.Text = "Save Slot 3";
            this.SaveSlot3MenuItem.Click += new System.EventHandler(this.SaveSlot3MenuItem_Click);
            // 
            // SaveSlot4MenuItem
            // 
            this.SaveSlot4MenuItem.Name = "SaveSlot4MenuItem";
            this.SaveSlot4MenuItem.Size = new System.Drawing.Size(152, 22);
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
            // BoyNameTextBox
            // 
            this.BoyNameTextBox.Location = new System.Drawing.Point(6, 6);
            this.BoyNameTextBox.Name = "BoyNameTextBox";
            this.BoyNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.BoyNameTextBox.TabIndex = 0;
            this.BoyNameTextBox.Text = "Boy";
            // 
            // DogNameTextBox
            // 
            this.DogNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.DogNameTextBox.Name = "DogNameTextBox";
            this.DogNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.DogNameTextBox.TabIndex = 1;
            this.DogNameTextBox.Text = "Dog";
            // 
            // BoyNameLabel
            // 
            this.BoyNameLabel.AutoSize = true;
            this.BoyNameLabel.Location = new System.Drawing.Point(198, 7);
            this.BoyNameLabel.Name = "BoyNameLabel";
            this.BoyNameLabel.Size = new System.Drawing.Size(56, 13);
            this.BoyNameLabel.TabIndex = 2;
            this.BoyNameLabel.Text = "Boy Name";
            // 
            // DogNameLabel
            // 
            this.DogNameLabel.AutoSize = true;
            this.DogNameLabel.Location = new System.Drawing.Point(198, 35);
            this.DogNameLabel.Name = "DogNameLabel";
            this.DogNameLabel.Size = new System.Drawing.Size(58, 13);
            this.DogNameLabel.TabIndex = 3;
            this.DogNameLabel.Text = "Dog Name";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 370);
            this.Controls.Add(this.SaveTab);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainWindow";
            this.Text = "Secret of Evermore SRAM Editor - No ROM Loaded";
            this.SaveTab.ResumeLayout(false);
            this.StatsTab.ResumeLayout(false);
            this.StatsTab.PerformLayout();
            this.EquipmentTab.ResumeLayout(false);
            this.EquipmentTab.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SaveTab;
        private System.Windows.Forms.TabPage StatsTab;
        private System.Windows.Forms.TabPage EquipmentTab;
        private System.Windows.Forms.TabPage AlchemyTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage Pouch;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator2;
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
    }
}

