using log4net;
using System;
using System.Threading;
using XInputDotNetPure;

namespace EstacionControl
{
    class ControlXBOX
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool miniROVDesplegado;

        //Objetos de conexión
        public ConectividadRemota conector { get; set; }
        PantallaEstacion estacion;

        //Valores de controles
        ValoresControles valoresControl1;
        ValoresControles valoresControl2;

        struct ValoresControles
        {
            #region Sticks
            //Stick izquierdo
            public float vStickIzq_X;
            public float vStickIzq_Y;
            public float vS1x_anterior;
            public float vS1y_anterior;
            public int vBotonStickIzq;

            //Stick derecho
            public float vStickDer_X;
            public float vStickDer_Y;
            public float vS2x_anterior;
            public float vS2y_anterior;
            public int vBotonStickDer;
            #endregion
            #region Gatillos
            //Gatillos
            public float vGatilloIzq;
            public float vGatilloIzq_Anterior;
            public float vGatilloDer;
            public float vGatilloDer_Anterior;
            public int vBotonHombroIzq;
            public int vBotonHombroDer;
            #endregion
            #region BotonesOrdenes
            //Botones derecha
            public int vBotonA;
            public int vBotonB;
            public int vBotonX;
            public int vBotonY;
            #endregion
            #region DPad
            //Botones D-Pad
            public int vPadVertical;
            public int vPadSup;
            public int vPadInf;
            public int vPadIzq;
            public int vPadDer;
            #endregion
            #region BotonesControl
            public int vBotonSelect;
            public int vBotonStart;
            #endregion
        }

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
            try{
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
                    Thread.Sleep(50);
                }
            }catch (ThreadInterruptedException){
                log.Warn("ActualizarEstadoOrdenes detenido");
            }
            catch (Exception)
            {
                log.Warn("No fue posible enviar la órden del control");
            }
        }

        private void Gatillos(GamePadState control1, GamePadState control2)
        {
            #region Control1
            //-----------------Control 1------------------------//
            valoresControl1.vGatilloIzq = control1.Triggers.Left;
            if (valoresControl1.vGatilloIzq_Anterior != valoresControl1.vGatilloIzq){
                valoresControl1.vGatilloIzq_Anterior = valoresControl1.vGatilloIzq;
                conector.EnviarDatos((Byte)BotonesXBOX.LT_1, valoresControl1.vGatilloIzq);
                Console.WriteLine("Gatillo izquierdo C1: "+ valoresControl1.vGatilloIzq);
            }
            valoresControl1.vGatilloDer = control1.Triggers.Right;
            if (valoresControl1.vGatilloDer_Anterior != valoresControl1.vGatilloDer){
                valoresControl1.vGatilloDer_Anterior = valoresControl1.vGatilloDer;
                conector.EnviarDatos((Byte)BotonesXBOX.RT_1, valoresControl1.vGatilloDer);
                Console.WriteLine("Gatillo derecho C1: " + valoresControl1.vGatilloDer);
            }
            #endregion
            #region Control2
            if(!miniROVDesplegado)
            {
                valoresControl2.vGatilloIzq = control2.Triggers.Left;
                if (valoresControl2.vGatilloIzq_Anterior != valoresControl2.vGatilloIzq)
                {
                    valoresControl2.vGatilloIzq_Anterior = valoresControl2.vGatilloIzq;
                    conector.EnviarDatos((Byte)BotonesXBOX.LT_2, valoresControl2.vGatilloIzq);
                    Console.WriteLine("Gatillo izquierdo C2: " + valoresControl2.vGatilloIzq);
                }
                valoresControl2.vGatilloDer = control2.Triggers.Right;
                if (valoresControl2.vGatilloDer_Anterior != valoresControl2.vGatilloDer)
                {
                    valoresControl2.vGatilloDer_Anterior = valoresControl2.vGatilloDer;
                    conector.EnviarDatos((Byte)BotonesXBOX.RT_2, valoresControl2.vGatilloDer);
                    Console.WriteLine("Gatillo derecho C2: " + valoresControl2.vGatilloDer);
                }
            }
            #endregion
        }

        private void Sticks(GamePadState control1, GamePadState control2)
        {
            #region Control1
            /////////////IZQUIERDO//////////////////////////
            valoresControl1.vStickIzq_X = control1.ThumbSticks.Left.X;
            if (valoresControl1.vStickIzq_X != valoresControl1.vS1x_anterior){
                valoresControl1.vS1x_anterior = valoresControl1.vStickIzq_X;
                conector.EnviarDatos((Byte)BotonesXBOX.S1X_1, valoresControl1.vStickIzq_X);
                Console.WriteLine("Stick izquierdo horizontal: "+ valoresControl1.vStickIzq_X);
            }

            valoresControl1.vStickIzq_Y = control1.ThumbSticks.Left.Y;
            if (valoresControl1.vStickIzq_Y != valoresControl1.vS1y_anterior){
                valoresControl1.vS1y_anterior = valoresControl1.vStickIzq_Y;
                conector.EnviarDatos((Byte)BotonesXBOX.S1Y_1, valoresControl1.vStickIzq_Y);
                Console.WriteLine("Stick izquierdo vertical: " + valoresControl1.vStickIzq_Y);
            }

            if (control1.Buttons.LeftStick.ToString().Equals("Pressed")){
                valoresControl1.vBotonStickIzq = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.S1P_1, (float)valoresControl1.vBotonStickIzq);
                Console.WriteLine("Botón stick izquierdo");
            }

            /////////////DERECHO///////////////////////////
            valoresControl1.vStickDer_X = control1.ThumbSticks.Right.X;
            if (valoresControl1.vStickDer_X != valoresControl1.vS2x_anterior){
                valoresControl1.vS2x_anterior = valoresControl1.vStickDer_X;
                conector.EnviarDatos((Byte)BotonesXBOX.S2X_1, valoresControl1.vStickDer_X);
                Console.WriteLine("Stick derecho horizontal: " + valoresControl1.vStickDer_X);
            }

            valoresControl1.vStickDer_Y = control1.ThumbSticks.Right.Y;
            if (valoresControl1.vStickDer_Y != valoresControl1.vS2y_anterior){
                valoresControl1.vS2y_anterior = valoresControl1.vStickDer_Y;
                conector.EnviarDatos((Byte)BotonesXBOX.S2Y_1, valoresControl1.vStickDer_Y);
                Console.WriteLine("Stick izquierdo vertical: " + valoresControl1.vStickDer_Y);
            }

            if (control1.Buttons.RightStick.ToString().Equals("Pressed")){
                valoresControl1.vBotonStickDer = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.S2P_1, (float)valoresControl1.vBotonStickDer);
                Console.WriteLine("Botón stick derecho");
            }
            #endregion
            #region Control2
            if(!miniROVDesplegado)
            {
                //----------------Control 2----------------------------//
                /////////////IZQUIERDO//////////////////////////
                valoresControl2.vStickIzq_X = control2.ThumbSticks.Left.X;
                if (valoresControl2.vStickIzq_X != valoresControl2.vS1x_anterior)
                {
                    valoresControl2.vS1x_anterior = valoresControl2.vStickIzq_X;
                    conector.EnviarDatos((Byte)BotonesXBOX.S1X_2, valoresControl2.vStickIzq_X);
                    Console.WriteLine("Stick izquierdo horizontal: " + valoresControl2.vStickIzq_X);
                }

                valoresControl2.vStickIzq_Y = control2.ThumbSticks.Left.Y;
                if (valoresControl2.vStickIzq_Y != valoresControl2.vS1y_anterior)
                {
                    valoresControl2.vS1y_anterior = valoresControl2.vStickIzq_Y;
                    conector.EnviarDatos((Byte)BotonesXBOX.S1Y_2, valoresControl2.vStickIzq_Y);
                    Console.WriteLine("Stick izquierdo vertical: " + valoresControl2.vStickIzq_Y);
                }

                if (control2.Buttons.LeftStick.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonStickIzq = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.S1P_2, (float)valoresControl2.vBotonStickIzq);
                    Console.WriteLine("Botón stick izquierdo");
                }

                /////////////DERECHO///////////////////////////
                valoresControl2.vStickDer_X = control2.ThumbSticks.Right.X;
                if (valoresControl2.vStickDer_X != valoresControl2.vS2x_anterior)
                {
                    valoresControl2.vS2x_anterior = valoresControl2.vStickDer_X;
                    conector.EnviarDatos((Byte)BotonesXBOX.S2X_2, valoresControl2.vStickDer_X);
                    Console.WriteLine("Stick derecho horizontal: " + valoresControl2.vStickDer_X);
                }

                valoresControl2.vStickDer_Y = control2.ThumbSticks.Right.Y;
                if (valoresControl2.vStickDer_Y != valoresControl2.vS2y_anterior)
                {
                    valoresControl2.vS2y_anterior = valoresControl2.vStickDer_Y;
                    conector.EnviarDatos((Byte)BotonesXBOX.S2Y_2, valoresControl2.vStickDer_Y);
                    Console.WriteLine("Stick izquierdo vertical: " + valoresControl2.vStickDer_Y);
                }

                if (control2.Buttons.RightStick.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonStickDer = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.S2P_2, (float)valoresControl2.vBotonStickDer);
                    Console.WriteLine("Botón stick derecho");
                }
            }
            #endregion
        }

        private void BotonesTraseros(GamePadState control1, GamePadState control2)
        {
            #region Control1
            ///LB
            if (control1.Buttons.LeftShoulder.ToString().Equals("Pressed")){
                valoresControl1.vBotonHombroIzq = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.LB_1, (float)valoresControl1.vBotonHombroIzq);
                Console.WriteLine("Boton LB presionado");
            }else if (control1.Buttons.LeftShoulder.ToString().Equals("Released")){
                if (valoresControl1.vBotonHombroIzq == 1){
                    valoresControl1.vBotonHombroIzq = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.LB_1, (float)valoresControl1.vBotonHombroIzq);
                    Console.WriteLine("Boton LB soltado");
                }

            }
            ///RB
            if (control1.Buttons.RightShoulder.ToString().Equals("Pressed")){
                valoresControl1.vBotonHombroDer = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.RB_1, (float)valoresControl1.vBotonHombroIzq);
                Console.WriteLine("Boton RB presionado");
            }
            else if (control1.Buttons.RightShoulder.ToString().Equals("Released")){
                if (valoresControl1.vBotonHombroDer == 1){
                    valoresControl1.vBotonHombroDer = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.RB_1, (float)valoresControl1.vBotonHombroIzq);
                    Console.WriteLine("Boton RB soltado");
                }
            }
            #endregion
            #region Control2
            if(!miniROVDesplegado)
            {
                //--------------------------Control 2--------------//
                ///LB
                if (control2.Buttons.LeftShoulder.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonHombroIzq = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.LB_2, (float)valoresControl2.vBotonHombroIzq);
                    Console.WriteLine("Boton LB presionado");
                }
                else if (control2.Buttons.LeftShoulder.ToString().Equals("Released"))
                {
                    if (valoresControl2.vBotonHombroIzq == 1)
                    {
                        valoresControl2.vBotonHombroIzq = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.LB_2, (float)valoresControl2.vBotonHombroIzq);
                        Console.WriteLine("Boton LB soltado");
                    }
                }
                ///RB
                if (control2.Buttons.RightShoulder.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonHombroDer = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.RB_2, (float)valoresControl2.vBotonHombroIzq);
                    Console.WriteLine("Boton RB presionado");
                }
                else if (control2.Buttons.RightShoulder.ToString().Equals("Released"))
                {
                    if (valoresControl2.vBotonHombroDer == 1)
                    {
                        valoresControl2.vBotonHombroDer = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.RB_2, (float)valoresControl2.vBotonHombroIzq);
                        Console.WriteLine("Boton RB soltado");
                    }
                }
            }
            #endregion
        }

        private void DPad(GamePadState control1, GamePadState control2)
        {
            #region Control1
            if (control1.DPad.Up.ToString().Equals("Pressed") && valoresControl1.vPadVertical < 100)
            {
                valoresControl1.vPadVertical += 20;
                estacion.ActualizarIndicadores("linternas", true);
                conector.EnviarDatos((Byte)BotonesXBOX.DU_1, (Int32)1);
                Console.WriteLine("DPAD-UP: Nivel de linternas: " + valoresControl1.vPadVertical);
            }

            if (control1.DPad.Down.ToString().Equals("Pressed") && valoresControl1.vPadVertical > 0)
            {
                valoresControl1.vPadVertical -= 20;
                estacion.ActualizarIndicadores("linternas", false);
                conector.EnviarDatos((Byte)BotonesXBOX.DD_1, (Int32)1);
                Console.WriteLine("DPAD-DOWN: Nivel de linternas: " + valoresControl1.vPadVertical);
            }

            if (control1.DPad.Left.ToString().Equals("Pressed")){
                valoresControl1.vPadIzq = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.DL_1, (float)valoresControl1.vPadIzq);
                Console.WriteLine("DPAD-IZQ presionado");
            }else if (control1.DPad.Left.ToString().Equals("Released")){
                if (valoresControl1.vPadIzq == 1){
                    valoresControl1.vPadIzq = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.DL_1, (float)valoresControl1.vPadIzq);
                    Console.WriteLine("DPAD-IZQ soltado");
                }
            }

            if (control1.DPad.Right.ToString().Equals("Pressed")){
                valoresControl1.vPadDer = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.DR_1, (float)valoresControl1.vPadDer);
                Console.WriteLine("DPAD-DER presionado");
            }
            else if (control1.DPad.Right.ToString().Equals("Released")){
                if (valoresControl1.vPadDer == 1){
                    valoresControl1.vPadDer = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.DR_1, (float)valoresControl1.vPadDer);
                    Console.WriteLine("DPAD-DER soltado");
                }
            }
            #endregion
            #region Control2
            if(!miniROVDesplegado)
            {
                //---------------------Control 2-----------------//
                if (control2.DPad.Up.ToString().Equals("Pressed") && valoresControl2.vPadVertical < 100)
                {
                    valoresControl2.vPadSup = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.DU_2, (float)valoresControl2.vPadSup);
                }

                if (control2.DPad.Down.ToString().Equals("Pressed") && valoresControl2.vPadVertical > 0)
                {
                    valoresControl2.vPadInf = 1;
                    estacion.ActualizarIndicadores("linternas", false);
                    conector.EnviarDatos((Byte)BotonesXBOX.DD_2, (float)valoresControl2.vPadInf);
                }

                if (control2.DPad.Left.ToString().Equals("Pressed"))
                {
                    valoresControl2.vPadIzq = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.DL_2, (float)valoresControl2.vPadIzq);
                    Console.WriteLine("DPAD-IZQ presionado");
                }
                else if (control2.DPad.Left.ToString().Equals("Released"))
                {
                    if (valoresControl2.vPadIzq == 1)
                    {
                        valoresControl2.vPadIzq = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.DL_2, (float)valoresControl2.vPadIzq);
                        Console.WriteLine("DPAD-IZQ soltado");
                    }
                }

                if (control2.DPad.Right.ToString().Equals("Pressed"))
                {
                    valoresControl2.vPadDer = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.DR_2, (float)valoresControl2.vPadDer);
                    Console.WriteLine("DPAD-DER presionado");
                }
                else if (control2.DPad.Right.ToString().Equals("Released"))
                {
                    if (valoresControl2.vPadDer == 1)
                    {
                        valoresControl2.vPadDer = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.DR_2, (float)valoresControl2.vPadDer);
                        Console.WriteLine("DPAD-DER soltado");
                    }
                }
            }
            #endregion
        }

        private void Control(GamePadState control1, GamePadState control2)
        {
            #region Control1
            //Botón START
            if (control1.Buttons.Start.ToString().Equals("Pressed")){
                valoresControl1.vBotonStart = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.START_1, (float)valoresControl1.vBotonStart);
                Console.WriteLine("Botón START presionado");
            }

            //Botón SELECT
            if (control1.Buttons.Back.ToString().Equals("Pressed")){
                valoresControl1.vBotonSelect = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.SELECT_1, (float)valoresControl1.vBotonSelect);
                Console.WriteLine("Botón SELECT presionado");
            }
            #endregion
            #region Control2
            if(!miniROVDesplegado)
            {
                //Botón START
                if (control2.Buttons.Start.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonStart = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.START_2, (float)valoresControl2.vBotonStart);
                    Console.WriteLine("Botón START presionado");
                }

                //Botón SELECT
                if (control2.Buttons.Back.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonSelect = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.SELECT_2, (float)valoresControl2.vBotonSelect);
                    Console.WriteLine("Botón SELECT presionado");
                }
            }
            #endregion
        }

        private void BotonesAccion(GamePadState control1, GamePadState control2)
        {
            #region Control1
            if (control1.Buttons.A.ToString().Equals("Pressed")){
                valoresControl1.vBotonA = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.A_1, (float)valoresControl1.vBotonA);
                Console.WriteLine("Botón A presionado");
            }
            else if (control1.Buttons.A.ToString().Equals("Released")){
                if (valoresControl1.vBotonA == 1){
                    valoresControl1.vBotonA = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.A_1, (float)valoresControl1.vBotonA);
                    Console.WriteLine("Botón A soltado");
                }
            }

            if (control1.Buttons.B.ToString().Equals("Pressed")){
                valoresControl1.vBotonB = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.B_1, (float)valoresControl1.vBotonB);
                Console.WriteLine("Botón B presionado");
            }
            else if (control1.Buttons.B.ToString().Equals("Released")){
                if (valoresControl1.vBotonB == 1){
                    valoresControl1.vBotonB = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.B_1, (float)valoresControl1.vBotonB);
                    Console.WriteLine("Botón B soltado");
                }
            }

            if (control1.Buttons.X.ToString().Equals("Pressed")){
                valoresControl1.vBotonX = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.X_1, (float)valoresControl1.vBotonX);
                Console.WriteLine("Botón X presionado");
            }
            else if (control1.Buttons.X.ToString().Equals("Released")){
                if (valoresControl1.vBotonX == 1){
                    valoresControl1.vBotonX = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.X_1, (float)valoresControl1.vBotonX);
                    Console.WriteLine("Botón X soltado");
                }
            }

            if (control1.Buttons.Y.ToString().Equals("Pressed")){
                valoresControl1.vBotonY = 1;
                conector.EnviarDatos((Byte)BotonesXBOX.Y_1, (float)valoresControl1.vBotonY);
                Console.WriteLine("Botón Y presionado");
            }
            else if (control1.Buttons.Y.ToString().Equals("Released")){
                if (valoresControl1.vBotonY == 1){
                    valoresControl1.vBotonY = 0;
                    conector.EnviarDatos((Byte)BotonesXBOX.Y_1, (float)valoresControl1.vBotonY);
                    Console.WriteLine("Botón Y soltado");
                }
            }
            #endregion
            #region Control2
            if(!miniROVDesplegado)
            {
                if (control2.Buttons.A.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonA = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.A_2, (float)valoresControl2.vBotonA);
                    Console.WriteLine("Botón A presionado");
                }
                else if (control2.Buttons.A.ToString().Equals("Released"))
                {
                    if (valoresControl2.vBotonA == 1)
                    {
                        valoresControl2.vBotonA = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.A_2, (float)valoresControl2.vBotonA);
                        Console.WriteLine("Botón A soltado");
                    }
                }

                if (control2.Buttons.B.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonB = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.B_2, (float)valoresControl2.vBotonB);
                    Console.WriteLine("Botón B presionado");
                }
                else if (control2.Buttons.B.ToString().Equals("Released"))
                {
                    if (valoresControl2.vBotonB == 1)
                    {
                        valoresControl2.vBotonB = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.B_2, (float)valoresControl2.vBotonB);
                        Console.WriteLine("Botón B soltado");
                    }
                }

                if (control2.Buttons.X.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonX = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.X_2, (float)valoresControl2.vBotonX);
                    Console.WriteLine("Botón X presionado");
                }
                else if (control2.Buttons.X.ToString().Equals("Released"))
                {
                    if (valoresControl2.vBotonX == 1)
                    {
                        valoresControl2.vBotonX = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.X_2, (float)valoresControl2.vBotonX);
                        Console.WriteLine("Botón X soltado");
                    }
                }

                if (control2.Buttons.Y.ToString().Equals("Pressed"))
                {
                    valoresControl2.vBotonY = 1;
                    conector.EnviarDatos((Byte)BotonesXBOX.Y_2, (float)valoresControl2.vBotonY);
                    Console.WriteLine("Botón Y presionado");
                }
                else if (control2.Buttons.Y.ToString().Equals("Released"))
                {
                    if (valoresControl2.vBotonY == 1)
                    {
                        valoresControl2.vBotonY = 0;
                        conector.EnviarDatos((Byte)BotonesXBOX.Y_2, (float)valoresControl2.vBotonY);
                        Console.WriteLine("Botón Y soltado");
                    }
                }
            }
            #endregion
        }
    }

    public enum BotonesXBOX : byte
    {
        Comando, A_1, B_1, X_1, Y_1, LB_1, RB_1, LT_1, RT_1, DU_1, DD_1, DL_1, DR_1, S1X_1, S1Y_1, S2X_1, S2Y_1, SELECT_1, START_1, S1P_1, S2P_1,
        A_2, B_2, X_2, Y_2, LB_2, RB_2, LT_2, RT_2, DU_2, DD_2, DL_2, DR_2, S1X_2, S1Y_2, S2X_2, S2Y_2, SELECT_2, START_2, S1P_2, S2P_2
    }
}