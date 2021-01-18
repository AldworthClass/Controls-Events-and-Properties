using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls__Events_and_Properties
{
    public partial class FormMain : Form
    {
        Random generator = new Random();  // Used to make random numbers

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = true;
            lblStatus.Text = "Status: Clicked";
            btnQuit.Enabled = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblInstructions_MouseEnter(object sender, EventArgs e)
        {
            lblInstructions.ForeColor = Color.Red;
        }

        private void lblInstructions_MouseLeave(object sender, EventArgs e)
        {
            lblInstructions.ForeColor = Color.Black;
        }

        private void imgCharacter_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = false;
        }

        private void btnMakeFormBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            int max = 257; // 256 is the maximum value an RGB value can be
            int r = generator.Next(max);
            int g = generator.Next(max);
            int b = generator.Next(max);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
