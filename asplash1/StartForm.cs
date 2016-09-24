using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asplash1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = (MessageLabel.Text == "Hello") ? "Good Bye!" : "Hello";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            NextForm nextForm = new NextForm();
            // save a reference to the current form in a property of the nextForm
            nextForm.previousForm = this;

            // show the next form
            nextForm.Show();

            // hide this one
            this.Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
