using System;

using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        #region Presentación
        private int numImagen = 1;

        private void CargarImgSig()
        {
            if (numImagen > 3)
            {
                numImagen = 1;
            }
            ImgPresentacion.ImageLocation = String.Format(@"Imagenes\{0}.jpg", numImagen);
            numImagen++;
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Necesitas iniciar sesión o registrarte");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarImgSig();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form muestra = new Muestra_productos();
            muestra.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form usuarioinicio = new Usuarioinicio();
            usuarioinicio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Registro = new Registro();
            Registro.Show();
            this.Hide();
        }
    }
}
