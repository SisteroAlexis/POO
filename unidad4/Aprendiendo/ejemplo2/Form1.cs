using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
            listView1.Items.Add("Nacio el " + dateTimePicker1.Value);
            if (checkBox1.Checked == true) listView1.Items.Add("Le gusta el chocolate");
            else listView1.Items.Add("No le gusta el chocolate");
            listView1.Items.Add("Y");
            if (radioButton1.Checked == true) listView1.Items.Add("Es un mago");
            if (radioButton2.Checked == true) listView1.Items.Add("Es un Mougle");
            if (radioButton3.Checked == true) listView1.Items.Add("Es un Squibs");
            if (comboBox1.Text == "Rojo") listView1.ForeColor = Color.Red;
            if (comboBox1.Text == "Verde") listView1.ForeColor = Color.Green;
            if (comboBox1.Text == "Negro") listView1.ForeColor = Color.Black;
            string valor = Convert.ToString(numericUpDown1.Value);
            listView1.Items.Add(valor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Negro");
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            DateTime fecha = dateTimePicker1.Value.ToUniversalTime();
            //operador ternario //es como un if en una sola linea.
            string chocolate = checkBox1.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo = " Pez gay";
            if (radioButton1.Checked == true) tipo = "Es un mago";
            if (radioButton2.Checked == true) tipo = "Es un Mougle";
            if (radioButton3.Checked == true) tipo = "Es un Squibs";
            //maxi lo creo de esta forma y quedo bie, pero ami me da error de referencia a objeto.
            //string color = comboBox1.SelectedItem.ToString();
            string color = comboBox1.Text;
            string numero = numericUpDown1.Value.ToString();
            MessageBox.Show(nombre + "\n" + fecha + "\n" + chocolate + "\n" + tipo + "\n" + color + "\n" + numero);
        }
    }
}
