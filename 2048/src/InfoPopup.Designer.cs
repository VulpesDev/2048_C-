namespace _2048
{
    partial class InfoPopup
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this._title = new System.Windows.Forms.Label();
            this.panelAction = new System.Windows.Forms.Panel();
            this._buttonAction = new System.Windows.Forms.Button();
            this.panelDescription = new System.Windows.Forms.Panel();
            this._description = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.panelTitle.Controls.Add(this._title);
            this.panelTitle.Location = new System.Drawing.Point(-1, -3);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(584, 81);
            this.panelTitle.TabIndex = 7;
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.BackColor = System.Drawing.Color.Transparent;
            this._title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._title.Location = new System.Drawing.Point(24, 27);
            this._title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(47, 18);
            this._title.TabIndex = 3;
            this._title.Text = "TITLE";
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.panelAction.Controls.Add(this._buttonAction);
            this.panelAction.Location = new System.Drawing.Point(-1, 181);
            this.panelAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(584, 90);
            this.panelAction.TabIndex = 6;
            // 
            // _buttonAction
            // 
            this._buttonAction.Location = new System.Drawing.Point(447, 18);
            this._buttonAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._buttonAction.Name = "_buttonAction";
            this._buttonAction.Size = new System.Drawing.Size(125, 50);
            this._buttonAction.TabIndex = 2;
            this._buttonAction.Text = "ok";
            this._buttonAction.UseVisualStyleBackColor = true;
            this._buttonAction.Click += new System.EventHandler(this._buttonAction_Click);
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.panelDescription.Controls.Add(this._description);
            this.panelDescription.Location = new System.Drawing.Point(-1, 85);
            this.panelDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(584, 90);
            this.panelDescription.TabIndex = 5;
            // 
            // _description
            // 
            this._description.AutoSize = true;
            this._description.BackColor = System.Drawing.Color.Transparent;
            this._description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._description.Location = new System.Drawing.Point(239, 32);
            this._description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(109, 18);
            this._description.TabIndex = 2;
            this._description.Text = "DESCRIPTION";
            this._description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "InfoPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPopup";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Label _description;
        private System.Windows.Forms.Button _buttonAction;
    }
}