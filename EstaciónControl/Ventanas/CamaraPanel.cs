using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstacionControl.Dispositivos;

namespace EstacionControl.Ventanas
{
    public partial class CamaraPanel : Form
    {
        TextBox[] camposPuertos;
        TextBox[] camposCamaras;

        public CamaraPanel()
        {
            InitializeComponent();
            camposCamaras = new TextBox[3];
            camposPuertos = new TextBox[3];

            camposCamaras[0] = campo_ipCamara1;
            camposCamaras[1] = campo_ipCamara2;
            camposCamaras[2] = campo_ipCamara3;

            camposPuertos[0] = campo_puertoCamara1;
            camposPuertos[1] = campo_puertoCamara2;
            camposPuertos[2] = campo_puertoCamara3;

            for (int i = 0; i < 3; i++)
            {
                camposCamaras[i].Text = Camaras.listaCamaras[i+1].Split(':')[0];
                camposPuertos[i].Text = Camaras.listaCamaras[i+1].Split(':')[1];
            }
        }

        private void boton_actualizarCamaras_Click(object sender, EventArgs e)
        {
            if (!PantallaEstacion.recibiendo_video1)
            {
                SortedList<int, string> camarasTemporal = new SortedList<int, string>();
                int cantidadCamarasCorrectas = 0;
                
                for(int i=0;i<camposCamaras.Length;i++)
                {
                    if(AgregarRegistro(camposCamaras[i].Text+":"+camposPuertos[i].Text,camarasTemporal))
                    {
                        camarasTemporal.Add((i+1), camposCamaras[i].Text + ":" + camposPuertos[i].Text);
                        cantidadCamarasCorrectas++;
                    }
                }
                if (cantidadCamarasCorrectas != 3)
                    MessageBox.Show("Las cámaras configuradas están repetidas");
                else{
                    Camaras.listaCamaras.Clear();
                    Camaras.listaCamaras = camarasTemporal;
                    MessageBox.Show("Los cambios han sido guardados con éxito");
                    this.Close();
                }
            }
            else
                MessageBox.Show("No se pueden modificar las direcciones IP de las cámaras.\nmientras se recibe video");
        }

        /// <summary>
        /// Comprueba si la dirección IP puede ser agregada a la lista.
        /// </summary>
        /// <param name="direccionIP"></param>
        /// <param name="listaCamaras"></param>
        /// <returns></returns>
        private bool AgregarRegistro(string direccionIP, SortedList<int, string> listaCamaras)
        {
            return (ComprobarValidezIP(direccionIP) && !listaCamaras.ContainsValue(direccionIP));
        }

        /// <summary>
        /// Comprueba si el string introducido en el cuadro de texto es una IP válida
        /// </summary>
        /// <param name="direccionIP">Dirección IP a verificar</param>
        /// <returns></returns>
        private bool ComprobarValidezIP(string direccionIP)
        {
            string[] octetos = direccionIP.Split('.');
            if (octetos.Length == 4)
            {
                bool direccionIPValida = false;
                foreach (string octeto in octetos)
                {
                    UInt16.TryParse(octeto, out UInt16 minimo);
                    UInt16.TryParse(octeto, out UInt16 maximo);
                    if (minimo >= 0 && maximo <= 255)
                        direccionIPValida = true;
                    else
                    {
                        MessageBox.Show("Introduzca una IP válida en el cuadro de texto");
                        return false;
                    }
                }
                return direccionIPValida;
            }
            MessageBox.Show("Introduzca una IP válida en el cuadro de texto");
            return false;
        }
    }
}