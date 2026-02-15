using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uno
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau.. chau...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento click");
            //this.BackColor = Color.Blue;
            if (txt1.Text == "") { txt1.BackColor = Color.Red; }
            else { txt1.BackColor = System.Drawing.SystemColors.Control; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Principal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio", "Arencion");
            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //    MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            //else if (click.Button == MouseButtons.Right)
            //    MessageBox.Show("Presiono el Botón Derecho", "Atención");
            //else
            //if (click.Button == MouseButtons.Middle)
            //    MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Cyan;
            lblNombre.Cursor =  Cursors.Hand;
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = System.Drawing.SystemColors.Control;
            lblNombre.Cursor = Cursors.Arrow;
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txt2.Text.Length + " Caracteres");
        }
    }
}
