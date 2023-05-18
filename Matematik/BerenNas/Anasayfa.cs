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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eskenarucgen form2 = new eskenarucgen();
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Matematik Alemine Hoşgeldiniz :) ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beklesene alooo daha yazmadık benim on kolum mu var :)");
            Rectangle form4 = new Rectangle();
            this.Visible = false;
            form4.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beklesene kardeşim yükleniyor işte çatlama :)");

            //bu kodda ben başka bir form sayfasına aktarma işlemini yaptım.
            Kare form3 = new Kare();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;


        }

        private void lblWritesLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hadi Biraz Gezelim!");
            if (MessageBox.Show("Kanalıma Gitmek İsterseniz Evete Basınız! :)", "Nereye Gitmek İstersiniz Seçin Bakalım", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                System.Diagnostics.Process.Start("https://www.youtube.com/@nasakademi");


            }
            else
            {
                MessageBox.Show("Hahaha O Zaman Siteme Gitme Zamanı :=)");
                System.Diagnostics.Process.Start("https://berennas.com/istanbul/");

            }
        }
    }
}
