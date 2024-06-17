namespace _2048.src
{
    partial class FormMenu
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonHScore = new System.Windows.Forms.Button();
            this.buttonWHScore = new System.Windows.Forms.Button();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.panelWorldLeaderboard = new System.Windows.Forms.Panel();
            this.worldLeaderboardMenu1 = new _2048.src.WorldLeaderboardMenu();
            this.panelWorldLeaderboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(194, 108);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(292, 80);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHScore
            // 
            this.buttonHScore.AutoSize = true;
            this.buttonHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHScore.Location = new System.Drawing.Point(194, 255);
            this.buttonHScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHScore.Name = "buttonHScore";
            this.buttonHScore.Size = new System.Drawing.Size(292, 80);
            this.buttonHScore.TabIndex = 1;
            this.buttonHScore.Text = "Local Leaderboard";
            this.buttonHScore.UseVisualStyleBackColor = true;
            this.buttonHScore.Click += new System.EventHandler(this.buttonHScore_Click);
            // 
            // buttonWHScore
            // 
            this.buttonWHScore.AutoSize = true;
            this.buttonWHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWHScore.Location = new System.Drawing.Point(194, 406);
            this.buttonWHScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonWHScore.Name = "buttonWHScore";
            this.buttonWHScore.Size = new System.Drawing.Size(292, 80);
            this.buttonWHScore.TabIndex = 2;
            this.buttonWHScore.Text = "World Leaderboard";
            this.buttonWHScore.UseVisualStyleBackColor = true;
            this.buttonWHScore.Click += new System.EventHandler(this.buttonWHScore_Click);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // panelWorldLeaderboard
            // 
            this.panelWorldLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorldLeaderboard.AutoSize = true;
            this.panelWorldLeaderboard.Controls.Add(this.worldLeaderboardMenu1);
            this.panelWorldLeaderboard.Enabled = false;
            this.panelWorldLeaderboard.Location = new System.Drawing.Point(572, 520);
            this.panelWorldLeaderboard.Name = "panelWorldLeaderboard";
            this.panelWorldLeaderboard.Size = new System.Drawing.Size(685, 649);
            this.panelWorldLeaderboard.TabIndex = 3;
            this.panelWorldLeaderboard.Visible = false;
            // 
            // worldLeaderboardMenu1
            // 
            this.worldLeaderboardMenu1.Location = new System.Drawing.Point(103, 81);
            this.worldLeaderboardMenu1.Name = "worldLeaderboardMenu1";
            this.worldLeaderboardMenu1.Size = new System.Drawing.Size(477, 403);
            this.worldLeaderboardMenu1.TabIndex = 0;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(681, 647);
            this.Controls.Add(this.panelWorldLeaderboard);
            this.Controls.Add(this.buttonWHScore);
            this.Controls.Add(this.buttonHScore);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelWorldLeaderboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonHScore;
        private System.Windows.Forms.Button buttonWHScore;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Panel panelWorldLeaderboard;
        private WorldLeaderboardMenu worldLeaderboardMenu1;
    }
}