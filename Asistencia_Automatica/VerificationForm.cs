using DPFP;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace Asistencia_Automatica
{
    public partial class VerificationForm : Form {
    public VerificationForm() {
        InitializeComponent();
        conexion.getConexion();
    }

    public void OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus Status) {
      DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
      DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();


        string tabla = "pruebahuella";
        string consulta = $"SELECT * FROM " + tabla;

        // Compare feature set with particular template.
        using (MySqlCommand comando = new MySqlCommand(consulta, conexion.getConexion()))
        {

            //comando.Parameters.AddWithValue("@Huella1", huella);

            using (MySqlDataReader result = comando.ExecuteReader())
            {
                byte[] fingerprintData;
                        
                while (result.Read())
                {
                    // Console.WriteLine(result.GetByte("Huella1"));
                    // GetBytes(Numero que corresponde a la columna que almacena la huella (Contando a partir del 0),
                    // Ni idea,
                    // cantidad de bytes esperados por fila,
                    // Ni idea,
                    // cantidad de bytes esperados por columna)

                    long length = result.GetBytes(2, 0, null, 0, 0); // Obtener el tama�o del BLOB
                    fingerprintData = new byte[length];
                    result.GetBytes(2, 0, fingerprintData, 0, (int)length); // Leer el BLOB
                    bool comparacion = false;

                    using (MemoryStream memoryStream = new MemoryStream(fingerprintData))
                    {
                        DPFP.Template template = new DPFP.Template(memoryStream);
                        ver.Verify(FeatureSet, template, ref res); // Funcion que compara la huella (creo). �Que es FeatureSet y res?
                        comparacion = res.Verified; // Bool resultante de la funcion ".Verify". Dicta si la huella coincide o no (boeee "dicta
                    }

                    if (comparacion == true) // Si la comparacion de la huella dio que coincide se devuelve el nombre de la persona que puso el dedo
                    {
                        Console.WriteLine(result.GetString("Nombre"));
                        break;
                    }


                }
            }

        }

      // Si la huella que se esta ingresando no coincide con ninguna que este almacenada se envia un mensaje de error
      if (!res.Verified)
        Status = DPFP.Gui.EventHandlerStatus.Failure;

    }

        private Conexion conexion = new Conexion();

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }

        private void VerificationForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}