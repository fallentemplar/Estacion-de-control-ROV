using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EstacionControl.Dispositivos.Sensores
{
    partial class Giroscopio : Form
    {
        /*
         * Clase basada en el proyecto ARDrone-Control-.NET 
         * Disponible en https://github.com/shtejv/ARDrone-Control-.NET/blob/master/AviationInstruments/InstrumentControl.cs
         * Liberado bajo la licencia GNU GPL V.3
         */

        ConectividadRemota socket;

        public static Bitmap mybitmap1 = new Bitmap(EstacionControl.Properties.Resources.horizon);
        public static Bitmap mybitmap2 = new Bitmap(EstacionControl.Properties.Resources.bezel);
        public static Bitmap mybitmap3 = new Bitmap(EstacionControl.Properties.Resources.heading);
        public static Bitmap mybitmap4 = new Bitmap(EstacionControl.Properties.Resources.wings);

        public static double PitchAngle = 0;
        public static double RollAngle = 0;
        public static double YawAngle = 0;

        public static Point ptBoule = new Point(-25, -410); //Ground-Sky initial location
        public static Point ptHeading = new Point(-592, 150); // Heading ticks
        public static Point ptRotation = new Point(150, 150); // Point of rotation


        public Giroscopio(ConectividadRemota socket)
        {
            InitializeComponent();
            this.socket = socket;
        }

        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            base.OnPaint(paintEvnt);


            // Clipping mask for Attitude Indicator
            paintEvnt.Graphics.Clip = new Region(new Rectangle(0, 0, 300, 300));
            //paintEvnt.Graphics.FillRegion(Brushes.Black, paintEvnt.Graphics.Clip);


            // Make sure lines are drawn smoothly
            paintEvnt.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            // Create the graphics object
            Graphics gfx = paintEvnt.Graphics;

            // Adjust and draw horizon image
            RotacionTraslacion(paintEvnt, mybitmap1, RollAngle, 0, ptBoule, (double)(4 * PitchAngle), ptRotation, 1);

            RotacionTraslacion2(paintEvnt, mybitmap3, YawAngle, RollAngle, 0, ptHeading, (double)(4 * PitchAngle), ptRotation, 1);

            gfx.DrawImage(mybitmap2, 0, 250-250); // Draw bezel image
            gfx.DrawImage(mybitmap4, 75, 375); // Draw wings image
        }

        public void PintarGiroscopio()
        {
            PitchAngle = (double)socket.AnguloY;
            RollAngle = (double)socket.AnguloX * Math.PI / 180;
            Invalidate();
        }

        protected void RotacionTraslacion(PaintEventArgs pe, Image img, double alphaRot, double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;
            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }
                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta)));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translación

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Mostrar imágen
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }

        protected void RotacionTraslacion2(PaintEventArgs pe, Image img, double yawRot, double alphaRot, double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotación

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }
                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta) + yawRot));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translación

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Soporte de rotación de imágen
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }
    }
}