using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;


namespace EstacionControl.Ventanas
{
    public partial class MisionCanon : Form
    {
        private readonly double PROPORCION;

        private Image imagenProcesamiento;

        public MisionCanon(double distancia)
        {
            
            InitializeComponent();
            PROPORCION = CalcularProporcion(distancia);
            imagenProcesamiento = Image.FromFile(@"E:\final.jpg");
            imagen_procesamiento.Image = imagenProcesamiento;
        }

        private void MisionCanon_Load(object sender, EventArgs e)
        {
            Image imagen = FiltroEscalaGrises();
            imagen = FiltroContornos(imagen);
            imagen_procesamiento.Image = imagen;
        }

        private Image FiltroEscalaGrises()
        {
            Image imagenOriginal = imagenProcesamiento;//Image.FromFile(@"E:\final.jpg", false);
            //bm = new Bitmap(bm, 360, 240);
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
            MessageBox.Show("Tamaño: " + (pixeles * PROPORCION)+ " cm");
        }

        private double CalcularProporcion(double distancia)
        {
            return 0.0028136 * distancia + 0.0014068;
        }
    }
}