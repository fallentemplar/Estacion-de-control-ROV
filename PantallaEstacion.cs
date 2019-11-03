using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using XInputDotNetPure;
using System.Net.Sockets;
using log4net;
using EstacionControl.Dispositivos.Sensores;
using EstacionControl.ProcesamientoImagenes;
using System.Diagnostics;
using AForge.Video.VFW;
using EstacionControl.Ventanas;
using EstacionControl.Dispositivos;
using System.Media;

namespace EstacionControl
{
    public partial class PantallaEstacion : Form
    {
        #region Constantes
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly string rutaCapturas = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\EstacionControl\\Capturas\\";
        #endregion
        Giroscopio giroscopio;
        Color colorCampos;
        #region Objetos conectividad
        //Objetos para log y conectividad
        ConectividadRemota socketConector;
        ConectividadRemota socketReceptor;
        ConectividadRemota socketMiniROV;
        ControlXBOX controles;
        #endregion

        #region Variables comprobar conectividad
        //Variables para comprobar conectividad
        bool control1_conectado;
        bool control2_conectado;
        bool raspberry_conectado;
        bool arduino_conectado;
        bool profTemp_conectado;
        bool giroscopio_conectado;
        public static bool recibiendo_video1;
        public static bool recibiendo_video2;
        public static bool recibiendo_video3;
        #endregion

        #region Booleanos
        bool grabandoVideo1;
        bool grabandoVideo2;
        bool diafragmaAbierto;
        bool miniROVDesplegado;
        #endregion

        #region Threads Principales
        //Threads principales
        //Thread actualizarControles;
        //Thread dispositivosRemotos;
        //Thread capturarVideo;
        //Thread conexionConRaspberry;
        #endregion

        SortedList<string, Thread> coleccionThreads;

        public PantallaEstacion()
        {
            log.Info("----Iniciando ejecución----");
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            coleccionThreads = new SortedList<string, Thread>();
        }
        
        //Se inician múltiples hilos del programa y se ejecutan en segundo plano
        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = EstacionControl.Properties.Resources.icono_tmmx_nuevo;
            colorCampos = indicador_temperatura.BackColor;

            socketConector = new ConectividadRemota(direccion_ip_texto.Text);
            socketReceptor = new ConectividadRemota(direccion_ip_texto.Text, 7001);
            controles = new ControlXBOX(socketConector,this);
            giroscopio = new Giroscopio(socketReceptor);

            //Hilo para manejar el control de XBOX ONE
            //CrearThreads(ListaThreads.actualizarControles);

            
            //Hilo de verificación de comunicación de dispositivos periféricos remotos
            //CrearThreads(ListaThreads.dispositivosRemotos);

            //Hilo de verificación de comunicación de dispositivos periféricos locales
            CrearThreads(ListaThreads.verifConectividad);

            PintarElementos();

            //-------------------------------------------//
            Giroscopio.mybitmap2.MakeTransparent(Color.Yellow); // Sets image transparency
            Giroscopio.mybitmap4.MakeTransparent(Color.Yellow); // Sets image transparency

            lista_camaras1.Click += Lista_camaras1_Click;
            lista_camaras2.Click += Lista_camaras2_Click;

            Camaras.InicializarCamaras();
            Camaras.AgregarCamarasIniciales();

            foreach(var camara in Camaras.listaCamaras)
            {
                lista_camaras1.Items.Add(camara.Value);
                lista_camaras2.Items.Add(camara.Value);
            }
            lista_camaras1.SelectedIndex = 0;
            lista_camaras2.SelectedIndex = 1;
        }

        private void Lista_camaras2_Click(object sender, EventArgs e)
        {
            lista_camaras2.Items.Clear();
            foreach (var camara in Camaras.listaCamaras)
            {
                lista_camaras2.Items.Add(camara.Value);
            }
            lista_camaras2.SelectedIndex = 1;
        }

        private void Lista_camaras1_Click(object sender, EventArgs e)
        {
            lista_camaras1.Items.Clear();
            foreach (var camara in Camaras.listaCamaras)
            {
                lista_camaras1.Items.Add(camara.Value);
            }
            lista_camaras1.SelectedIndex = 0;
        }

        //---------------------------------------------------------------------------------------------------------
        //Sección de comprobar conectividad
        //---------------------------------------------------------------------------------------------------------

        private delegate void delegado_control(bool estado);
        private delegate void delegado_raspberry(bool estado);
        private delegate void delegado_arduino(bool estado);
        private delegate void delegado_camara(bool estado);
        private delegate void delegado_profTemp(bool estado);
        private delegate void delegado_giroscopio(bool estado);

        public void ActualizarIndicadores(string indicador,bool estado)
        {
            switch(indicador)
            {
                case "linternas":
                    indicador_linternas.Invoke(new delegado_linternas(EncenderLinternas), estado);
                    break;
            }
        }

        void ComprobarDispositivosLocales()
        {
            try
            {
                while (true)
                {
                    control1_conectado = controles.Estado_control(PlayerIndex.One);
                    indicador_control1.Invoke(new delegado_control(Control1_conexion), control1_conectado);

                    control2_conectado = controles.Estado_control(PlayerIndex.Two);
                    indicador_control2.Invoke(new delegado_control(Control2_conexion), control2_conectado);
                    Thread.Sleep(500);
                }
            }
            catch (ThreadInterruptedException)
            {
                log.Info("Hilo Comprobar dispositivos locales detenido");
            }
            
        }

        void ComprobarDispositivosRemotos()
        {
            try
            {
                while (true)
                {
                    //raspberry_conectado = !((socketReceptor.cliente.Poll(1000, SelectMode.SelectRead) && (socketReceptor.cliente.Available == 0)) || !socketReceptor.cliente.Connected);
                    //socketReceptor.servidor.Connected;//socketReceptor.OperadorAND("servidor", (byte)socketReceptor.GetEstado());
                    indicador_raspberry.Invoke(new delegado_raspberry(Raspberry_conexion), raspberry_conectado);

                    arduino_conectado = socketReceptor.OperadorAND("arduino", (byte)socketReceptor.EstadoDispositivos);
                    indicador_arduino.Invoke(new delegado_arduino(Arduino_conexion), arduino_conectado);

                    profTemp_conectado = socketReceptor.OperadorAND("sensores", (byte)socketReceptor.EstadoDispositivos);
                    indicador_profundidad.Invoke(new delegado_profTemp(Sensores_conexion), profTemp_conectado);

                    giroscopio_conectado = socketReceptor.OperadorAND("acelerometro", (byte)socketReceptor.EstadoDispositivos);
                    giroscopio.PintarGiroscopio();
                    Thread.Sleep(500);
                }
            }
            catch (ThreadInterruptedException)
            {
                log.Warn("Hilo Comprobar Dispositivos remotos abortado");
            }
        }

        void Control1_conexion(bool estado)
        {
            if (estado)
            {
                indicador_control1.Text = "Conectado";
                indicador_control1.BackColor = Color.Yellow;
            }
                
            else
            {
                indicador_control1.Text = "Desconectado";
                indicador_control1.BackColor = Color.Red;
            }
                
        }

        void Control2_conexion(bool estado)
        {
            if (estado)
            {
                indicador_control2.Text = "Conectado";
                indicador_control2.BackColor = Color.Yellow;
            }
            else
            {
                indicador_control2.Text = "Desconectado";
                indicador_control2.BackColor = Color.Red;
            }
                
        }

        void Arduino_conexion(bool estado)
        {
            if (estado)
            {
                indicador_arduino.Text = "Conectado";
                indicador_arduino.BackColor = Color.Yellow;
            }
            else
            {
                indicador_arduino.Text = "Desconectado";
                indicador_arduino.BackColor = Color.Red;
            }
                
        }

        void Raspberry_conexion(bool estado)
        {
            if (estado)
            {
                indicador_raspberry.Text = "Conectado";
                indicador_raspberry.BackColor = Color.Yellow;
            }
                
            else
            {
                indicador_raspberry.Text = "Desconectado";
                indicador_raspberry.BackColor = Color.Red;
            }        
        }

        void Sensores_conexion(bool estado)
        {
            indicador_temperatura.ForeColor = Color.Yellow;
            indicador_profundidad.ForeColor = Color.Yellow;
            if (estado)
            {
                indicador_temperatura.BackColor = colorCampos;
                indicador_profundidad.BackColor = colorCampos;
                indicador_temperatura.ForeColor = Color.Yellow;
                indicador_temperatura.Text = string.Format("{0:0.00}", (double)socketReceptor.Temperatura)+ " ºC";
                indicador_profundidad.Text = string.Format("{0:0.00}", (double)socketReceptor.Profundidad)+ " metros";
            }
            else
            {
                indicador_temperatura.BackColor = Color.Gray;
                indicador_profundidad.BackColor = Color.Gray;
                indicador_temperatura.Text = "N/A";
                indicador_profundidad.Text = "N/A";
            }
        }

        /////////////////Finaliza sección de conectividad/////////////
 
        private delegate void delegado_linternas(bool estado);

        
        //---------------------------------------------------------------------------------------------------------
        //La siguiente sección contiene el código de la Raspberry Pi
        //---------------------------------------------------------------------------------------------------------

        private void Camara_conectar_Clic(object sender, EventArgs e)
        {
            try
            {
                Thread obtenerStreamVideo = new Thread(new ThreadStart(Recibir_stream_video1));
                obtenerStreamVideo.Priority = ThreadPriority.Highest;
                camara1_desconectar.Enabled = true;
                camara1_conectar.Enabled = false;

                obtenerStreamVideo.IsBackground = true;
                obtenerStreamVideo.Start();
                recibiendo_video1 = true;
                boton_fotografia1.Enabled = true;
                boton_video1.Enabled = true;
            }
            catch(Exception)
            {
                recibiendo_video1 = false;
            }
        }

        private void Camara_desconectar_Clic(object sender, EventArgs e)
        {
            camara1_desconectar.Enabled = false;
            camara1_conectar.Enabled = true;
            recibiendo_video1 = false;
            //textBox1.Enabled = true;
            if(visorCamara1.IsPlaying)
                visorCamara1.Stop();
            boton_fotografia1.Enabled = false;
            boton_video1.Enabled = false;
        }        

        delegate void delegado_video(string url);
        delegate string delegado_IP(int numeroCamara);

        private string RecibirIP(int numeroCamara)
        {
            switch(numeroCamara)
            {
                case 1:
                    return lista_camaras1.SelectedItem.ToString();
                case 2:
                    return lista_camaras2.SelectedItem.ToString();
                default:
                    return "";
            }
        }

        private void Recibir_stream_video1()
        {
            string ipCamara = lista_camaras1.Invoke(new delegado_IP(RecibirIP),1).ToString();
            visorCamara1.Invoke(new delegado_video(MostrarVideo1), "http://" + ipCamara);
        }
        private void Recibir_stream_video2()
        {
            string ipCamara = lista_camaras2.Invoke(new delegado_IP(RecibirIP), 2).ToString();
            visorCamara2.Invoke(new delegado_video(MostrarVideo2), "http://" + ipCamara);
        }

        private void MostrarVideo1(string URL_video)
        {
            visorCamara1.StartPlay(new Uri(URL_video)); //TODO: configurar TCP o UDP
        }
        private void MostrarVideo2(string URL_video)
        {
            visorCamara2.StartPlay(new Uri(URL_video)); //TODO: configurar TCP o UDP
        }

        private void PintarElementos()
        {
            indicador_control1.BackColor = Color.Red;
            indicador_control2.BackColor = Color.Red;
            indicador_raspberry.BackColor = Color.Red;
            indicador_arduino.BackColor = Color.Red;

            indicador_temperatura.ForeColor = Color.Yellow;
            indicador_profundidad.ForeColor = Color.Yellow;
            indicador_inductivo.ForeColor = Color.Yellow;
            indicador_ph.ForeColor = Color.Yellow;
        }

        private void EncenderLinternas(bool estado)
        {
            if (estado && indicador_linternas.Value < 100)
                indicador_linternas.Value += 20;
            else if (!estado && indicador_linternas.Value > 0)
                indicador_linternas.Value -= 20;
            Thread.Sleep(150);
        }

        private void Boton_fotografia_Click(object sender, EventArgs e) //Método para tomar fotografía y almacenarla en disco
        {
            Bitmap foto = Camaras.CapturarImagen(visorCamara1);
            Camaras.GuardarFotografia(foto);
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            Desconectar();
        }

        private void ComprobarRaspberry()
        {
            while (true)
            {
                try
                {
                    while (true)
                    {
                        raspberry_conectado = socketConector.Ping(direccion_ip_texto.Text);
                        Thread.Sleep(200);
                    }
                }
                catch (ThreadInterruptedException) { log.Warn("Hilo ComprobarRaspberry abortado"); }
                catch (Exception) { }
            }   
        }

        private void Boton_Conectar_Click(object sender, EventArgs e)
        {
            if (!socketConector.conexionRealizada)
            {
                try
                {
                    if (socketConector.Conectar(direccion_ip_texto.Text))
                    {
                        socketReceptor.Conectar(direccion_ip_texto.Text, 7001);
                        SolicitarDatos();
                        giroscopioToolStripMenuItem.Enabled = true;
                        visorDeCámaraToolStripMenuItem.Enabled = true;
                        camara1_conectar.Enabled = true; //Habilita la posibilidad de iniciar recepción de video.
                        direccion_ip_texto.Enabled = false;
                        puerto_texto.Enabled = false;

                        camara2_conectar.Enabled = true;

                        boton_Conectar.Text = "Desconectar";
                        if(!coleccionThreads.ContainsKey(ListaThreads.verifConectividad))
                            CrearThreads(ListaThreads.verifConectividad);
                        CrearThreads(ListaThreads.dispositivosRemotos);
                        CrearThreads(ListaThreads.actualizarControles);
                        CrearThreads(ListaThreads.conexionConRaspberry);
                    }
                    else
                        MessageBox.Show("No se pudo establecer la conexión remota", "Error de conexión",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (SocketException)
                {
                    log.Error("No se pudo establecer la conexión");
                    MessageBox.Show("No se pudo establecer la conexión remota", "Error de conexión",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea desconectar?","Confirmación",MessageBoxButtons.YesNo);
                if(confirmacion == DialogResult.Yes)
                {
                    boton_Conectar.Text = "¡Conectar!";
                    Desconectar();
                }
            }
        }

        private void DetenerRecepcionVideo()
        {
            if(visorCamara1.IsPlaying){
                visorCamara1.Stop();
                //grabandoVideo1 = false;
                recibiendo_video1 = false;
                boton_video1.Image = EstacionControl.Properties.Resources.video_1_micro;
            }
            if (visorCamara2.IsPlaying){
                visorCamara2.Stop();
                //grabandoVideo2 = false;
                recibiendo_video2 = false;
                boton_video2.Image = EstacionControl.Properties.Resources.video_1_micro;
            }
        }

        private void Desconectar()
        {
            socketConector.CerrarConexion();
            socketReceptor.CerrarConexion();
            giroscopioToolStripMenuItem.Enabled = true;
            camara1_conectar.Enabled = false;
            direccion_ip_texto.Enabled = true;
            puerto_texto.Enabled = true;

            camara2_conectar.Enabled = false;
            foreach(var hilo in coleccionThreads)
            {
                if (hilo.Value.IsAlive)
                {
                    log.Info("------Hilo " + hilo.Key + " abortado");
                    hilo.Value.Abort();
                }           
            }
            coleccionThreads.Clear();
            DetenerRecepcionVideo();
            
            socketConector.conexionRealizada = false;
        }

        private void SolicitarDatos()
        {
            socketReceptor.SolicitarRecepcion();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ventana = new AcercaDe();
            ventana.ShowDialog();
        }

        private void Boton_generarQR_Click(object sender, EventArgs e)
        {
            CodigoQR qr = new CodigoQR(lista_camaras1.SelectedItem.ToString());
            qr.ShowDialog();
        }

        private void giroscopioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giroscopio giro = new Giroscopio(socketConector);
            giro.Show();
        }

        private void abrirCarpetaDeFotografíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", rutaCapturas);
        }

        private void botonReconociento_Click(object sender, EventArgs e)
        {
            Stopwatch cronometroRendimiento = new Stopwatch();
            ClasificacionFiguras clasificador = new ClasificacionFiguras();
            
            Bitmap bitmap = Camaras.CapturarImagen(visorCamara1);
            if(bitmap != null)
            {
                cronometroRendimiento.Start();
                bitmap = BitMaps.DrawAsNegative(bitmap);
                EspeciesReconocidas especiesReconocidas = new EspeciesReconocidas(clasificador.ProcesarImagen(bitmap),cantidadFiguras);
                cronometroRendimiento.Stop();
                especiesReconocidas.ShowDialog();
                log.Info("Tiempo de identificación: " + (double)cronometroRendimiento.ElapsedMilliseconds / 1000);
            }
        }

        public static int[] cantidadFiguras = new int[] { 0, 0, 0, 0};//circulo,cuadrado,rectangulo,triangulo

        private void boton_video_Click(object sender, EventArgs e) //Grabación de video recibido en Visor #1
        {
            log.Info("Grabando video");
            //Thread capturarVideo = new Thread(new ThreadStart(GrabarVideo)) { IsBackground = true };
            if (!grabandoVideo1){
                
                boton_video1.Image = EstacionControl.Properties.Resources.stop_micro;
                grabandoVideo1 = true;
                CrearThreads(ListaThreads.capturarVideo);
            }else{
                boton_video1.Image = EstacionControl.Properties.Resources.video_1_micro;
                grabandoVideo1 = false;
                coleccionThreads[ListaThreads.capturarVideo].Abort();
            }
        }

        private void GrabarVideo()
        {
            AVIWriter grabadorVideo = new AVIWriter();
            try
            {
                Bitmap imagen = Camaras.CapturarImagen(visorCamara1);
                DateTime Hoy = DateTime.Now;
                string fecha_actual = Hoy.ToString("dd-MM-yyyy HH-mm-ss");
                grabadorVideo.Open(rutaCapturas + "\\video_" + fecha_actual + ".avi", imagen.Width, imagen.Height);
                while (true)
                {
                    if (grabandoVideo1)
                    {
                        grabadorVideo.AddFrame(Camaras.CapturarImagen(visorCamara1));
                        Thread.Sleep(50);
                    }
                    else
                        break;
                }
                grabadorVideo.Close();
            }
            catch (Exception)
            {
                grabadorVideo.Close();
            }
        }

        private void configuraciónDeCámarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CamaraPanel panelCamaras = new CamaraPanel();
            panelCamaras.ShowDialog();
        }

        private void camara2_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                Thread obtenerStreamVideo = new Thread(new ThreadStart(Recibir_stream_video2));
                camara2_desconectar.Enabled = true;
                camara2_conectar.Enabled = false;

                obtenerStreamVideo.IsBackground = true;
                obtenerStreamVideo.Priority = ThreadPriority.Highest;
                obtenerStreamVideo.Start();
                recibiendo_video2 = true;
                boton_fotografia2.Enabled = true;
                boton_video2.Enabled = true;
            }
            catch (Exception)
            {
                recibiendo_video2 = false;
            }
        }

        private void camara2_desconectar_Click(object sender, EventArgs e)
        {
            camara2_desconectar.Enabled = false;
            camara2_conectar.Enabled = true;
            recibiendo_video2 = false;
            if (visorCamara2.IsPlaying)
                visorCamara2.Stop();
            boton_fotografia2.Enabled = false;
            boton_video2.Enabled = false;
        }

        private void visorDeCámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorCamara visorCamara = new VisorCamara();
            visorCamara.Show();
        }

        private void calcularVolumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MisionCanon misionCanon = new MisionCanon();
            misionCanon.ShowDialog();
        }

        private void diafragmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!diafragmaAbierto){    
                MessageBox.Show("Abriendo diafragma...","Diafragma");
                diafragmaAbierto = true;
                diafragmaToolStripMenuItem.Text = "Cerrar diafragma";
            }else{
                MessageBox.Show("Cerrando diafragma...", "Diafragma");
                diafragmaAbierto = false;
                diafragmaToolStripMenuItem.Text = "Abrir diafragma";
            }
            socketConector.EnviarDatos((Byte)BotonesXBOX.Comando, (float)Comandos.AbrirDiafragma);
        }

        private void boton_Desplegar_MiniROV_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            if(!miniROVDesplegado)
                confirmacion = MessageBox.Show("¿Desplegar MiniROV?", "Confirmación", MessageBoxButtons.YesNo);
            else
                confirmacion = MessageBox.Show("¿Desactivar MiniROV?", "Confirmación", MessageBoxButtons.YesNo);
            if(confirmacion==DialogResult.Yes)
            {
                if (!miniROVDesplegado)
                {
                    socketMiniROV = new ConectividadRemota(campo_ip_MiniROV.Text);
                    try
                    {
                        indicador_mini_desplegado.Text = "Desplegado";
                        indicador_mini_desplegado.ForeColor = Color.Yellow;
                        campo_ip_MiniROV.Enabled = false;
                        campo_puerto_MiniROV.Enabled = false;
                        miniROVDesplegado = true;
                    }
                    catch (Exception)
                    {
                        controles.miniROVDesplegado = false;
                        miniROVDesplegado = false;
                        MessageBox.Show("No se pudo establecer la conexión con la IP destino");
                    }
                }
                else
                {
                    indicador_mini_desplegado.Text = "No Desplegado";
                    indicador_mini_desplegado.ForeColor = Color.Red;
                    campo_ip_MiniROV.Enabled = true;
                    campo_puerto_MiniROV.Enabled = true;
                    miniROVDesplegado = false;
                }
            }
        }

        private void CrearThreads(string nombreThread)
        {
            switch(nombreThread)
            {
                case ListaThreads.actualizarControles:
                    //Hilo para manejar el control de XBOX ONE
                    Thread actualizarControles = new Thread(new ThreadStart(controles.ActualizarEstadoOrdenes)) { IsBackground = true };
                    coleccionThreads.Add(ListaThreads.actualizarControles, actualizarControles);
                    actualizarControles.Start();
                    log.Info("-----------Hilo Actualizar Controles------");
                    break;
                case ListaThreads.dispositivosRemotos:
                    Thread dispositivosRemotos = new Thread(new ThreadStart(ComprobarDispositivosRemotos)) { IsBackground = true };
                    //dispositivosRemotos.Priority = ThreadPriority.AboveNormal;
                    coleccionThreads.Add(ListaThreads.dispositivosRemotos, dispositivosRemotos);
                    log.Info("-----------Hilo Dispositivos remotos------");
                    dispositivosRemotos.Start();
                    break;
                case ListaThreads.verifConectividad:
                    //Hilo de verificación de comunicación de dispositivos periféricos locales
                    Thread verifConectividad = new Thread(new ThreadStart(ComprobarDispositivosLocales)) { IsBackground = true };
                    coleccionThreads.Add(ListaThreads.verifConectividad, verifConectividad);
                    log.Info("-----------Hilo Verificar conectividad------");
                    verifConectividad.Start();
                    break;
                case ListaThreads.capturarVideo:
                    Thread capturarVideo = new Thread(new ThreadStart(GrabarVideo)) { IsBackground = true };
                    coleccionThreads.Add(ListaThreads.capturarVideo, capturarVideo);
                    log.Info("-----------Hilo Capturar video------");
                    capturarVideo.Start();
                    break;
                case ListaThreads.conexionConRaspberry:
                    Thread conexionConRaspberry = new Thread(new ThreadStart(ComprobarRaspberry)) { IsBackground = true }; //Verifica 
                    //conexionConRaspberry.Priority = ThreadPriority.Highest;
                    coleccionThreads.Add(ListaThreads.conexionConRaspberry, conexionConRaspberry);
                    log.Info("-----------Hilo conexion con Raspberry------");
                    conexionConRaspberry.Start();
                    break;
            }
        }

        private void modoVictoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.la_cucaracha);
            soundPlayer.Play();
        }
    }

    class ListaThreads
    {
        public const string actualizarControles = "actualizarControles";
        public const string dispositivosRemotos = "dispositivosRemotos";
        public const string verifConectividad = "verifConectividad";
        public const string capturarVideo = "capturarVideo";
        public const string conexionConRaspberry = "conexionConRaspberry";
    }
}