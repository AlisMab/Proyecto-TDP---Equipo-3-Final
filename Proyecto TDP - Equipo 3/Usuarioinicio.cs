using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Usuarioinicio : Form
    {
        public Usuarioinicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ACCEDER_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtusuario.Text;
            pass = txtcontraseña.Text; 
            if (user == "Tienda" && pass == "1234") 
            {
                MessageBox.Show("Bienvenido");
                Munu2 opcion1 = new Munu2();
                opcion1.Show();
                this.Hide();
            }
          
            else 
            {
                MessageBox.Show("Error en contraseña");
                txtusuario.Text = "";
                txtcontraseña.Text = "";
            }
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            Form form11 = new Form11();
            form11.Show();
            this.Close();
        }
    }
}
