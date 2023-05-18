using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerenNas
{
    public partial class Kare : Form
    {
        public Kare()
        {
            InitializeComponent();
        }

        private void Kare_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSolition_Click(object sender, EventArgs e)
        {
            int a;
            int around;
            a = Convert.ToInt32(tBEdge.Text);
            around = a * 4;
            lblResult.Text = around.ToString();
        }
    }
}
