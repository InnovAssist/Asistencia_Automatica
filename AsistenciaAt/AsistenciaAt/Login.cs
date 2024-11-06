using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaAt
{
    public partial class Login : Form
    {


        private const string usuarioCorrecto = "Admin";
        private const string passwordCorrecta = "12345";
        public Login()
        {
            InitializeComponent();
            this.Text = ("Cristiano Lemardo");
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
            this.Size = new System.Drawing.Size(800, 500); // Establecer tamaño (ancho x alto)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;  // Deshabilitar botón maximizar


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string password = textBox2.Text;

            if (usuario == usuarioCorrecto && password == passwordCorrecta)
            {
                MessageBox.Show("¡Login exitoso!");
                Inicio ventanaPrincipal = new Inicio();
                ventanaPrincipal.Show();

            }
            else
            {

                MessageBox.Show("Usuario o contraseña incorrectos");


            }
        }
    }
}
