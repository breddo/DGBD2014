using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PruebasVisuales
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pregunta = "Está seguro qu edesea salir del sistema";
            string titulo = "Gestión de base de datos";
            DialogResult respuesta = MessageBox.Show(pregunta, titulo , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {    
                this.Close();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Sistema realizado por Pablo Matías Aimar\n";
            mensaje += "Diseño y Gestión de Base de Datos\n";
            mensaje += "Año 2014\n";
            mensaje += "Instituto de Profesorado N° 20";
            string titulo = "Gestión SmoothSofts";
            MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
