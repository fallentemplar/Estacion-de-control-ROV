using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebEye.Controls.WinForms.StreamPlayerControl;

namespace EstacionControl.Dispositivos
{
    static class Camaras
    {
        public static SortedList<int, string> listaCamaras { get; set; }
        private static readonly string rutaCapturas = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\EstacionControl\\Capturas\\";


        public static void InicializarCamaras()
        {
            listaCamaras = new SortedList<int, string>();
        }

        public static void AgregarCamarasIniciales()
        {
            listaCamaras.Add(1, "192.168.0.7:9000");
            listaCamaras.Add(2, "192.168.0.7:9001");
            listaCamaras.Add(3, "192.168.0.9:9000");
        }

        public static void GuardarFotografia(Bitmap foto)
        {
            DateTime Hoy = DateTime.Now;
            string fecha_actual = Hoy.ToString("dd-MM-yyyy HH-mm-ss");
            if (!Directory.Exists(rutaCapturas))
                Directory.CreateDirectory(rutaCapturas);
            if (foto != null)
                foto.Save(rutaCapturas + "\\imagen_" + fecha_actual + ".png", ImageFormat.Png);
        }

        public static Bitmap CapturarImagen(StreamPlayerControl visorCamara)
        {
            try
            {
                if(visorCamara.IsPlaying)
                    return visorCamara.GetCurrentFrame();
                else
                {
                    MessageBox.Show("No se puede capturar la fotografía.\nActualmente no se está recibiendo video",
                        "No fue posible capturar la fotografía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (ThreadInterruptedException)
            {
                throw;
            }
        }
    }
}
