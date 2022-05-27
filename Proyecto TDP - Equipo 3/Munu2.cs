using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Munu2 : Form
    {
        public Munu2()
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

        private void button2_Click(object sender, EventArgs e)
        {
           Indice form1 = new Indice();
            form1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarImgSig();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form muestra = new Muestra_productos();
            muestra.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form muestra = new Form11();
            muestra.Show();
            this.Close();
        }
    }
}
