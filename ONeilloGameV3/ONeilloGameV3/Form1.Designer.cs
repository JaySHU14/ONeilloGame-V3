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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.informationPanelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameTab = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoPanel.SuspendLayout();
            this.informationPanelMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.infoPanel.Controls.Add(this.pictureBox1);
            this.infoPanel.Controls.Add(this.player2ScoreLabel);
            this.infoPanel.Controls.Add(this.player1ScoreLabel);
            this.infoPanel.Controls.Add(this.player2TextBox);
            this.infoPanel.Controls.Add(this.player1TextBox);
            this.infoPanel.Controls.Add(this.statusLabel1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel.Location = new System.Drawing.Point(0, 569);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(539, 121);
            this.infoPanel.TabIndex = 0;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Location = new System.Drawing.Point(287, 40);
            this.player2ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(101, 16);
            this.player2ScoreLabel.TabIndex = 4;
            this.player2ScoreLabel.Text = "Current Score: 2";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Location = new System.Drawing.Point(13, 40);
            this.player1ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(101, 16);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "Current Score: 2";
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(382, 73);
            this.player2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(145, 22);
            this.player2TextBox.TabIndex = 2;
            this.player2TextBox.Text = "Player #2";
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(129, 73);
            this.player1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(145, 22);
            this.player1TextBox.TabIndex = 1;
            this.player1TextBox.Text = "Player #1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.AutoSize = true;
            this.statusLabel1.Location = new System.Drawing.Point(143, 13);
            this.statusLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(131, 16);
            this.statusLabel1.TabIndex = 0;
            this.statusLabel1.Text = "Current Player: Black";
            // 
            // informationPanelMenuStrip
            // 
            this.informationPanelMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.informationPanelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.informationPanelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.informationPanelMenuStrip.Name = "informationPanelMenuStrip";
            this.informationPanelMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.informationPanelMenuStrip.Size = new System.Drawing.Size(539, 30);
            this.informationPanelMenuStrip.TabIndex = 1;
            this.informationPanelMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameTab,
            this.saveGameTab});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 26);
            this.toolStripMenuItem1.Text = "Game";
            // 
            // newGameTab
            // 
            this.newGameTab.Name = "newGameTab";
            this.newGameTab.Size = new System.Drawing.Size(166, 26);
            this.newGameTab.Text = "New Game";
            this.newGameTab.Click += new System.EventHandler(this.newGameTab_Click);
            // 
            // saveGameTab
            // 
            this.saveGameTab.Name = "saveGameTab";
            this.saveGameTab.Size = new System.Drawing.Size(166, 26);
            this.saveGameTab.Text = "Save Game";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationPanelToolStripMenuItem,
            this.speakToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // informationPanelToolStripMenuItem
            // 
            this.informationPanelToolStripMenuItem.Checked = true;
            this.informationPanelToolStripMenuItem.CheckOnClick = true;
            this.informationPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.informationPanelToolStripMenuItem.Name = "informationPanelToolStripMenuItem";
            this.informationPanelToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.informationPanelToolStripMenuItem.Text = "Information Panel";
            // 
            // speakToolStripMenuItem
            // 
            this.speakToolStripMenuItem.Name = "speakToolStripMenuItem";
            this.speakToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.speakToolStripMenuItem.Text = "Speak";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ONeilloGameV3.Properties.Resources.playerturn;
            this.pictureBox1.Location = new System.Drawing.Point(149, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 65);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 690);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.informationPanelMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.informationPanelMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ONeillo V3";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.informationPanelMenuStrip.ResumeLayout(false);
            this.informationPanelMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem informationPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakToolStripMenuItem;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

