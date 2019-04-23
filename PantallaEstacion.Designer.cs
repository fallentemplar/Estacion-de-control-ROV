namespace EstacionControl
{
    partial class PantallaEstacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaEstacion));
            this.indicador_control1 = new System.Windows.Forms.TextBox();
            this.camera_groupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lista_camaras1 = new System.Windows.Forms.ComboBox();
            this.botonReconociento = new System.Windows.Forms.Button();
            this.visorCamara1 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.boton_generarQR = new System.Windows.Forms.Button();
            this.boton_video1 = new System.Windows.Forms.Button();
            this.boton_fotografia1 = new System.Windows.Forms.Button();
            this.camara1_desconectar = new System.Windows.Forms.Button();
            this.camara1_conectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raspberry_logo = new System.Windows.Forms.PictureBox();
            this.arduino_logo = new System.Windows.Forms.PictureBox();
            this.control2_logo = new System.Windows.Forms.PictureBox();
            this.control1_logo = new System.Windows.Forms.PictureBox();
            this.indicador_control2 = new System.Windows.Forms.TextBox();
            this.indicador_arduino = new System.Windows.Forms.TextBox();
            this.indicador_raspberry = new System.Windows.Forms.TextBox();
            this.herramientasSensores = new System.Windows.Forms.GroupBox();
            this.indicador_inductivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.indicador_ph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.indicador_linternas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.indicador_profundidad = new System.Windows.Forms.TextBox();
            this.indicador_temperatura = new System.Windows.Forms.TextBox();
            this.etiqueta_profundidad = new System.Windows.Forms.Label();
            this.etiqueta_temperatura = new System.Windows.Forms.Label();
            this.menuCinta = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaDeFotografíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giroscopioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDeCámarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorDeCámaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularVolumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoCamaraSecundaria = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_video2 = new System.Windows.Forms.Button();
            this.camara2_conectar = new System.Windows.Forms.Button();
            this.boton_fotografia2 = new System.Windows.Forms.Button();
            this.lista_camaras2 = new System.Windows.Forms.ComboBox();
            this.camara2_desconectar = new System.Windows.Forms.Button();
            this.visorCamara2 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.grupo_raspberry = new System.Windows.Forms.GroupBox();
            this.boton_Conectar = new System.Windows.Forms.Button();
            this.puerto_texto = new System.Windows.Forms.TextBox();
            this.direccion_ip_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camera_ip_label = new System.Windows.Forms.Label();
            this.burbuja_informacion = new System.Windows.Forms.ToolTip(this.components);
            this.grupo_minirov = new System.Windows.Forms.GroupBox();
            this.indicador_mini_luces = new System.Windows.Forms.ProgressBar();
            this.indicador_mini_desplegado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.camera_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspberry_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduino_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control2_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control1_logo)).BeginInit();
            this.herramientasSensores.SuspendLayout();
            this.menuCinta.SuspendLayout();
            this.grupoCamaraSecundaria.SuspendLayout();
            this.grupo_raspberry.SuspendLayout();
            this.grupo_minirov.SuspendLayout();
            this.SuspendLayout();
            // 
            // indicador_control1
            // 
            this.indicador_control1.Enabled = false;
            this.indicador_control1.Location = new System.Drawing.Point(51, 22);
            this.indicador_control1.Name = "indicador_control1";
            this.indicador_control1.Size = new System.Drawing.Size(101, 20);
            this.indicador_control1.TabIndex = 0;
            this.indicador_control1.Text = "Desconectado";
            // 
            // camera_groupBox
            // 
            this.camera_groupBox.Controls.Add(this.label6);
            this.camera_groupBox.Controls.Add(this.lista_camaras1);
            this.camera_groupBox.Controls.Add(this.botonReconociento);
            this.camera_groupBox.Controls.Add(this.visorCamara1);
            this.camera_groupBox.Controls.Add(this.boton_generarQR);
            this.camera_groupBox.Controls.Add(this.boton_video1);
            this.camera_groupBox.Controls.Add(this.boton_fotografia1);
            this.camera_groupBox.Controls.Add(this.camara1_desconectar);
            this.camera_groupBox.Controls.Add(this.camara1_conectar);
            this.camera_groupBox.Location = new System.Drawing.Point(524, 27);
            this.camera_groupBox.Name = "camera_groupBox";
            this.camera_groupBox.Size = new System.Drawing.Size(701, 644);
            this.camera_groupBox.TabIndex = 60;
            this.camera_groupBox.TabStop = false;
            this.camera_groupBox.Text = "Cámara principal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "IP cámara 1";
            // 
            // lista_camaras1
            // 
            this.lista_camaras1.FormattingEnabled = true;
            this.lista_camaras1.Location = new System.Drawing.Point(76, 601);
            this.lista_camaras1.Name = "lista_camaras1";
            this.lista_camaras1.Size = new System.Drawing.Size(121, 21);
            this.lista_camaras1.TabIndex = 73;
            // 
            // botonReconociento
            // 
            this.botonReconociento.Location = new System.Drawing.Point(620, 583);
            this.botonReconociento.Name = "botonReconociento";
            this.botonReconociento.Size = new System.Drawing.Size(75, 61);
            this.botonReconociento.TabIndex = 33;
            this.botonReconociento.Text = "Identificar Especies";
            this.botonReconociento.UseVisualStyleBackColor = true;
            this.botonReconociento.Click += new System.EventHandler(this.botonReconociento_Click);
            // 
            // visorCamara1
            // 
            this.visorCamara1.AutoSize = true;
            this.visorCamara1.BackgroundImage = global::EstacionControl.Properties.Resources.tmmx_nuevo;
            this.visorCamara1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visorCamara1.Location = new System.Drawing.Point(6, 17);
            this.visorCamara1.Name = "visorCamara1";
            this.visorCamara1.Size = new System.Drawing.Size(686, 557);
            this.visorCamara1.TabIndex = 32;
            // 
            // boton_generarQR
            // 
            this.boton_generarQR.Location = new System.Drawing.Point(539, 583);
            this.boton_generarQR.Name = "boton_generarQR";
            this.boton_generarQR.Size = new System.Drawing.Size(75, 23);
            this.boton_generarQR.TabIndex = 31;
            this.boton_generarQR.Text = "Generar QR";
            this.boton_generarQR.UseVisualStyleBackColor = true;
            this.boton_generarQR.Click += new System.EventHandler(this.Boton_generarQR_Click);
            // 
            // boton_video1
            // 
            this.boton_video1.Enabled = false;
            this.boton_video1.Image = global::EstacionControl.Properties.Resources.video_1_micro;
            this.boton_video1.Location = new System.Drawing.Point(409, 587);
            this.boton_video1.Name = "boton_video1";
            this.boton_video1.Size = new System.Drawing.Size(48, 47);
            this.boton_video1.TabIndex = 30;
            this.boton_video1.UseVisualStyleBackColor = true;
            this.boton_video1.Click += new System.EventHandler(this.boton_video_Click);
            // 
            // boton_fotografia1
            // 
            this.boton_fotografia1.Enabled = false;
            this.boton_fotografia1.Image = global::EstacionControl.Properties.Resources.foto_micro;
            this.boton_fotografia1.Location = new System.Drawing.Point(348, 587);
            this.boton_fotografia1.Name = "boton_fotografia1";
            this.boton_fotografia1.Size = new System.Drawing.Size(55, 47);
            this.boton_fotografia1.TabIndex = 29;
            this.boton_fotografia1.UseVisualStyleBackColor = true;
            this.boton_fotografia1.Click += new System.EventHandler(this.Boton_fotografia_Click);
            // 
            // camara1_desconectar
            // 
            this.camara1_desconectar.Enabled = false;
            this.camara1_desconectar.Image = global::EstacionControl.Properties.Resources.detener_micro;
            this.camara1_desconectar.Location = new System.Drawing.Point(272, 587);
            this.camara1_desconectar.Name = "camara1_desconectar";
            this.camara1_desconectar.Size = new System.Drawing.Size(70, 47);
            this.camara1_desconectar.TabIndex = 24;
            this.camara1_desconectar.UseVisualStyleBackColor = true;
            this.camara1_desconectar.Click += new System.EventHandler(this.Camara_desconectar_Clic);
            // 
            // camara1_conectar
            // 
            this.camara1_conectar.Enabled = false;
            this.camara1_conectar.Image = global::EstacionControl.Properties.Resources.play_1_micro;
            this.camara1_conectar.Location = new System.Drawing.Point(204, 587);
            this.camara1_conectar.Name = "camara1_conectar";
            this.camara1_conectar.Size = new System.Drawing.Size(62, 47);
            this.camara1_conectar.TabIndex = 23;
            this.camara1_conectar.UseVisualStyleBackColor = true;
            this.camara1_conectar.Click += new System.EventHandler(this.Camara_conectar_Clic);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raspberry_logo);
            this.groupBox1.Controls.Add(this.arduino_logo);
            this.groupBox1.Controls.Add(this.control2_logo);
            this.groupBox1.Controls.Add(this.control1_logo);
            this.groupBox1.Controls.Add(this.indicador_control2);
            this.groupBox1.Controls.Add(this.indicador_arduino);
            this.groupBox1.Controls.Add(this.indicador_raspberry);
            this.groupBox1.Controls.Add(this.indicador_control1);
            this.groupBox1.Location = new System.Drawing.Point(162, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 113);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectividad";
            // 
            // raspberry_logo
            // 
            this.raspberry_logo.Image = global::EstacionControl.Properties.Resources.raspberry_micro;
            this.raspberry_logo.Location = new System.Drawing.Point(6, 63);
            this.raspberry_logo.Name = "raspberry_logo";
            this.raspberry_logo.Size = new System.Drawing.Size(40, 40);
            this.raspberry_logo.TabIndex = 10;
            this.raspberry_logo.TabStop = false;
            // 
            // arduino_logo
            // 
            this.arduino_logo.Image = global::EstacionControl.Properties.Resources.arduino_micro;
            this.arduino_logo.Location = new System.Drawing.Point(203, 63);
            this.arduino_logo.Name = "arduino_logo";
            this.arduino_logo.Size = new System.Drawing.Size(39, 40);
            this.arduino_logo.TabIndex = 9;
            this.arduino_logo.TabStop = false;
            // 
            // control2_logo
            // 
            this.control2_logo.Image = global::EstacionControl.Properties.Resources.xbox_micro;
            this.control2_logo.Location = new System.Drawing.Point(203, 17);
            this.control2_logo.Name = "control2_logo";
            this.control2_logo.Size = new System.Drawing.Size(39, 40);
            this.control2_logo.TabIndex = 8;
            this.control2_logo.TabStop = false;
            // 
            // control1_logo
            // 
            this.control1_logo.Image = global::EstacionControl.Properties.Resources.xbox_micro;
            this.control1_logo.Location = new System.Drawing.Point(6, 17);
            this.control1_logo.Name = "control1_logo";
            this.control1_logo.Size = new System.Drawing.Size(39, 40);
            this.control1_logo.TabIndex = 7;
            this.control1_logo.TabStop = false;
            // 
            // indicador_control2
            // 
            this.indicador_control2.Enabled = false;
            this.indicador_control2.Location = new System.Drawing.Point(248, 22);
            this.indicador_control2.Name = "indicador_control2";
            this.indicador_control2.Size = new System.Drawing.Size(100, 20);
            this.indicador_control2.TabIndex = 6;
            this.indicador_control2.Text = "Desconectado";
            // 
            // indicador_arduino
            // 
            this.indicador_arduino.Enabled = false;
            this.indicador_arduino.Location = new System.Drawing.Point(248, 73);
            this.indicador_arduino.Name = "indicador_arduino";
            this.indicador_arduino.Size = new System.Drawing.Size(100, 20);
            this.indicador_arduino.TabIndex = 5;
            this.indicador_arduino.Text = "Desconectado";
            // 
            // indicador_raspberry
            // 
            this.indicador_raspberry.Enabled = false;
            this.indicador_raspberry.Location = new System.Drawing.Point(52, 73);
            this.indicador_raspberry.Name = "indicador_raspberry";
            this.indicador_raspberry.Size = new System.Drawing.Size(100, 20);
            this.indicador_raspberry.TabIndex = 3;
            this.indicador_raspberry.Text = "Desconectado";
            // 
            // herramientasSensores
            // 
            this.herramientasSensores.Controls.Add(this.indicador_inductivo);
            this.herramientasSensores.Controls.Add(this.label3);
            this.herramientasSensores.Controls.Add(this.indicador_ph);
            this.herramientasSensores.Controls.Add(this.label2);
            this.herramientasSensores.Controls.Add(this.indicador_linternas);
            this.herramientasSensores.Controls.Add(this.label4);
            this.herramientasSensores.Controls.Add(this.indicador_profundidad);
            this.herramientasSensores.Controls.Add(this.indicador_temperatura);
            this.herramientasSensores.Controls.Add(this.etiqueta_profundidad);
            this.herramientasSensores.Controls.Add(this.etiqueta_temperatura);
            this.herramientasSensores.Location = new System.Drawing.Point(12, 146);
            this.herramientasSensores.Name = "herramientasSensores";
            this.herramientasSensores.Size = new System.Drawing.Size(506, 80);
            this.herramientasSensores.TabIndex = 62;
            this.herramientasSensores.TabStop = false;
            this.herramientasSensores.Text = "Herramientas y sensores";
            // 
            // indicador_inductivo
            // 
            this.indicador_inductivo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.indicador_inductivo.Enabled = false;
            this.indicador_inductivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicador_inductivo.ForeColor = System.Drawing.Color.Yellow;
            this.indicador_inductivo.Location = new System.Drawing.Point(269, 46);
            this.indicador_inductivo.Name = "indicador_inductivo";
            this.indicador_inductivo.Size = new System.Drawing.Size(100, 20);
            this.indicador_inductivo.TabIndex = 9;
            this.indicador_inductivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inductivo";
            // 
            // indicador_ph
            // 
            this.indicador_ph.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.indicador_ph.Enabled = false;
            this.indicador_ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicador_ph.ForeColor = System.Drawing.Color.Yellow;
            this.indicador_ph.Location = new System.Drawing.Point(269, 19);
            this.indicador_ph.Name = "indicador_ph";
            this.indicador_ph.Size = new System.Drawing.Size(100, 20);
            this.indicador_ph.TabIndex = 7;
            this.indicador_ph.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ph";
            // 
            // indicador_linternas
            // 
            this.indicador_linternas.BackColor = System.Drawing.Color.Gray;
            this.indicador_linternas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicador_linternas.Location = new System.Drawing.Point(393, 46);
            this.indicador_linternas.Name = "indicador_linternas";
            this.indicador_linternas.Size = new System.Drawing.Size(100, 20);
            this.indicador_linternas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Linternas";
            // 
            // indicador_profundidad
            // 
            this.indicador_profundidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.indicador_profundidad.Enabled = false;
            this.indicador_profundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicador_profundidad.ForeColor = System.Drawing.Color.Yellow;
            this.indicador_profundidad.Location = new System.Drawing.Point(100, 46);
            this.indicador_profundidad.Name = "indicador_profundidad";
            this.indicador_profundidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.indicador_profundidad.Size = new System.Drawing.Size(100, 20);
            this.indicador_profundidad.TabIndex = 3;
            this.indicador_profundidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // indicador_temperatura
            // 
            this.indicador_temperatura.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.indicador_temperatura.Enabled = false;
            this.indicador_temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicador_temperatura.ForeColor = System.Drawing.Color.Yellow;
            this.indicador_temperatura.Location = new System.Drawing.Point(100, 20);
            this.indicador_temperatura.Name = "indicador_temperatura";
            this.indicador_temperatura.Size = new System.Drawing.Size(100, 20);
            this.indicador_temperatura.TabIndex = 2;
            this.indicador_temperatura.Text = "0.0 ºC";
            this.indicador_temperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // etiqueta_profundidad
            // 
            this.etiqueta_profundidad.AutoSize = true;
            this.etiqueta_profundidad.Location = new System.Drawing.Point(10, 50);
            this.etiqueta_profundidad.Name = "etiqueta_profundidad";
            this.etiqueta_profundidad.Size = new System.Drawing.Size(64, 13);
            this.etiqueta_profundidad.TabIndex = 1;
            this.etiqueta_profundidad.Text = "Profundidad";
            // 
            // etiqueta_temperatura
            // 
            this.etiqueta_temperatura.AutoSize = true;
            this.etiqueta_temperatura.Location = new System.Drawing.Point(10, 23);
            this.etiqueta_temperatura.Name = "etiqueta_temperatura";
            this.etiqueta_temperatura.Size = new System.Drawing.Size(67, 13);
            this.etiqueta_temperatura.TabIndex = 0;
            this.etiqueta_temperatura.Text = "Temperatura";
            // 
            // menuCinta
            // 
            this.menuCinta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.misionesToolStripMenuItem});
            this.menuCinta.Location = new System.Drawing.Point(0, 0);
            this.menuCinta.Name = "menuCinta";
            this.menuCinta.Size = new System.Drawing.Size(1268, 24);
            this.menuCinta.TabIndex = 68;
            this.menuCinta.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCarpetaDeFotografíasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirCarpetaDeFotografíasToolStripMenuItem
            // 
            this.abrirCarpetaDeFotografíasToolStripMenuItem.Name = "abrirCarpetaDeFotografíasToolStripMenuItem";
            this.abrirCarpetaDeFotografíasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.abrirCarpetaDeFotografíasToolStripMenuItem.Text = "Abrir carpeta de fotografías";
            this.abrirCarpetaDeFotografíasToolStripMenuItem.Click += new System.EventHandler(this.abrirCarpetaDeFotografíasToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giroscopioToolStripMenuItem,
            this.configuraciónDeCámarasToolStripMenuItem,
            this.visorDeCámaraToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // giroscopioToolStripMenuItem
            // 
            this.giroscopioToolStripMenuItem.Name = "giroscopioToolStripMenuItem";
            this.giroscopioToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.giroscopioToolStripMenuItem.Text = "Giroscopio";
            this.giroscopioToolStripMenuItem.Click += new System.EventHandler(this.giroscopioToolStripMenuItem_Click);
            // 
            // configuraciónDeCámarasToolStripMenuItem
            // 
            this.configuraciónDeCámarasToolStripMenuItem.Name = "configuraciónDeCámarasToolStripMenuItem";
            this.configuraciónDeCámarasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.configuraciónDeCámarasToolStripMenuItem.Text = "Configuración de cámaras";
            this.configuraciónDeCámarasToolStripMenuItem.Click += new System.EventHandler(this.configuraciónDeCámarasToolStripMenuItem_Click);
            // 
            // visorDeCámaraToolStripMenuItem
            // 
            this.visorDeCámaraToolStripMenuItem.Name = "visorDeCámaraToolStripMenuItem";
            this.visorDeCámaraToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.visorDeCámaraToolStripMenuItem.Text = "Visor de cámara";
            this.visorDeCámaraToolStripMenuItem.Click += new System.EventHandler(this.visorDeCámaraToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualTécnicoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // manualTécnicoToolStripMenuItem
            // 
            this.manualTécnicoToolStripMenuItem.Name = "manualTécnicoToolStripMenuItem";
            this.manualTécnicoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.manualTécnicoToolStripMenuItem.Text = "Manual Técnico";
            // 
            // misionesToolStripMenuItem
            // 
            this.misionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canonToolStripMenuItem});
            this.misionesToolStripMenuItem.Name = "misionesToolStripMenuItem";
            this.misionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.misionesToolStripMenuItem.Text = "Misiones";
            // 
            // canonToolStripMenuItem
            // 
            this.canonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularVolumenToolStripMenuItem});
            this.canonToolStripMenuItem.Name = "canonToolStripMenuItem";
            this.canonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.canonToolStripMenuItem.Text = "Cañón";
            // 
            // calcularVolumenToolStripMenuItem
            // 
            this.calcularVolumenToolStripMenuItem.Name = "calcularVolumenToolStripMenuItem";
            this.calcularVolumenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.calcularVolumenToolStripMenuItem.Text = "Calcular Volúmen";
            this.calcularVolumenToolStripMenuItem.Click += new System.EventHandler(this.calcularVolumenToolStripMenuItem_Click);
            // 
            // grupoCamaraSecundaria
            // 
            this.grupoCamaraSecundaria.Controls.Add(this.label5);
            this.grupoCamaraSecundaria.Controls.Add(this.boton_video2);
            this.grupoCamaraSecundaria.Controls.Add(this.camara2_conectar);
            this.grupoCamaraSecundaria.Controls.Add(this.boton_fotografia2);
            this.grupoCamaraSecundaria.Controls.Add(this.lista_camaras2);
            this.grupoCamaraSecundaria.Controls.Add(this.camara2_desconectar);
            this.grupoCamaraSecundaria.Controls.Add(this.visorCamara2);
            this.grupoCamaraSecundaria.Location = new System.Drawing.Point(12, 233);
            this.grupoCamaraSecundaria.Name = "grupoCamaraSecundaria";
            this.grupoCamaraSecundaria.Size = new System.Drawing.Size(506, 438);
            this.grupoCamaraSecundaria.TabIndex = 69;
            this.grupoCamaraSecundaria.TabStop = false;
            this.grupoCamaraSecundaria.Text = "Cámara secundaria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "IP cámara 2";
            // 
            // boton_video2
            // 
            this.boton_video2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_video2.Enabled = false;
            this.boton_video2.Image = global::EstacionControl.Properties.Resources.video_1_micro;
            this.boton_video2.Location = new System.Drawing.Point(445, 385);
            this.boton_video2.Name = "boton_video2";
            this.boton_video2.Size = new System.Drawing.Size(48, 47);
            this.boton_video2.TabIndex = 76;
            this.boton_video2.UseVisualStyleBackColor = true;
            // 
            // camara2_conectar
            // 
            this.camara2_conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camara2_conectar.Enabled = false;
            this.camara2_conectar.Image = global::EstacionControl.Properties.Resources.play_1_micro;
            this.camara2_conectar.Location = new System.Drawing.Point(243, 385);
            this.camara2_conectar.Name = "camara2_conectar";
            this.camara2_conectar.Size = new System.Drawing.Size(62, 47);
            this.camara2_conectar.TabIndex = 70;
            this.camara2_conectar.UseVisualStyleBackColor = true;
            this.camara2_conectar.Click += new System.EventHandler(this.camara2_conectar_Click);
            // 
            // boton_fotografia2
            // 
            this.boton_fotografia2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_fotografia2.Enabled = false;
            this.boton_fotografia2.Image = global::EstacionControl.Properties.Resources.foto_micro;
            this.boton_fotografia2.Location = new System.Drawing.Point(384, 385);
            this.boton_fotografia2.Name = "boton_fotografia2";
            this.boton_fotografia2.Size = new System.Drawing.Size(55, 47);
            this.boton_fotografia2.TabIndex = 75;
            this.boton_fotografia2.UseVisualStyleBackColor = true;
            // 
            // lista_camaras2
            // 
            this.lista_camaras2.FormattingEnabled = true;
            this.lista_camaras2.Location = new System.Drawing.Point(83, 399);
            this.lista_camaras2.Name = "lista_camaras2";
            this.lista_camaras2.Size = new System.Drawing.Size(121, 21);
            this.lista_camaras2.TabIndex = 72;
            // 
            // camara2_desconectar
            // 
            this.camara2_desconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camara2_desconectar.Enabled = false;
            this.camara2_desconectar.Image = global::EstacionControl.Properties.Resources.detener_micro;
            this.camara2_desconectar.Location = new System.Drawing.Point(308, 385);
            this.camara2_desconectar.Name = "camara2_desconectar";
            this.camara2_desconectar.Size = new System.Drawing.Size(70, 47);
            this.camara2_desconectar.TabIndex = 74;
            this.camara2_desconectar.UseVisualStyleBackColor = true;
            this.camara2_desconectar.Click += new System.EventHandler(this.camara2_desconectar_Click);
            // 
            // visorCamara2
            // 
            this.visorCamara2.BackgroundImage = global::EstacionControl.Properties.Resources.sin_senal_480x360;
            this.visorCamara2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.visorCamara2.Location = new System.Drawing.Point(13, 19);
            this.visorCamara2.Name = "visorCamara2";
            this.visorCamara2.Size = new System.Drawing.Size(480, 360);
            this.visorCamara2.TabIndex = 70;
            // 
            // grupo_raspberry
            // 
            this.grupo_raspberry.Controls.Add(this.boton_Conectar);
            this.grupo_raspberry.Controls.Add(this.puerto_texto);
            this.grupo_raspberry.Controls.Add(this.direccion_ip_texto);
            this.grupo_raspberry.Controls.Add(this.label1);
            this.grupo_raspberry.Controls.Add(this.camera_ip_label);
            this.grupo_raspberry.Location = new System.Drawing.Point(12, 27);
            this.grupo_raspberry.Name = "grupo_raspberry";
            this.grupo_raspberry.Size = new System.Drawing.Size(145, 113);
            this.grupo_raspberry.TabIndex = 11;
            this.grupo_raspberry.TabStop = false;
            this.grupo_raspberry.Text = "Servidor";
            // 
            // boton_Conectar
            // 
            this.boton_Conectar.Location = new System.Drawing.Point(0, 85);
            this.boton_Conectar.Name = "boton_Conectar";
            this.boton_Conectar.Size = new System.Drawing.Size(145, 28);
            this.boton_Conectar.TabIndex = 34;
            this.boton_Conectar.Text = "¡Conectar!";
            this.boton_Conectar.UseVisualStyleBackColor = true;
            this.boton_Conectar.Click += new System.EventHandler(this.Boton_Conectar_Click);
            // 
            // puerto_texto
            // 
            this.puerto_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.puerto_texto.Location = new System.Drawing.Point(69, 56);
            this.puerto_texto.Name = "puerto_texto";
            this.puerto_texto.Size = new System.Drawing.Size(70, 20);
            this.puerto_texto.TabIndex = 33;
            this.puerto_texto.Text = "7000";
            this.puerto_texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burbuja_informacion.SetToolTip(this.puerto_texto, "Puerto de escucha del servidor");
            // 
            // direccion_ip_texto
            // 
            this.direccion_ip_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.direccion_ip_texto.Location = new System.Drawing.Point(71, 22);
            this.direccion_ip_texto.Name = "direccion_ip_texto";
            this.direccion_ip_texto.Size = new System.Drawing.Size(70, 20);
            this.direccion_ip_texto.TabIndex = 31;
            this.direccion_ip_texto.Text = "192.168.0.7";
            this.burbuja_informacion.SetToolTip(this.direccion_ip_texto, "Dirección IP del servidor");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Puerto";
            // 
            // camera_ip_label
            // 
            this.camera_ip_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camera_ip_label.AutoSize = true;
            this.camera_ip_label.Location = new System.Drawing.Point(3, 25);
            this.camera_ip_label.Name = "camera_ip_label";
            this.camera_ip_label.Size = new System.Drawing.Size(65, 13);
            this.camera_ip_label.TabIndex = 30;
            this.camera_ip_label.Text = "Dirección IP";
            // 
            // grupo_minirov
            // 
            this.grupo_minirov.Controls.Add(this.indicador_mini_luces);
            this.grupo_minirov.Controls.Add(this.indicador_mini_desplegado);
            this.grupo_minirov.Controls.Add(this.button1);
            this.grupo_minirov.Location = new System.Drawing.Point(1231, 27);
            this.grupo_minirov.Name = "grupo_minirov";
            this.grupo_minirov.Size = new System.Drawing.Size(115, 644);
            this.grupo_minirov.TabIndex = 70;
            this.grupo_minirov.TabStop = false;
            this.grupo_minirov.Text = "Mini ROV";
            // 
            // indicador_mini_luces
            // 
            this.indicador_mini_luces.Location = new System.Drawing.Point(6, 189);
            this.indicador_mini_luces.Name = "indicador_mini_luces";
            this.indicador_mini_luces.Size = new System.Drawing.Size(103, 23);
            this.indicador_mini_luces.TabIndex = 3;
            this.indicador_mini_luces.Value = 27;
            // 
            // indicador_mini_desplegado
            // 
            this.indicador_mini_desplegado.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.indicador_mini_desplegado.Enabled = false;
            this.indicador_mini_desplegado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indicador_mini_desplegado.Location = new System.Drawing.Point(6, 139);
            this.indicador_mini_desplegado.Name = "indicador_mini_desplegado";
            this.indicador_mini_desplegado.Size = new System.Drawing.Size(103, 23);
            this.indicador_mini_desplegado.TabIndex = 2;
            this.indicador_mini_desplegado.Text = "No desplegado";
            this.indicador_mini_desplegado.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EstacionControl.Properties.Resources.minirov;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(6, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 88);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(1161, 674);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(64, 9);
            this.titulo.TabIndex = 70;
            this.titulo.Text = "By Alexis Aguirre";
            // 
            // PantallaEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 729);
            this.Controls.Add(this.grupo_minirov);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.grupo_raspberry);
            this.Controls.Add(this.grupoCamaraSecundaria);
            this.Controls.Add(this.herramientasSensores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.camera_groupBox);
            this.Controls.Add(this.menuCinta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuCinta;
            this.Name = "PantallaEstacion";
            this.Text = "Estación de Control - Tecnologías Marinas México";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.camera_groupBox.ResumeLayout(false);
            this.camera_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspberry_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduino_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control2_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control1_logo)).EndInit();
            this.herramientasSensores.ResumeLayout(false);
            this.herramientasSensores.PerformLayout();
            this.menuCinta.ResumeLayout(false);
            this.menuCinta.PerformLayout();
            this.grupoCamaraSecundaria.ResumeLayout(false);
            this.grupoCamaraSecundaria.PerformLayout();
            this.grupo_raspberry.ResumeLayout(false);
            this.grupo_raspberry.PerformLayout();
            this.grupo_minirov.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox indicador_control1;
        private System.Windows.Forms.Button camara1_conectar;
        private System.Windows.Forms.Button camara1_desconectar;
        private System.Windows.Forms.GroupBox camera_groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox indicador_arduino;
        private System.Windows.Forms.TextBox indicador_raspberry;
        private System.Windows.Forms.TextBox indicador_control2;
        private System.Windows.Forms.GroupBox herramientasSensores;
        private System.Windows.Forms.TextBox indicador_profundidad;
        private System.Windows.Forms.TextBox indicador_temperatura;
        private System.Windows.Forms.Label etiqueta_profundidad;
        private System.Windows.Forms.Label etiqueta_temperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indicador_linternas;
        private System.Windows.Forms.Button boton_video1;
        private System.Windows.Forms.Button boton_fotografia1;
        private System.Windows.Forms.PictureBox control2_logo;
        private System.Windows.Forms.PictureBox control1_logo;
        private System.Windows.Forms.PictureBox raspberry_logo;
        private System.Windows.Forms.PictureBox arduino_logo;
        private System.Windows.Forms.MenuStrip menuCinta;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTécnicoToolStripMenuItem;
        private System.Windows.Forms.Button boton_generarQR;
        private System.Windows.Forms.ToolStripMenuItem giroscopioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaDeFotografíasToolStripMenuItem;
        private System.Windows.Forms.Button botonReconociento;
        private System.Windows.Forms.TextBox indicador_ph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indicador_inductivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grupoCamaraSecundaria;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDeCámarasToolStripMenuItem;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl visorCamara1;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl visorCamara2;
        private System.Windows.Forms.ComboBox lista_camaras2;
        private System.Windows.Forms.ComboBox lista_camaras1;
        private System.Windows.Forms.Button boton_video2;
        private System.Windows.Forms.Button camara2_conectar;
        private System.Windows.Forms.Button boton_fotografia2;
        private System.Windows.Forms.Button camara2_desconectar;
        private System.Windows.Forms.GroupBox grupo_raspberry;
        private System.Windows.Forms.TextBox puerto_texto;
        private System.Windows.Forms.TextBox direccion_ip_texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label camera_ip_label;
        private System.Windows.Forms.ToolTip burbuja_informacion;
        private System.Windows.Forms.Button boton_Conectar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem visorDeCámaraToolStripMenuItem;
        private System.Windows.Forms.GroupBox grupo_minirov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button indicador_mini_desplegado;
        private System.Windows.Forms.ProgressBar indicador_mini_luces;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ToolStripMenuItem misionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularVolumenToolStripMenuItem;
    }
}

