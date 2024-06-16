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
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(166, 94);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(250, 69);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHScore
            // 
            this.buttonHScore.AutoSize = true;
            this.buttonHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHScore.Location = new System.Drawing.Point(166, 221);
            this.buttonHScore.Name = "buttonHScore";
            this.buttonHScore.Size = new System.Drawing.Size(250, 69);
            this.buttonHScore.TabIndex = 1;
            this.buttonHScore.Text = "Local Leaderboard";
            this.buttonHScore.UseVisualStyleBackColor = true;
            // 
            // buttonWHScore
            // 
            this.buttonWHScore.AutoSize = true;
            this.buttonWHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWHScore.Location = new System.Drawing.Point(166, 352);
            this.buttonWHScore.Name = "buttonWHScore";
            this.buttonWHScore.Size = new System.Drawing.Size(250, 69);
            this.buttonWHScore.TabIndex = 2;
            this.buttonWHScore.Text = "World Leaderboard";
            this.buttonWHScore.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.buttonWHScore);
            this.Controls.Add(this.buttonHScore);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonHScore;
        private System.Windows.Forms.Button buttonWHScore;
    }
}