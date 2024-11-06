using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia_Automatica
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
            this.Text = ("Musialaaaaaaa");
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
            this.Size = new System.Drawing.Size(900, 500); // Establecer tamaño (ancho x alto)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;  // Deshabilitar botón maximizar
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Masculino");
            comboBox1.Items.Add("Femenino");
            comboBox1.Items.Add("Otro");
        }

        //Boton de Alta
        private void button1_Click(object sender, EventArgs e)
        {
            alta.BackColor = Color.SteelBlue;
            baja.BackColor = Color.White;
            modificacion.BackColor = Color.White;
            panelalta.Visible = true;
            panelModificacion.Visible = false;

        }

        //Boton de Baja
        private void button2_Click(object sender, EventArgs e)
        {
            baja.BackColor = Color.SteelBlue;
            modificacion.BackColor = Color.White;
            alta.BackColor = Color.White;


            panelalta.Visible = false;
            panelBaja.Visible = true;
            panelModificacion.Visible = false;
            



        }
        //Panel de Alta
        private void panelalta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        //Panel de Baja
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Este es el panel de Modificación 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Boton Modificación
        private void modificacion_Click(object sender, EventArgs e)
        {
            modificacion.BackColor = Color.SteelBlue;
            alta.BackColor = Color.White;
            baja.BackColor = Color.White;
            panelModificacion.Visible = true;
            panelBaja.Visible = false;
            panelalta.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
