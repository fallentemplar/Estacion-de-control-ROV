using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstacionControl.Dispositivos;

namespace EstacionControl.Ventanas
{
    public partial class CamaraPanel : Form
    {
        public CamaraPanel()
        {
            InitializeComponent();
            campo_ipCamara1.Text = Camaras.listaCamaras[1].Split(':')[0];
            campo_puertoCamara1.Text = Camaras.listaCamaras[1].Split(':')[1];
            campo_ipCamara2.Text = Camaras.listaCamaras[2].Split(':')[0];
            campo_puertoCamara2.Text = Camaras.listaCamaras[2].Split(':')[1];
            campo_ipCamara3.Text = Camaras.listaCamaras[3].Split(':')[0];
            campo_puertoCamara3.Text = Camaras.listaCamaras[3].Split(':')[1];
        }

        private void boton_actualizarCamaras_Click(object sender, EventArgs e)
        {
            if (!PantallaEstacion.recibiendo_video1)
            {
                int camarasCorrectas = 0;
                Camaras.listaCamaras.Clear();
                if (AgregarRegistro(campo_ipCamara1.Text + ":" + campo_puertoCamara1.Text))
                {
                    Camaras.listaCamaras.Add(1, campo_ipCamara1.Text + ":" + campo_puertoCamara1.Text);
                    camarasCorrectas++;
                }
                if (AgregarRegistro(campo_ipCamara2.Text + ":" + campo_puertoCamara2.Text))
                {
                    Camaras.listaCamaras.Add(2, campo_ipCamara2.Text + ":" + campo_puertoCamara2.Text);
                    camarasCorrectas++;
                }
                if (AgregarRegistro(campo_ipCamara3.Text + ":" + campo_puertoCamara3.Text))
                {
                    Camaras.listaCamaras.Add(3, campo_ipCamara3.Text + ":" + campo_puertoCamara3.Text);
                    camarasCorrectas++;
                }
                if (camarasCorrectas != 3)
                    MessageBox.Show("Las cámaras configuradas están repetidas");
                else{
                    MessageBox.Show("Los cambios han sido guardados con éxito");
                    this.Close();
                }
            }
            else
                MessageBox.Show("No se pueden omdificar las direcciones de las cámaras.\nmientras se recibe video");
        }

        private bool AgregarRegistro(string ip)
        {
            if (EsIPValida(ip) && !Camaras.listaCamaras.ContainsValue(ip))
                return true;
            else if (!EsIPValida(ip)){
                MessageBox.Show("Introduzca una IP válida en el cuadro de texto");
                return false;
            }
            return false;
        }
        /// <summary>
        /// EsIPValida: Comprueba mediante una RegExp si lo introducido en el cuadro de texto es una IP válida
        ///
        /// </summary>
        /// <param name="ip">Dirección IP a verificar</param>
        /// <returns></returns>
        private bool EsIPValida(string ip)
        {
            string[] octetos = ip.Split('.');
            if (octetos.Length == 4)
            {
                bool esValida = false;
                foreach (string octeto in octetos)
                {
                    UInt16.TryParse(octeto, out UInt16 minimo);
                    UInt16.TryParse(octeto, out UInt16 maximo);
                    if (minimo > 0 && maximo <= 255)
                        esValida = true;
                    else
                        return false;
                }
                return esValida;
            }
            return false;
        }
    }
}