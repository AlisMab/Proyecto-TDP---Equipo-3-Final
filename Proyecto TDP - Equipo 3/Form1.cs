using System;

using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form mujer = new Mujer();
            mujer.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form hom = new Hombre();
            hom.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form niñoas = new Niños();
            niñoas.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form muestra = new Tendencias();
            muestra.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form muestra = new reciente();
            muestra.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form masv = new _vendido();
            masv.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form usuarioinicio = new Usuarioinicio();
            usuarioinicio.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Registro = new Registro();
            Registro.Show();
            this.Close();
        }
    }
}
