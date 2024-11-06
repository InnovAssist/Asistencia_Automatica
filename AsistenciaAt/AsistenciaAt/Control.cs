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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            this.Text = ("Franz Rojobauer");
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
            this.Size = new System.Drawing.Size(800, 500); // Establecer tamaño (ancho x alto)
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;  // Deshabilitar botón maximizar
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label4_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.SetToolTip(label4, "Ingresar el DNI");
        }
    }
}
