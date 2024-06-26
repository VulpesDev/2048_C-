﻿using System.Windows.Forms;

namespace _2048.src
{
    partial class FormGame
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tile15 = new System.Windows.Forms.Label();
            this.tile14 = new System.Windows.Forms.Label();
            this.tile13 = new System.Windows.Forms.Label();
            this.tile12 = new System.Windows.Forms.Label();
            this.tile11 = new System.Windows.Forms.Label();
            this.tile10 = new System.Windows.Forms.Label();
            this.tile9 = new System.Windows.Forms.Label();
            this.tile8 = new System.Windows.Forms.Label();
            this.tile7 = new System.Windows.Forms.Label();
            this.tile6 = new System.Windows.Forms.Label();
            this.tile5 = new System.Windows.Forms.Label();
            this.tile4 = new System.Windows.Forms.Label();
            this.tile3 = new System.Windows.Forms.Label();
            this.tile2 = new System.Windows.Forms.Label();
            this.tile1 = new System.Windows.Forms.Label();
            this.tile0 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.scoreBestValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tile15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tile14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tile13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tile12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tile11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tile7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tile6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tile5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tile4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tile2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tile0, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(106, 149);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(292, 288);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tile15
            // 
            this.tile15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile15.AutoSize = true;
            this.tile15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile15.Location = new System.Drawing.Point(360, 357);
            this.tile15.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile15.Name = "tile15";
            this.tile15.Size = new System.Drawing.Size(92, 91);
            this.tile15.TabIndex = 15;
            this.tile15.Text = "0";
            this.tile15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile14
            // 
            this.tile14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile14.AutoSize = true;
            this.tile14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile14.Location = new System.Drawing.Point(244, 357);
            this.tile14.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile14.Name = "tile14";
            this.tile14.Size = new System.Drawing.Size(92, 91);
            this.tile14.TabIndex = 14;
            this.tile14.Text = "0";
            this.tile14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile13
            // 
            this.tile13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile13.AutoSize = true;
            this.tile13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile13.Location = new System.Drawing.Point(128, 357);
            this.tile13.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile13.Name = "tile13";
            this.tile13.Size = new System.Drawing.Size(92, 91);
            this.tile13.TabIndex = 13;
            this.tile13.Text = "0";
            this.tile13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile12
            // 
            this.tile12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile12.AutoSize = true;
            this.tile12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile12.Location = new System.Drawing.Point(12, 357);
            this.tile12.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile12.Name = "tile12";
            this.tile12.Size = new System.Drawing.Size(92, 91);
            this.tile12.TabIndex = 12;
            this.tile12.Text = "0";
            this.tile12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile11
            // 
            this.tile11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile11.AutoSize = true;
            this.tile11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile11.Location = new System.Drawing.Point(360, 242);
            this.tile11.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile11.Name = "tile11";
            this.tile11.Size = new System.Drawing.Size(92, 91);
            this.tile11.TabIndex = 11;
            this.tile11.Text = "0";
            this.tile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile10
            // 
            this.tile10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile10.AutoSize = true;
            this.tile10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile10.Location = new System.Drawing.Point(244, 242);
            this.tile10.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile10.Name = "tile10";
            this.tile10.Size = new System.Drawing.Size(92, 91);
            this.tile10.TabIndex = 10;
            this.tile10.Text = "0";
            this.tile10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile9
            // 
            this.tile9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile9.AutoSize = true;
            this.tile9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile9.Location = new System.Drawing.Point(128, 242);
            this.tile9.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(92, 91);
            this.tile9.TabIndex = 9;
            this.tile9.Text = "0";
            this.tile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile8
            // 
            this.tile8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile8.AutoSize = true;
            this.tile8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile8.Location = new System.Drawing.Point(12, 242);
            this.tile8.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(92, 91);
            this.tile8.TabIndex = 8;
            this.tile8.Text = "0";
            this.tile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile7
            // 
            this.tile7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile7.AutoSize = true;
            this.tile7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile7.Location = new System.Drawing.Point(360, 127);
            this.tile7.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(92, 91);
            this.tile7.TabIndex = 7;
            this.tile7.Text = "0";
            this.tile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile6
            // 
            this.tile6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile6.AutoSize = true;
            this.tile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile6.Location = new System.Drawing.Point(244, 127);
            this.tile6.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(92, 91);
            this.tile6.TabIndex = 6;
            this.tile6.Text = "0";
            this.tile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile5
            // 
            this.tile5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile5.AutoSize = true;
            this.tile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile5.Location = new System.Drawing.Point(128, 127);
            this.tile5.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(92, 91);
            this.tile5.TabIndex = 5;
            this.tile5.Text = "0";
            this.tile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile4
            // 
            this.tile4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile4.AutoSize = true;
            this.tile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile4.Location = new System.Drawing.Point(12, 127);
            this.tile4.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(92, 91);
            this.tile4.TabIndex = 4;
            this.tile4.Text = "0";
            this.tile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile3
            // 
            this.tile3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile3.AutoSize = true;
            this.tile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile3.Location = new System.Drawing.Point(360, 12);
            this.tile3.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(92, 91);
            this.tile3.TabIndex = 3;
            this.tile3.Text = "0";
            this.tile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile2
            // 
            this.tile2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile2.AutoSize = true;
            this.tile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile2.Location = new System.Drawing.Point(244, 12);
            this.tile2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(92, 91);
            this.tile2.TabIndex = 2;
            this.tile2.Text = "0";
            this.tile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile1
            // 
            this.tile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile1.AutoSize = true;
            this.tile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile1.Location = new System.Drawing.Point(128, 12);
            this.tile1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(92, 91);
            this.tile1.TabIndex = 1;
            this.tile1.Text = "0";
            this.tile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile0
            // 
            this.tile0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile0.AutoSize = true;
            this.tile0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.tile0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tile0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.tile0.Location = new System.Drawing.Point(12, 12);
            this.tile0.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tile0.Name = "tile0";
            this.tile0.Size = new System.Drawing.Size(92, 91);
            this.tile0.TabIndex = 0;
            this.tile0.Text = "0";
            this.tile0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.scoreLabel.Location = new System.Drawing.Point(106, 2);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(173, 63);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.scoreValueLabel.Location = new System.Drawing.Point(353, 2);
            this.scoreValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(58, 63);
            this.scoreValueLabel.TabIndex = 2;
            this.scoreValueLabel.Text = "0";
            // 
            // scoreBestValueLabel
            // 
            this.scoreBestValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBestValueLabel.AutoSize = true;
            this.scoreBestValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreBestValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.scoreBestValueLabel.Location = new System.Drawing.Point(353, 65);
            this.scoreBestValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreBestValueLabel.Name = "scoreBestValueLabel";
            this.scoreBestValueLabel.Size = new System.Drawing.Size(58, 63);
            this.scoreBestValueLabel.TabIndex = 4;
            this.scoreBestValueLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(106, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Best";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(681, 647);
            this.Controls.Add(this.scoreBestValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.FormGame_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormGame_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tile0;
        private System.Windows.Forms.Label tile15;
        private System.Windows.Forms.Label tile14;
        private System.Windows.Forms.Label tile13;
        private System.Windows.Forms.Label tile12;
        private System.Windows.Forms.Label tile11;
        private System.Windows.Forms.Label tile10;
        private System.Windows.Forms.Label tile9;
        private System.Windows.Forms.Label tile8;
        private System.Windows.Forms.Label tile7;
        private System.Windows.Forms.Label tile6;
        private System.Windows.Forms.Label tile5;
        private System.Windows.Forms.Label tile4;
        private System.Windows.Forms.Label tile3;
        private System.Windows.Forms.Label tile2;
        private System.Windows.Forms.Label tile1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private Label scoreBestValueLabel;
        private Label label2;
    }
}

