using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //practica de validacion fuerte.
            string nombre, apellido, direccion, edad;
            nombre = txt2.Text;
            apellido = txt1.Text;
            direccion = txt4.Text;
            edad = txt3.Text;

            bool val1 = false, val2 = false, val3= false, val4= false; 
            if (nombre == "") txt2.BackColor = Color.Red;
            else val1 = true;
            if (apellido == "") txt1.BackColor = Color.Red;
            else val2 = true;
            if (direccion == "") txt4.BackColor = Color.Red;
            else val3 = true;
            if (edad == "") txt3.BackColor = Color.Red;
            else val4 = true;



            if (val1 && val2 && val3 && val4)
            {
                lb1.Items.Add(nombre + " " + apellido);
                lb1.Items.Add(edad);
                lb1.Items.Add(direccion);


            }

        }

        static bool validarint(string edad)
        {
            int aux;
            if (int.TryParse(edad, out aux))
            {
                if (aux >= 0 && aux <= 120)
                    return true;
            }
            return false;

        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <48 || e.KeyChar >59) && e.KeyChar != 8) e.Handled = true;
        }
    }
}
