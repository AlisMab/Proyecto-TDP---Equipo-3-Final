﻿using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Mujer2 : Form
    {
        public Mujer2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form form11 = new Munu2();
            form11.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fomr = new Indice();
            fomr.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form muestra = new Muestra_productos();
            muestra.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Se agregó";
            Muestra_productos p1=new Muestra_productos();

            p1.txtbp1.Text = textBox1.Text;

            p1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Se agregó";
            Muestra_productos p2 = new Muestra_productos();

            p2.txtbp2.Text = textBox2.Text;

            p2.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Se agregó";
            Muestra_productos p3 = new Muestra_productos();

            p3.txtbp3.Text = textBox3.Text;

            p3.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Se agregó";
            Muestra_productos p4 = new Muestra_productos();

            p4.txtbp4.Text = textBox4.Text;

            p4.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Se agregó";
            Muestra_productos p1 = new Muestra_productos();

            p1.txtbp5.Text = textBox5.Text;

            p1.Show();
            this.Close();
        }
    }
}
