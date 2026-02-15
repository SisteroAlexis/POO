using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerospasos
{
    public partial class Form1 : Form
    {
        //declaro una variable para la clase
        private int cont = 0;  //antes usaba el static. pero no siempre es necesario
                               //como en este caso
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cont++; 
            //lblEsperando.Text= cont.ToString();

           string saludar = txtNombre.Text;
            MessageBox.Show("Hola " +  saludar);
        }

        private void lblEsperando_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int uno = Convert.ToInt32(txt1.Text);
            int dos = Convert.ToInt32(txt2.Text);

            int c = uno + dos;
            if (c > 100) 
            {
                lblResultado.BackColor = Color.Red;
                lblResultado.Text = ("¡Alerta! El total es: " + c.ToString());
            }else
             {
                lblResultado.BackColor = Color.Green;
                lblResultado.Text = ("Total: " + c.ToString());
             }



                txt1.Clear(); // Limpia el txt 1 
            txt2.Clear(); // Limpia el  txt 2
            txt1.Focus(); // Cambia el focus a txt1
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //esto se gen de forma auto
        {
            if (chbBlack.Checked)
            {
                this.BackColor = Color.Black; //usar this para el formulario

            }else
            {
                this.BackColor = Color.White;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt3.Text);
            int b = Convert.ToInt32(txt4.Text);
            int suma = a + b;
            label1.Text = suma.ToString();

            if (suma > 100) label1.BackColor = Color.Red;
            else label1.BackColor = Color.Green; 



            lb1.Items.Add(txt3.Text + " + "+ txt4.Text + " = " + suma );
            txt3.Clear();
            txt4.Clear();
            txt3.Focus();
        }
    }
}
