using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstacionControl.Dispositivos;

namespace EstacionControl.Ventanas
{
    public partial class VisorCamara : Form
    {
        bool recibiendo_video;

        public VisorCamara()
        {
            InitializeComponent();
            recibiendo_video = false;
        }

        private void VisorCamara_Load(object sender, EventArgs e)
        {
            this.Icon = EstacionControl.Properties.Resources.icono_tmmx_nuevo;
            foreach (var camara in Camaras.listaCamaras)
            {
                lista_camaras1.Items.Add(camara.Value);
            }
            lista_camaras1.SelectedIndex = 2;
        }

        private void ActualizarIPs(object sender, EventArgs e)
        {
            lista_camaras1.Items.Clear();
            foreach (var camara in Camaras.listaCamaras)
            {
                lista_camaras1.Items.Add(camara.Value);
            }
            lista_camaras1.SelectedIndex = 0;
        }

        private void camara1_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                Thread obtenerStreamVideo = new Thread(new ThreadStart(Recibir_stream_video));
                camara1_desconectar.Enabled = true;
                camara1_conectar.Enabled = false;

                obtenerStreamVideo.IsBackground = true;
                obtenerStreamVideo.Start();
                recibiendo_video = true;
                boton_fotografia1.Enabled = true;
                boton_video1.Enabled = true;
            }
            catch (Exception)
            {
                recibiendo_video = false;
            }
        }

        delegate void delegado_video(string url);

        private void Recibir_stream_video()
        {
            //string URL_video = "http://" + direccion_ip_texto.Text +":"+ puerto_texto.Text;
            string URL_video = "http://" + lista_camaras1.SelectedItem;
            visorCamara1.Invoke(new delegado_video(MostrarVideo1), URL_video);
        }

        private void MostrarVideo1(string URL_video)
        {
            visorCamara1.StartPlay(new Uri(URL_video)); //TODO: configurar TCP o UDP
        }

        private void camara1_desconectar_Click(object sender, EventArgs e)
        {
            recibiendo_video = false;
        }

        private void boton_fotografia1_Click(object sender, EventArgs e)
        {
            Bitmap foto = Camaras.CapturarImagen(visorCamara1);
            Camaras.GuardarFotografia(foto);
        }
    }
}