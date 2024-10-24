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
    }
}
