using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace EstacionControl
{
    class ClasificacionFiguras
    {
        int numeroCuadrados;
        int numeroRectanculos;
        int numeroCirculos;
        int numeroTriangulos;

        public Bitmap ProcesarImagen(Bitmap mapaBits)
        {
            numeroCirculos = 0;
            numeroRectanculos = 0;
            numeroCuadrados = 0;
            numeroTriangulos = 0;
            // bloquear imágen
            BitmapData datosMapaBits = mapaBits.LockBits(
                new Rectangle(0, 0, mapaBits.Width, mapaBits.Height),
                ImageLockMode.ReadWrite, mapaBits.PixelFormat);

            // Paso 1 - Fondo a negro
            ColorFiltering filtroColor = new ColorFiltering();

            filtroColor.Red = new IntRange(0, 64);
            filtroColor.Green = new IntRange(0, 64);
            filtroColor.Blue = new IntRange(0, 64);
            filtroColor.FillOutsideRange = false;

            filtroColor.ApplyInPlace(datosMapaBits);

            // paso 2 - Localizar objetos
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 5;
            blobCounter.MinWidth = 5;

            blobCounter.ProcessImage(datosMapaBits);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            mapaBits.UnlockBits(datosMapaBits);

            // step 3 - check objects' type and highlight
            SimpleShapeChecker verificadorFormas = new SimpleShapeChecker();

            Graphics g = Graphics.FromImage(mapaBits);
            Pen plumaAmarilla = new Pen(Color.Yellow, 5); // Circulo
            Pen plumaRoja = new Pen(Color.Red, 5);       // Cuadrilatero
            Pen plumaCafe = new Pen(Color.Brown, 5);   // Cuadrilatero
            Pen plumaVerde = new Pen(Color.Green, 5);   // Triangulo
            Pen plumaAzul = new Pen(Color.Blue, 5);     // Triangulo

            for (int i = 0, n = blobs.Length; i < n; i++){
                List<IntPoint> bordes = blobCounter.GetBlobsEdgePoints(blobs[i]);

                DoublePoint centro;
                double radio;

                // Verificar si es círculo
                if (verificadorFormas.IsCircle(bordes, out centro, out radio)){
                    g.DrawEllipse(plumaAmarilla,
                        (float)(centro.X - radio), (float)(centro.Y - radio),
                        (float)(radio * 2), (float)(radio * 2));
                    numeroCirculos++;
                    PantallaEstacion.cantidadFiguras[0] = numeroCirculos;
                }else{
                    List<IntPoint> esquinas;
                    // Verificar si es triángulo o cuadrilátero
                    if (verificadorFormas.IsConvexPolygon(bordes, out esquinas)){
                        // obtener subtipo
                        PolygonSubType subTipo = verificadorFormas.CheckPolygonSubType(esquinas);
                        Pen pluma;
                        if (subTipo == PolygonSubType.Unknown){
                            pluma = (esquinas.Count == 4) ? plumaRoja : plumaAzul; //Rectangulo
                            numeroRectanculos++;
                            PantallaEstacion.cantidadFiguras[2] = numeroRectanculos;
                        }else{
                            if(esquinas.Count==4){
                                pluma = plumaCafe;
                                numeroCuadrados++;
                                PantallaEstacion.cantidadFiguras[1] = numeroCuadrados;
                            }else{
                                pluma = plumaVerde;
                                numeroTriangulos++;
                                PantallaEstacion.cantidadFiguras[3] = numeroTriangulos;
                            }
                        }
                        g.DrawPolygon(pluma, ToPointsArray(esquinas));
                    }
                }
            }
            plumaAmarilla.Dispose();
            plumaRoja.Dispose();
            plumaVerde.Dispose();
            plumaAzul.Dispose();
            plumaCafe.Dispose();
            g.Dispose();
            numeroCuadrados--; //Por el rectángulo del borde de la imágen.
            Console.WriteLine("Rectangulos:{0}\nCirculos:{1}\nTriangulos:{2}\nCuadrados{3}", numeroRectanculos, numeroCirculos, numeroTriangulos, numeroCuadrados);
            return mapaBits;
        }


        private Point[] ToPointsArray(List<IntPoint> points)
        {
            Point[] array = new Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new Point(points[i].X, points[i].Y);
            }
            return array;
        }
    }
}