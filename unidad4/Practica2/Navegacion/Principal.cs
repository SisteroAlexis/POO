using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();

            if (textBox1.Text == "1234")
            {
                ventana.Show();
                this.Hide();
            }
            else MessageBox.Show("Clave incorrecta");
             //this.Hide(); this.Hide(); this.Hide(); this.Hide(); this.Hide() this.Hide(); this.Hide();



            //ventana.ShowDialog();
            // Application.Exit(); Application.Exit(); Application.Exit(); Application.Exit(); Aplication.Exit();
        }
    }
}
