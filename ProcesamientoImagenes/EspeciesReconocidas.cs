using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionControl.ProcesamientoImagenes
{
    public partial class EspeciesReconocidas : Form
    {
        Bitmap imagen;
        int[] nFiguras;
        public EspeciesReconocidas(Bitmap img, int[] figuras)
        {
            InitializeComponent();
            imagen = img;
            pictureBox1.Image = imagen;
            nFiguras = figuras;
        }

        private void EspeciesReconocidas_Load(object sender, EventArgs e)
        {
            contadorCirculos.Text = "Circulos: " + nFiguras[0];
            contadorCuadrados.Text = "Cuadrados: " + nFiguras[1];
            contadorRectangulos.Text = "Rectángulos: " + nFiguras[2];
            contadorTriangulos.Text = "Triángulos: " + nFiguras[3];
        }
    }
}
