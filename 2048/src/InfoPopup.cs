using System;
using System.Windows.Forms;

namespace _2048
{
    public partial class InfoPopup : Form
    {
        public InfoPopup(string title, string description, string actionText)
        {
            InitializeComponent();
            this.Text = title;
            _title.Text = title;
            _description.Text = description;
            int newx = (panelDescription.ClientSize.Width - _description.Width) / 2;
            int newy = (panelDescription.ClientSize.Height - _description.Height) / 2;
            _description.Location = new System.Drawing.Point(newx, newy);
            _buttonAction.Text = actionText;
        }

        private void _buttonAction_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
