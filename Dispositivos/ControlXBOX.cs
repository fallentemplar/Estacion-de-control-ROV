using System;
using System.Threading;
using XInputDotNetPure;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EstacionControl
{
    class ControlXBOX
    {
        //Objetos de conexión
        ConectividadRemota conector;
        PantallaEstacion estacion;

        //Stick izquierdo
        float vStickIzq_X = 0;
        float vStickIzq_Y = 0;
        float vS1x_anterior = 0;
        float vS1y_anterior = 0;

        //Stick derecho
        float vStickDer_X = 0;
        float vStickDer_Y = 0;
        float vS2x_anterior = 0;
        float vS2y_anterior = 0;
        //Gatillos
        float vGatilloIzq = 0;
        float vGatilloIzq_Anterior = 0;
        float vGatilloDer = 0;
        float vGatilloDer_Anterior = 0;

        //Botones derecha
        int vBotonA = 0;
        int vBotonB = 0;
        int vBotonX = 0;
        int vBotonY = 0;

        //Botones D-Pad
        int vPadSup = 0;
        int vPadInf = 0;
        int vPadVertical = 0;
        int vPadIzq = 0;
        int vPadDer = 0;

        //Gatillos 
        int vBotonHombroIzq = 0;
        int vBotonHombroDer = 0;

        int vBotonSelect = 0;
        int vBotonStart = 0;
        int vBotonStickIzq = 0;
        int vBotonStickDer = 0;

        public ControlXBOX(ConectividadRemota socketConector,PantallaEstacion estacion)
        {
            conector = socketConector;
            this.estacion = estacion;
        }

        public bool Estado_control(PlayerIndex control)
        {
            GamePadState controlConectado; // Obtiene el estado del control 
            controlConectado = GamePad.GetState(control);
            return (controlConectado.IsConnected);
        }

        public void ActualizarEstadoOrdenes()
        {
            try
            {
                while (true)
                {
                    GamePadState control1 = GamePad.GetState(PlayerIndex.One);
                    GamePadState control2 = GamePad.GetState(PlayerIndex.Two);

                    //////////////GATILLOS////////////////////////////
                    vGatilloIzq = control1.Triggers.Left;
                    if (vGatilloIzq_Anterior != vGatilloIzq)
                    {
                        vGatilloIzq_Anterior = vGatilloIzq;
                        conector.EnviarDatos((Byte)BotonesXBOX.LT, vGatilloIzq);
                    }
                    vGatilloDer = control1.Triggers.Right;
                    if (vGatilloDer_Anterior != vGatilloDer)
                    {
                        vGatilloDer_Anterior = vGatilloDer;
                        conector.EnviarDatos((Byte)BotonesXBOX.RT, vGatilloDer);
                    }
                    //////////////FINALIZA GATILLOS////////////////////////////

                    //////////////STICKS///////////////////////////////////////
                    /////////////IZQUIERDO//////////////////////////
                    vStickIzq_X = control1.ThumbSticks.Left.X;
                    if (vStickIzq_X != vS1x_anterior)
                    {
                        vS1x_anterior = vStickIzq_X;
                        conector.EnviarDatos((Byte)BotonesXBOX.S1X, vStickIzq_X);
                    }

                    vStickIzq_Y = control1.ThumbSticks.Left.Y;
                    if (vStickIzq_Y != vS1y_anterior)
                    {
                        vS1y_anterior = vStickIzq_Y;
                        conector.EnviarDatos((Byte)BotonesXBOX.S1Y, vStickIzq_Y);
                    }

                    /////////////DERECHO///////////////////////////
                    vStickDer_X = control1.ThumbSticks.Right.X;
                    if (vStickDer_X != vS2x_anterior)
                    {
                        vS2x_anterior = vStickDer_X;
                        conector.EnviarDatos((Byte)BotonesXBOX.S2X, vStickDer_X);
                    }

                    vStickDer_Y = control1.ThumbSticks.Right.Y;
                    if (vStickDer_Y != vS2y_anterior)
                    {
                        vS2y_anterior = vStickDer_Y;
                        conector.EnviarDatos((Byte)BotonesXBOX.S2Y, vStickDer_Y);
                    }
                    //////////////FINALIZA STICKS////////////////////////////

                    //Actualizar valor de botones digitales

                    /////////////////////LB Y RB///////////////////////////////////
                    if (control1.Buttons.LeftShoulder.ToString().Equals("Pressed")) //LB
                    {
                        vBotonHombroIzq = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.LB, (float)vBotonHombroIzq);
                    }
                    else if (control1.Buttons.LeftShoulder.ToString().Equals("Released"))
                    {
                        if (vBotonHombroIzq == 1)
                        {
                            vBotonHombroIzq = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.LB, (float)vBotonHombroIzq);
                        }
                    }

                    if (control1.Buttons.RightShoulder.ToString().Equals("Pressed")) //RB
                    {
                        vBotonHombroDer = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.RB, (float)vBotonHombroIzq);
                    }
                    else if (control1.Buttons.RightShoulder.ToString().Equals("Released"))
                    {
                        if (vBotonHombroDer == 1)
                        {
                            vBotonHombroDer = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.RB, (float)vBotonHombroIzq);
                        }
                    }
                    /////////////////////FIN LB Y RB///////////////////////////////////

                    ///////////////////D-PAD/////////////////////////////////////////////
                    if (control1.DPad.Up.ToString().Equals("Pressed") && vPadVertical<100)
                    {
                        /*vPadSup = 1;
                        estacion.ActualizarIndicadores("linternas", true);
                        conector.EnviarDatos((Byte)BotonesXBOX.DU, (float)vPadSup);*/
                        vPadVertical += 20;
                        estacion.ActualizarIndicadores("linternas", true);
                        conector.EnviarDatos((Byte)BotonesXBOX.DU, (float)vPadVertical);
                        Console.WriteLine("vPadVertical: " + vPadVertical);
                    }

                    if (control1.DPad.Down.ToString().Equals("Pressed") && vPadVertical>0)
                    {
                        /*vPadInf = 1;
                        estacion.ActualizarIndicadores("linternas", false);
                        conector.EnviarDatos((Byte)BotonesXBOX.DD, (float)vPadInf);*/
                        vPadVertical -= 20;
                        estacion.ActualizarIndicadores("linternas", false);
                        conector.EnviarDatos((Byte)BotonesXBOX.DD, (float)vPadVertical);
                        Console.WriteLine("vPadVertical: " + vPadVertical);
                    }

                    if (control1.DPad.Left.ToString().Equals("Pressed"))
                    {
                        vPadIzq = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.DL, (float)vPadIzq);
                    }
                    else if (control1.DPad.Left.ToString().Equals("Released"))
                    {
                        if (vPadIzq == 1)
                        {
                            vPadIzq = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.DL, (float)vPadIzq);
                        }
                    }

                    if (control1.DPad.Right.ToString().Equals("Pressed"))
                    {
                        vPadDer = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.DR, (float)vPadDer);
                    }
                    else if (control1.DPad.Right.ToString().Equals("Released"))
                    {
                        if (vPadDer == 1)
                        {
                            vPadDer = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.DR, (float)vPadDer);
                        }
                    }

                    /////////////////BOTONES DE CONTROL///////////////////////////
                    if (control1.Buttons.Start.ToString().Equals("Pressed"))
                    {
                        vBotonStart = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.START, (float)vBotonStart);
                    }

                    if (control1.Buttons.Back.ToString().Equals("Pressed")) //si se presiona SELECT
                    {
                        vBotonSelect = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.SELECT, (float)vBotonSelect);
                    }

                    if (control1.Buttons.LeftStick.ToString().Equals("Pressed"))
                    {
                        vBotonStickIzq = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.S1P, (float)vBotonStickIzq);
                    }

                    if (control1.Buttons.RightStick.ToString().Equals("Pressed"))
                    {
                        vBotonStickDer = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.S2P, (float)vBotonStickDer);
                    }
                    /////////////////FINALIZA BOTONES DE CONTROL///////////////////////////

                    if (control1.Buttons.A.ToString().Equals("Pressed"))
                    {
                        vBotonA = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.A, (float)vBotonA);
                    }
                    else if (control1.Buttons.A.ToString().Equals("Released"))
                    {
                        if (vBotonA == 1)
                        {
                            vBotonA = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.A, (float)vBotonA);
                        }
                    }

                    if (control1.Buttons.B.ToString().Equals("Pressed"))
                    {
                        vBotonB = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.B, (float)vBotonB);
                    }
                    else if (control1.Buttons.B.ToString().Equals("Released"))
                    {
                        if (vBotonB == 1)
                        {
                            vBotonB = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.B, (float)vBotonB);
                        }
                    }

                    if (control1.Buttons.X.ToString().Equals("Pressed"))
                    {
                        vBotonX = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.X, (float)vBotonX);
                    }
                    else if (control1.Buttons.X.ToString().Equals("Released"))
                    {
                        if (vBotonX == 1)
                        {
                            vBotonX = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.X, (float)vBotonX);
                        }
                    }

                    if (control1.Buttons.Y.ToString().Equals("Pressed"))
                    {
                        vBotonY = 1;
                        conector.EnviarDatos((Byte)BotonesXBOX.Y, (float)vBotonY);
                    }

                    else if (control1.Buttons.Y.ToString().Equals("Released"))
                    {
                        if (vBotonY == 1)
                        {
                            vBotonY = 0;
                            conector.EnviarDatos((Byte)BotonesXBOX.Y, (float)vBotonY);
                        }
                    }
                    Thread.Sleep(20);
                }
            }
            catch (Exception)
            {

            }
        }
    }

    public enum BotonesXBOX : byte
    {
        Centro, A, B, X, Y, LB, RB, LT, RT, DU, DD, DL, DR, S1X, S1Y, S2X, S2Y, SELECT, START, S1P, S2P
    }
}
//Constantes
/*public const byte A = 1;
public const byte B = 2;
public const byte X = 3;
public const byte Y = 4;
public const byte LB = 5;
public const byte RB = 6;
public const byte LT = 7;
public const byte RT = 8;
public const byte DU = 9;
public const byte DD = 10;
public const byte DL = 11;
public const byte DR = 12;
public const byte S1X = 13;
public const byte S1Y = 14;
public const byte S2X = 15;
public const byte S2Y = 16;
public const byte SELECT = 17;
public const byte START = 18;
public const byte S1P = 19;
public const byte S2P = 20;*/
