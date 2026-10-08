using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toutrial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showback_Click(object sender, EventArgs e)
        {
            cardBack.Visible = true;
            cardFace.Visible = false;
        }

        private void showface_Click(object sender, EventArgs e)
        {
            cardBack.Visible = false;
            cardFace.Visible = true; 
        }
    }
}
