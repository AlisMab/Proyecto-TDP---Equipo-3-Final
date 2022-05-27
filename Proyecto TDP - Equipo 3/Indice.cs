using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Indice : Form
    {
        public Indice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Munu2 form11 = new Munu2();
            form11.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mujer2 mujer = new Mujer2();
            mujer.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form hom = new Hombre2();
            hom.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form niñoas = new Niños2();
            niñoas.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form masv = new vendido2();
            masv.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form muestra = new reciente2();
            muestra.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form muestra = new Tendencias2();
            muestra.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form muestra = new Form11();
            muestra.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form muestra = new Muestra_productos();
            muestra.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mujer2 mujer = new Mujer2();
            mujer.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form hom = new Hombre2();
            hom.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form niñoas = new Niños2();
            niñoas.Show();
            this.Close();
        }
    }
}
