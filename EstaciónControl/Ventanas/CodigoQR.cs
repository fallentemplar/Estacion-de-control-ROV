using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace EstacionControl
{
    public partial class CodigoQR : Form
    {
        QRCodeGenerator generadorQR;
        QRCodeData datosQR;
        QRCode codigoQR;
        Bitmap imagenQR;

        string direccionIP;


        public CodigoQR(string direccionIP)
        {
            InitializeComponent();
            this.direccionIP = direccionIP;
            generadorQR = new QRCodeGenerator();
            datosQR = generadorQR.CreateQrCode("http://"+direccionIP + "/", QRCodeGenerator.ECCLevel.Q);
            codigoQR = new QRCode(datosQR);
            imagenQR = codigoQR.GetGraphic(20);
        }

        private void CodigoQR_Load(object sender, EventArgs e)
        {
            cuadro_QR.Image = imagenQR;
        }
    }
}