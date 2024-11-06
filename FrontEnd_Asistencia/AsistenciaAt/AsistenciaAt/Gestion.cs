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

        }
    }
}
