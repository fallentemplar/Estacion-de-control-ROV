using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using Microsoft.VisualBasic;

namespace EstacionControl.Ventanas
{
    public partial class MisionCanon : Form
    {
        private double proporcion;
        private const int NUMERODECIMALES = 3;
        private Image imagenProcesamiento;
        private double distancia;
        double[] longitudes;

        public MisionCanon()
        {   
            InitializeComponent();
            imagen_procesamiento.Image = imagenProcesamiento;
            longitudes = new double[4]; //D1,D2,D3,L1
        }

        private void MisionCanon_Load(object sender, EventArgs e)
        {
            imagenProcesamiento = AbrirImagen();
            FiltrarImagen();
        }

        private Image FiltroEscalaGrises()
        {
            Image imagenOriginal = imagenProcesamiento;
            Bitmap imagenNueva = new Bitmap(imagenOriginal.Width, imagenOriginal.Height);
            Graphics grafico = Graphics.FromImage(imagenNueva);
            grafico.DrawImage(imagenOriginal, 0, 0);
            imagen_procesamiento.Image = imagenNueva;
            Grayscale filtro = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap imagenEscalaGrises = filtro.Apply(imagenNueva);
            imagenProcesamiento.Dispose();
            return imagenEscalaGrises;
        }

        private Image FiltroSobel(Image imagen)
        {
            Bitmap img = AForge.Imaging.Image.Clone((Bitmap)imagen, PixelFormat.Format8bppIndexed);
            AForge.Imaging.Image.SetGrayscalePalette(img);
            SobelEdgeDetector detector = new SobelEdgeDetector();
            detector.ApplyInPlace(img);
            return img;
        }

        private Image FiltroContornos(Image imagen)
        {            
            Edges filtro = new Edges();   
            filtro.ApplyInPlace((Bitmap)imagen);
            return imagen;
        }

        int nClick = 0;
        Point punto1;
        Point punto2;
        private void ObtenerCoordenadasMouse(object sender, MouseEventArgs e)
        {
            nClick++;
            if (nClick == 1)
                punto1 = e.Location;
            else if (nClick == 2)
            {
                punto2 = e.Location;
                punto2.Y = punto1.Y;
                Bitmap fondo = AForge.Imaging.Image.Clone((Bitmap)imagen_procesamiento.Image, PixelFormat.Format32bppArgb);
                Graphics grafico = Graphics.FromImage(fondo);

                imagen_procesamiento.Image = fondo;
                Pen pluma = new Pen(Color.Red, 2);
                grafico.DrawLine(pluma, punto1, punto2);

                nClick = 0;
                double pixeles = DistanciaEuclidiana();
                TamanoElemento(pixeles);
                pluma.Dispose();
                grafico.Dispose();
            }
        }

        private double DistanciaEuclidiana()
        {
            double pixeles = Math.Round(Math.Sqrt(Math.Pow(punto2.X - punto1.X, 2) + Math.Pow(punto2.Y - punto1.Y, 2)), 2);
            //MessageBox.Show("Pixeles: " + pixeles);
            return pixeles;
        }

        private void TamanoElemento(double pixeles)
        {
            MessageBox.Show("Tamaño: " + (pixeles * proporcion)+ " cm");
            campo_longitud.Text = (pixeles * proporcion).ToString();
        }

        private void CalcularProporcion()
        {
            proporcion = 0.0028136 * distancia + 0.0014068;
        }

        private void DistanciaObjetivo()
        {
            distancia = double.Parse(Interaction.InputBox("¿Distancia al objeto?", "Distancia", "13.5"));
            //MessageBox.Show("Distancia: " + distancia + " cm");
        }

        private Image AbrirImagen()
        {
            Image imagen = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Seleccionar foto.";
            openDialog.Filter = "Imágenes (*.png;*.jpg)|*.png;*.jpg";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                imagen = Image.FromFile(file);
            }
            DistanciaObjetivo();
            CalcularProporcion();
            return imagen;
        }

        private void boton_Capturar_Click(object sender, EventArgs e)
        {
            imagen_procesamiento.Image = AbrirImagen();
            imagenProcesamiento = imagen_procesamiento.Image;
            FiltrarImagen();           
        }

        private void FiltrarImagen()
        {
            Image imagen = FiltroEscalaGrises();
            imagen = FiltroContornos(imagen);
            imagen_procesamiento.Image = imagen;
            imagenProcesamiento = imagen;
        }

        private void boton_D1_Click(object sender, EventArgs e)
        {
            longitudes[0] = Math.Round(double.Parse(campo_longitud.Text)/2,NUMERODECIMALES);
        }

        private void boton_D2_Click(object sender, EventArgs e)
        {
            longitudes[1] = Math.Round(double.Parse(campo_longitud.Text)/2, NUMERODECIMALES);
        }

        private void boton_D3_Click(object sender, EventArgs e)
        {
            longitudes[2] = Math.Round(double.Parse(campo_longitud.Text)/2, NUMERODECIMALES);
        }

        private void boton_L1_Click(object sender, EventArgs e)
        {
            longitudes[3] = Math.Round(double.Parse(campo_longitud.Text),2);
        }

        private void boton_longitudes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Radio mayor: " + longitudes[0] + "cm\nRadio menor: " + longitudes[1] + "cm\nRadio interno: " + longitudes[2] + "cm\nLongitud:    " + longitudes[3]+"cm");
        }

        private void boton_calcular_volumen_Click(object sender, EventArgs e)
        {
            double volumen = (1 / (double)3) * longitudes[3] * Math.PI * (Math.Pow(longitudes[0], 2) + Math.Pow(longitudes[1], 2)+longitudes[0]*longitudes[1]);
            volumen -= Math.PI * Math.Pow(longitudes[2],2)*longitudes[3];
            MessageBox.Show("Vol: " + Math.Round(volumen,NUMERODECIMALES)+ "cm^3");
        }
    }
}