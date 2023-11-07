namespace ONeilloGameV3
{
    partial class Form1
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.informationPanelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel.SuspendLayout();
            this.informationPanelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.statusLabel1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 487);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(568, 100);
            this.infoPanel.TabIndex = 0;
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Location = new System.Drawing.Point(262, 13);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(13, 13);
            this.statusLabel1.TabIndex = 0;
            this.statusLabel1.Text = "a";
            // 
            // informationPanelMenuStrip
            // 
            this.informationPanelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.informationPanelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.informationPanelMenuStrip.Name = "informationPanelMenuStrip";
            this.informationPanelMenuStrip.Size = new System.Drawing.Size(568, 24);
            this.informationPanelMenuStrip.TabIndex = 1;
            this.informationPanelMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameTab,
            this.saveGameTab});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Game";
            // 
            // newGameTab
            // 
            this.newGameTab.Name = "newGameTab";
            this.newGameTab.Size = new System.Drawing.Size(180, 22);
            this.newGameTab.Text = "New Game";
            this.newGameTab.Click += new System.EventHandler(this.newGameTab_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveGameTab
            // 
            this.saveGameTab.Name = "saveGameTab";
            this.saveGameTab.Size = new System.Drawing.Size(180, 22);
            this.saveGameTab.Text = "Save Game";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 587);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.informationPanelMenuStrip);
            this.MainMenuStrip = this.informationPanelMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.informationPanelMenuStrip.ResumeLayout(false);
            this.informationPanelMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label statusLabel1;
        private System.Windows.Forms.MenuStrip informationPanelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameTab;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameTab;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

