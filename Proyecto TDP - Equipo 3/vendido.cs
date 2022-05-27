using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class _vendido : Form
    {
        public _vendido()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fomr = new Form1();
            fomr.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }
    }
}
