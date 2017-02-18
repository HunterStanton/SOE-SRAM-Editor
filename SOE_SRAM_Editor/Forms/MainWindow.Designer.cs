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
            this.SaveTab = new System.Windows.Forms.TabControl();
            this.StatsTab = new System.Windows.Forms.TabPage();
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.AlchemyTab = new System.Windows.Forms.TabPage();
            this.SaveTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveTab
            // 
            this.SaveTab.Controls.Add(this.StatsTab);
            this.SaveTab.Controls.Add(this.EquipmentTab);
            this.SaveTab.Controls.Add(this.AlchemyTab);
            this.SaveTab.Location = new System.Drawing.Point(12, 12);
            this.SaveTab.Name = "SaveTab";
            this.SaveTab.SelectedIndex = 0;
            this.SaveTab.Size = new System.Drawing.Size(592, 340);
            this.SaveTab.TabIndex = 0;
            // 
            // StatsTab
            // 
            this.StatsTab.Location = new System.Drawing.Point(4, 22);
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatsTab.Size = new System.Drawing.Size(584, 314);
            this.StatsTab.TabIndex = 0;
            this.StatsTab.Text = "Stats";
            this.StatsTab.UseVisualStyleBackColor = true;
            // 
            // EquipmentTab
            // 
            this.EquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.EquipmentTab.Name = "EquipmentTab";
            this.EquipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.EquipmentTab.Size = new System.Drawing.Size(584, 314);
            this.EquipmentTab.TabIndex = 1;
            this.EquipmentTab.Text = "Equipment";
            this.EquipmentTab.UseVisualStyleBackColor = true;
            // 
            // AlchemyTab
            // 
            this.AlchemyTab.Location = new System.Drawing.Point(4, 22);
            this.AlchemyTab.Name = "AlchemyTab";
            this.AlchemyTab.Size = new System.Drawing.Size(584, 314);
            this.AlchemyTab.TabIndex = 2;
            this.AlchemyTab.Text = "Alchemy";
            this.AlchemyTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 364);
            this.Controls.Add(this.SaveTab);
            this.Name = "MainWindow";
            this.Text = "Secret of Evermore SRAM Editor - No ROM Loaded";
            this.SaveTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SaveTab;
        private System.Windows.Forms.TabPage StatsTab;
        private System.Windows.Forms.TabPage EquipmentTab;
        private System.Windows.Forms.TabPage AlchemyTab;
    }
}

