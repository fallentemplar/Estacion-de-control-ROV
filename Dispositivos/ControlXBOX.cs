using log4net;
using System;
using System.Threading;
using XInputDotNetPure;

namespace EstacionControl
{
    class ControlXBOX
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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

                    //////////////GATILLOS///////////////////////////
                    Gatillos(control1, control2);
                    //////////////FIN GATILLOS///////////////////////

                    //////////////STICKS/////////////////////////////
                    Sticks(control1, control2);
                    //////////////FIN STICKS/////////////////////////

                    /////////////////////LB Y RB/////////////////////
                    BotonesTraseros(control1, control2);
                    /////////////////////FIN LB Y RB/////////////////

                    ///////////////////D-PAD/////////////////////////
                    DPad(control1, control2);
                    ///////////////////FIN D-PAD/////////////////////

                    /////////////////BOTONES DE CONTROL//////////////
                    Control(control1, control2);
                    /////////////////FINALIZA BOTONES DE CONTROL/////

                    ////////////////BOTONES DE ACCIÓN////////////////
                    BotonesAccion(control1, control2);
                    ////////////////FIN BOTONES DE ACCIÓN////////////
                    Thread.Sleep(20);
                }
            }
            catch (Exception)
            {
                log.Warn("No fue posible enviar la órden del control");
            }
        }

        private void Gatillos(GamePadState control1, GamePadState control2)
        {
            vGatilloIzq = control1.Triggers.Left;
            if (vGatilloIzq_Anterior != vGatilloIzq){
                vGatilloIzq_Anterior = vGatilloIzq;
                conector.EnviarDatos((Byte)BotonesXBOX.LT_1, vGatilloIzq);
                Console.WriteLine("Gatillo izquierdo: "+vGatilloIzq);
            }
            vGatilloDer = control1.Triggers.Right;
            if (vGatilloDer_Anterior != vGatilloDer){
                vGatilloDer_Anterior = vGatilloDer;
                conector.EnviarDatos((Byte)BotonesXBOX.RT_1, vGatilloDer);
                Console.WriteLine("Gatillo derecho: " + vGatilloDer);
            }
        }

        private void Sticks(GamePadState control1, GamePadState control2)
        {
            /////////////IZQUIERDO//////////////////////////
            vStickIzq_X = control1.ThumbSticks.Left.X;
            if (vStickIzq_X != vS1x_anterior){
                vS1x_anterior = vStickIzq_X;
                conector.EnviarDatos((Byte)BotonesXBOX.S1X_1, vStickIzq_X);
                Console.WriteLine("Stick izquierdo horizontal: "+ vStickIzq_X);
            }

            vStickIzq_Y = control1.ThumbSticks.Left.Y;
            if (vStickIzq_Y != vS1y_anterior){
                vS1y_anterior = vStickIzq_Y;
                conector.EnviarDatos((Byte)BotonesXBOX.S1Y_1, vStickIzq_Y);
                Console.WriteLine("Stick izquierdo vertical: " + vStickIzq_Y);
            }

            if (control1.Buttons.LeftStick.ToString().Equals("Pressed")){
                vBotonStickIzq = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.S1P_1, (float)vBotonStickIzq);
                Console.WriteLine("Botón stick izquierdo");
            }

            /////////////DERECHO///////////////////////////
            vStickDer_X = control1.ThumbSticks.Right.X;
            if (vStickDer_X != vS2x_anterior){
                vS2x_anterior = vStickDer_X;
                conector.EnviarDatos((Byte)BotonesXBOX.S2X_1, vStickDer_X);
                Console.WriteLine("Stick derecho horizontal: " + vStickDer_X);
            }

            vStickDer_Y = control1.ThumbSticks.Right.Y;
            if (vStickDer_Y != vS2y_anterior){
                vS2y_anterior = vStickDer_Y;
                conector.EnviarDatos((Byte)BotonesXBOX.S2Y_1, vStickDer_Y);
                Console.WriteLine("Stick izquierdo vertical: " + vStickDer_Y);
            }

            if (control1.Buttons.RightStick.ToString().Equals("Pressed")){
                vBotonStickDer = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.S2P_1, (float)vBotonStickDer);
                Console.WriteLine("Botón stick derecho");
            }
        }

        private void BotonesTraseros(GamePadState control1, GamePadState control2)
        {
            ///LB
            if (control1.Buttons.LeftShoulder.ToString().Equals("Pressed")){
                vBotonHombroIzq = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.LB_1, (float)vBotonHombroIzq);
                Console.WriteLine("Boton LB presionado");
            }else if (control1.Buttons.LeftShoulder.ToString().Equals("Released")){
                if (vBotonHombroIzq == 1){
                    vBotonHombroIzq = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.LB_1, (float)vBotonHombroIzq);
                    Console.WriteLine("Boton LB soltado");
                }

            }
            ///RB
            if (control1.Buttons.RightShoulder.ToString().Equals("Pressed")){
                vBotonHombroDer = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.RB_1, (float)vBotonHombroIzq);
                Console.WriteLine("Boton RB presionado");
            }
            else if (control1.Buttons.RightShoulder.ToString().Equals("Released")){
                if (vBotonHombroDer == 1){
                    vBotonHombroDer = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.RB_1, (float)vBotonHombroIzq);
                    Console.WriteLine("Boton RB soltado");
                }
            }
        }

        private void DPad(GamePadState control1, GamePadState control2)
        {
            if (control1.DPad.Up.ToString().Equals("Pressed") && vPadVertical < 100){
                /*vPadSup = 1;
                estacion.ActualizarIndicadores("linternas", true);
                conector.EnviarDatos((Byte)BotonesXBOX.DU, (float)vPadSup);*/
                vPadVertical += 20;
                estacion.ActualizarIndicadores("linternas", true);
                conector.EnviarDatos((Byte)BotonesXBOX.DU_1, (float)vPadVertical);
                Console.WriteLine("DPAD-UP: Nivel de linternas: " + vPadVertical);
            }

            if (control1.DPad.Down.ToString().Equals("Pressed") && vPadVertical > 0){
                /*vPadInf = 1;
                estacion.ActualizarIndicadores("linternas", false);
                conector.EnviarDatos((Byte)BotonesXBOX.DD, (float)vPadInf);*/
                vPadVertical -= 20;
                estacion.ActualizarIndicadores("linternas", false);
                conector.EnviarDatos((Byte)BotonesXBOX.DD_1, (float)vPadVertical);
                Console.WriteLine("DPAD-DOWN: Nivel de linternas: " + vPadVertical);
            }

            if (control1.DPad.Left.ToString().Equals("Pressed")){
                vPadIzq = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.DL_1, (float)vPadIzq);
                Console.WriteLine("DPAD-IZQ presionado");
            }else if (control1.DPad.Left.ToString().Equals("Released")){
                if (vPadIzq == 1){
                    vPadIzq = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.DL_1, (float)vPadIzq);
                    Console.WriteLine("DPAD-IZQ soltado");
                }
            }

            if (control1.DPad.Right.ToString().Equals("Pressed")){
                vPadDer = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.DR_1, (float)vPadDer);
                Console.WriteLine("DPAD-DER presionado");
            }
            else if (control1.DPad.Right.ToString().Equals("Released")){
                if (vPadDer == 1){
                    vPadDer = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.DR_1, (float)vPadDer);
                    Console.WriteLine("DPAD-DER soltado");
                }
            }
        }

        private void Control(GamePadState control1, GamePadState control2)
        {
            //Botón START
            if (control1.Buttons.Start.ToString().Equals("Pressed")){
                vBotonStart = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.START_1, (float)vBotonStart);
                Console.WriteLine("Botón START presionado");
            }

            //si se presiona SELECT
            if (control1.Buttons.Back.ToString().Equals("Pressed")){
                vBotonSelect = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.SELECT_1, (float)vBotonSelect);
                Console.WriteLine("Botón SELECT presionado");
            }
        }

        private void BotonesAccion(GamePadState control1, GamePadState control2)
        {
            if (control1.Buttons.A.ToString().Equals("Pressed")){
                vBotonA = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.A_1, (float)vBotonA);
                Console.WriteLine("Botón A presionado");
            }
            else if (control1.Buttons.A.ToString().Equals("Released")){
                if (vBotonA == 1){
                    vBotonA = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.A_1, (float)vBotonA);
                    Console.WriteLine("Botón A soltado");
                }
            }

            if (control1.Buttons.B.ToString().Equals("Pressed")){
                vBotonB = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.B_1, (float)vBotonB);
                Console.WriteLine("Botón B presionado");
            }
            else if (control1.Buttons.B.ToString().Equals("Released")){
                if (vBotonB == 1){
                    vBotonB = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.B_1, (float)vBotonB);
                    Console.WriteLine("Botón B soltado");
                }
            }

            if (control1.Buttons.X.ToString().Equals("Pressed")){
                vBotonX = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.X_1, (float)vBotonX);
                Console.WriteLine("Botón X presionado");
            }
            else if (control1.Buttons.X.ToString().Equals("Released")){
                if (vBotonX == 1){
                    vBotonX = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.X_1, (float)vBotonX);
                    Console.WriteLine("Botón X soltado");
                }
            }

            if (control1.Buttons.Y.ToString().Equals("Pressed")){
                vBotonY = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.Y_1, (float)vBotonY);
                Console.WriteLine("Botón Y presionado");
            }
            else if (control1.Buttons.Y.ToString().Equals("Released")){
                if (vBotonY == 1){
                    vBotonY = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.Y_1, (float)vBotonY);
                    Console.WriteLine("Botón Y soltado");
                }
            }
        }
    }

    public enum BotonesXBOX : byte
    {
        Centro_1, A_1, B_1, X_1, Y_1, LB_1, RB_1, LT_1, RT_1, DU_1, DD_1, DL_1, DR_1, S1X_1, S1Y_1, S2X_1, S2Y_1, SELECT_1, START_1, S1P_1, S2P_1,
        Centro_2, A_2, B_2, X_2, Y_2, LB_2, RB_2, LT_2, RT_2, DU_2, DD_2, DL_2, DR_2, S1X_2, S1Y_2, S2X_2, S2Y_2, SELECT_2, START_2, S1P_2, S2P_2
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
