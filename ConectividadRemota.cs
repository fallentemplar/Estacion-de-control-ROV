using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using log4net;

namespace EstacionControl
{
    class ConectividadRemota
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string direccionIP;
        public int puerto;
        public Socket cliente;
        public Socket servidor;
        private byte[] dato;

        //Variables de recepción de datos
        public int EstadoDispositivos { get; set; }
        public float Profundidad { get; set; }
        public float Temperatura { get; set; }
        public float AnguloX { get; set; }
        public float AnguloY { get; set; }

        //Bytes de comparación de dispositivos
        const byte byteServidor = 0b_0000_0001;
        const byte byteArduino = 0b_0000_0010;
        const byte byteTempProf = 0b_0000_011;
        const byte byteAcelerometro = 0b_0000_0100;

        public bool conexionRealizada;

        public ConectividadRemota(string direccionIPDestino)
        {
            direccionIP = direccionIPDestino;
            this.puerto = 7000;
        }

        public ConectividadRemota(string direccionIPDestino,int puertoDestino)
        {
            direccionIP = direccionIPDestino;
            this.puerto = puertoDestino;
        }


        public bool Estado_Arduino()
        {
            return true;
        }

        public bool Ping(string ipDestino)
        {
            if (ipDestino.Length == 0)
                return false;
            else
            {
                Ping p = new Ping();
                PingReply r;
                try{
                    r = p.Send(ipDestino);
                    return (r.Status == IPStatus.Success);
                }catch{
                    return false;
                }
            }
        }

        /// <summary>
        /// Método para conectar a un host remoto
        /// Usar para socket cliente
        /// </summary>
        /// <param name="ipDestino"></param>
        /// <returns></returns>
        public bool Conectar(string ipDestino) 
        {
            direccionIP = ipDestino;
            cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            conexionRealizada = false;
            try
            {
                cliente.Connect(direccionIP, puerto);
                if (cliente.Connected)
                {
                    conexionRealizada = true;
                    log.Info("Conexión establecida");
                }
            }
            catch (SocketException)
            {
                log.Error("No se pudo establecer la conexión");
                conexionRealizada = false;
            }
            return conexionRealizada;
        }
        
        /// <summary>
        /// Método para conectar a un host remoto.
        /// Usar para socket servidor
        /// </summary>
        /// <param name="ipDestino"></param>
        /// <param name="puertoDestino"></param>
        /// <returns></returns>
        public bool Conectar(string ipDestino,int puertoDestino)
        {
            direccionIP = ipDestino;
            servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            conexionRealizada = false;
            try
            {
                servidor.Connect(direccionIP, puertoDestino);
                if (servidor.Connected)
                {
                    conexionRealizada = true;
                    log.Info("Conexión establecida");
                    log.Debug("Socket creado");
                }
            }
            catch (SocketException)
            {
                log.Error("No se pudo establecer la conexión");
                conexionRealizada = false;
            }
            return conexionRealizada;
        }
        
        /// <summary>
        /// Método para enviar la información de los botones del control de XBOX a Raspberry
        /// Envía cada boton de manera individual cuando es presionado
        /// dato[0] es el identificador del boton presionado
        /// dato[1 - 4] es el valor del boton pulsado, convertido de un flotante a una cadena de bytes
        /// </summary>
        /// <param name="boton"></param>
        /// <param name="valor"></param>
        public void EnviarDatos(byte boton, float valor)
        {
            byte[] valorEnBytes= BitConverter.GetBytes(valor);
            dato = new byte[5];
            dato[0] = boton;
            dato[1] = valorEnBytes[0];
            dato[2] = valorEnBytes[1];
            dato[3] = valorEnBytes[2];
            dato[4] = valorEnBytes[3];
            try{
                cliente.Send(dato);
            }catch{
                log.Warn("No fue posible enviar datos");
            }
        }

        public void CerrarConexion()
        {
            if(cliente!=null && servidor!=null)
            {
                try{
                    cliente.Shutdown(SocketShutdown.Both);
                    servidor.Shutdown(SocketShutdown.Both);
                    cliente.Disconnect(true);
                    servidor.Disconnect(true);
                    cliente.Close();
                    servidor.Close();
                }catch (NullReferenceException){
                    log.Error("La conexión no ha sido inicializada, por tanto, no puede ser cerrada");
                }catch (SocketException){
                    log.Error("La conexión no ha sido inicializada, por tanto, no puede ser cerrada");
                }
            }
        }

        public void SolicitarRecepcion()
        {
            Thread hiloReceptor = new Thread(new ThreadStart(RecepcionDatos))
            {
                IsBackground = true
            };
            hiloReceptor.Start();
        }

        public void RecepcionDatos()
        {
            log.Debug("Iniciando recepción de datos en clase ConectividadRemota");
            var buffer = new Byte[25];
            while (true)
            {
                while (servidor.Available > 0)
                {   
                    var info = servidor.Receive(buffer);
                }
                EstadoDispositivos = (int)buffer[0];
                Profundidad = BitConverter.ToSingle(FragmentarArrayBytes(buffer, 9), 0);
                Temperatura = BitConverter.ToSingle(FragmentarArrayBytes(buffer, 13), 0);
                AnguloX = BitConverter.ToSingle(FragmentarArrayBytes(buffer, 17), 0);
                AnguloY = BitConverter.ToSingle(FragmentarArrayBytes(buffer, 21), 0);

                Thread.Sleep(500);
            }
        }

        public byte[] FragmentarArrayBytes(byte[] array, int indice)
        {
            byte[] nuevo = new byte[4];
            Buffer.BlockCopy(array, indice, nuevo, 0, 4);
            return nuevo;
        }

        public bool OperadorAND(string dispositivo, byte arreglo) //para ver si están conectados los dispositivos
        {
            switch(dispositivo)
            {
                case "servidor":
                    if ((arreglo & byteServidor) == byteServidor) return true;
                    break;
                case "arduino":
                    if ((arreglo & byteArduino) == byteArduino) return true;
                    break;
                case "sensores":
                    if ((arreglo & byteTempProf) == byteTempProf) return true;
                    break;
                case "acelerometro":
                    if ((arreglo & byteAcelerometro) == byteAcelerometro) return true;
                    break;
                default:
                    return false;
            }
            return false;
        }
    }

    public enum Comandos
    {
        AbrirDiafragma=4,
    }

}
