using System;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3

{
    public partial class Muestra_productos : Form
    {

        private float suma;
        public Muestra_productos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form1 = new Indice();
            Form1.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form11 = new Munu2();
            form11.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form muestra = new Form11();
            muestra.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (suma <= 0)
            {
                float Op1 = float.Parse(txtbp1.Text);
                float Op2 = float.Parse(txtbp2.Text);
                float Op3 = float.Parse(txtbp3.Text);
                float Op4 = float.Parse(txtbp4.Text);
                float Op5 = float.Parse(txtbp5.Text);
                float Op6 = float.Parse(txtbp6.Text);
                suma = Op1 + Op2 + Op3 + Op4 + Op5 + Op6;
                total.Text = suma.ToString();
            }

            else
            {
                Form form11 = new Munu2();
                form11.Show();
                this.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbp1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbp2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbp3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbp4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbp5.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtbp6.Clear();
        }
    }
}
