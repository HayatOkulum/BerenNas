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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

     


        private void calculate_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int around;
            a = Convert.ToInt32(answerA.Text);
            b = Convert.ToInt32(answerB.Text);
            around = (a * 2) + (b * 2);

            lblResult.Text = around.ToString();
        }
    }
}
