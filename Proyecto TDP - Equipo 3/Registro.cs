using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void ACCEDER_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por tu registro, se le enviará el usuario y contraseña a su correo");
            Form form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show();
            this.Close();
        }
    }
}
