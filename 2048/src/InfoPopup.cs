﻿using System;
using System.Windows.Forms;

namespace _2048
{
    public partial class InfoPopup : Form
    {
        public InfoPopup()
        {
            InitializeComponent();
            _buttonAction.Text = "OK";
        }
        public InfoPopup(string title, bool show)
        {
            InitializeComponent();
            this.Text = title;
            _title.Text = title;
            _buttonAction.Text = "OK";
            if (show)
                this.Show();
        }
        public InfoPopup(string title, string description)
        {
            InitializeComponent();
            this.Text = title;
            _title.Text = title;
            _body.Text = description;
            _buttonAction.Text = "OK";
            this.Show();
        }
        public InfoPopup(string title, string description, bool show)
        {
            InitializeComponent();
            this.Text = title;
            _title.Text = title;
            _body.Text = description;
            _buttonAction.Text = "OK";
            if (show)
                this.Show();
        }
        public InfoPopup(string title, string description, string actionText, bool show)
        {
            InitializeComponent();
            this.Text = title;
            _title.Text = title;
            _body.Text = description;
            _buttonAction.Text = actionText;
            if (show)
                this.Show();
        }

        private void _buttonAction_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _body_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))
                e.Handled = true;
        }
        private void _body_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionLength = 0;
            ((TextBox)sender).SelectionStart  = ((TextBox)sender).Text.Length;
        }

    }
}
