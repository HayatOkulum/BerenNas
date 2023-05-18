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
    public partial class eskenarucgen : Form
    {
        public eskenarucgen()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int a;
            int cevre;
            a = Convert.ToInt32(tB_a.Text);
            cevre = a * 3;
            sonuc.Text = cevre.ToString();
        }

        private void eskenarucgen_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
