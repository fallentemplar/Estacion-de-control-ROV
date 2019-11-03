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
    public partial class FigurasIdentificadas : Form
    {
        Bitmap imagen;
        public FigurasIdentificadas(Bitmap img)
        {
            InitializeComponent();
            imagen = img;
        }
    }
}
