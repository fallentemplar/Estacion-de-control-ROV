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
            this.menuCinta = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaDeFotografíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giroscopioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDeCámarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorDeCámaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoVictoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularVolumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diafragmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burbuja_informacion = new System.Windows.Forms.ToolTip(this.components);
            this.boton_Conectar = new System.Windows.Forms.Button();
            this.puerto_texto = new System.Windows.Forms.TextBox();
            this.direccion_ip_texto = new System.Windows.Forms.TextBox();
            this.raspberry_logo = new System.Windows.Forms.PictureBox();
            this.arduino_logo = new System.Windows.Forms.PictureBox();
            this.control2_logo = new System.Windows.Forms.PictureBox();
            this.control1_logo = new System.Windows.Forms.PictureBox();
            this.campo_puerto_MiniROV = new System.Windows.Forms.TextBox();
            this.campo_ip_MiniROV = new System.Windows.Forms.TextBox();
            this.boton_Desplegar_MiniROV = new System.Windows.Forms.Button();
            this.groupROVPrincipal = new System.Windows.Forms.GroupBox();
            this.grupoCamaraSecundaria = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_video2 = new System.Windows.Forms.Button();
            this.camara2_conectar = new System.Windows.Forms.Button();
            this.boton_fotografia2 = new System.Windows.Forms.Button();
            this.lista_camaras2 = new System.Windows.Forms.ComboBox();
            this.camara2_desconectar = new System.Windows.Forms.Button();
            this.visorCamara2 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.herramientasSensores = new System.Windows.Forms.GroupBox();
            this.indicador_linternas = new System.Windows.Forms.ProgressBar();
            this.indicador_inductivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.indicador_ph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.indicador_profundidad = new System.Windows.Forms.TextBox();
            this.indicador_temperatura = new System.Windows.Forms.TextBox();
            this.etiqueta_profundidad = new System.Windows.Forms.Label();
            this.etiqueta_temperatura = new System.Windows.Forms.Label();
            this.groupConectividad = new System.Windows.Forms.GroupBox();
            this.indicador_control2 = new System.Windows.Forms.TextBox();
            this.indicador_arduino = new System.Windows.Forms.TextBox();
            this.indicador_raspberry = new System.Windows.Forms.TextBox();
            this.indicador_control1 = new System.Windows.Forms.TextBox();
            this.grupo_raspberry = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camera_ip_label = new System.Windows.Forms.Label();
            this.grupo_minirov = new System.Windows.Forms.GroupBox();
            this.etiqueta_indicador_linternas_mini = new System.Windows.Forms.Label();
            this.indicador_mini_desplegado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.indicador_mini_luces = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.camera_groupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lista_camaras1 = new System.Windows.Forms.ComboBox();
            this.boton_generarQR = new System.Windows.Forms.Button();
            this.boton_video1 = new System.Windows.Forms.Button();
            this.boton_fotografia1 = new System.Windows.Forms.Button();
            this.camara1_desconectar = new System.Windows.Forms.Button();
            this.camara1_conectar = new System.Windows.Forms.Button();
            this.visorCamara1 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.botonReconociento = new System.Windows.Forms.Button();
            this.menuCinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspberry_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduino_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control2_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control1_logo)).BeginInit();
            this.groupROVPrincipal.SuspendLayout();
            this.grupoCamaraSecundaria.SuspendLayout();
            this.herramientasSensores.SuspendLayout();
            this.groupConectividad.SuspendLayout();
            this.grupo_raspberry.SuspendLayout();
            this.grupo_minirov.SuspendLayout();
            this.camera_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCinta
            // 
            this.menuCinta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.misionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
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
            this.visorDeCámaraToolStripMenuItem,
            this.modoVictoriaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // giroscopioToolStripMenuItem
            // 
            this.giroscopioToolStripMenuItem.Name = "giroscopioToolStripMenuItem";
            this.giroscopioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.giroscopioToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.giroscopioToolStripMenuItem.Text = "Giroscopio";
            this.giroscopioToolStripMenuItem.Click += new System.EventHandler(this.giroscopioToolStripMenuItem_Click);
            // 
            // configuraciónDeCámarasToolStripMenuItem
            // 
            this.configuraciónDeCámarasToolStripMenuItem.Name = "configuraciónDeCámarasToolStripMenuItem";
            this.configuraciónDeCámarasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.configuraciónDeCámarasToolStripMenuItem.Text = "Configuración de cámaras";
            this.configuraciónDeCámarasToolStripMenuItem.Click += new System.EventHandler(this.configuraciónDeCámarasToolStripMenuItem_Click);
            // 
            // visorDeCámaraToolStripMenuItem
            // 
            this.visorDeCámaraToolStripMenuItem.Name = "visorDeCámaraToolStripMenuItem";
            this.visorDeCámaraToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.visorDeCámaraToolStripMenuItem.Text = "Visor de cámara";
            this.visorDeCámaraToolStripMenuItem.Click += new System.EventHandler(this.visorDeCámaraToolStripMenuItem_Click);
            // 
            // modoVictoriaToolStripMenuItem
            // 
            this.modoVictoriaToolStripMenuItem.Name = "modoVictoriaToolStripMenuItem";
            this.modoVictoriaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.modoVictoriaToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.modoVictoriaToolStripMenuItem.Text = "Modo Victoria";
            this.modoVictoriaToolStripMenuItem.Click += new System.EventHandler(this.modoVictoriaToolStripMenuItem_Click);
            // 
            // misionesToolStripMenuItem
            // 
            this.misionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canonToolStripMenuItem,
            this.diafragmaToolStripMenuItem});
            this.misionesToolStripMenuItem.Name = "misionesToolStripMenuItem";
            this.misionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.misionesToolStripMenuItem.Text = "Misiones";
            // 
            // canonToolStripMenuItem
            // 
            this.canonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularVolumenToolStripMenuItem});
            this.canonToolStripMenuItem.Name = "canonToolStripMenuItem";
            this.canonToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.canonToolStripMenuItem.Text = "Cañón";
            // 
            // calcularVolumenToolStripMenuItem
            // 
            this.calcularVolumenToolStripMenuItem.Name = "calcularVolumenToolStripMenuItem";
            this.calcularVolumenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.calcularVolumenToolStripMenuItem.Text = "Calcular Volúmen";
            this.calcularVolumenToolStripMenuItem.Click += new System.EventHandler(this.calcularVolumenToolStripMenuItem_Click);
            // 
            // diafragmaToolStripMenuItem
            // 
            this.diafragmaToolStripMenuItem.Name = "diafragmaToolStripMenuItem";
            this.diafragmaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.diafragmaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.diafragmaToolStripMenuItem.Text = "Abrir diafragma";
            this.diafragmaToolStripMenuItem.Click += new System.EventHandler(this.diafragmaToolStripMenuItem_Click);
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
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // manualTécnicoToolStripMenuItem
            // 
            this.manualTécnicoToolStripMenuItem.Name = "manualTécnicoToolStripMenuItem";
            this.manualTécnicoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manualTécnicoToolStripMenuItem.Text = "Manual Técnico";
            // 
            // boton_Conectar
            // 
            this.boton_Conectar.Location = new System.Drawing.Point(0, 85);
            this.boton_Conectar.Name = "boton_Conectar";
            this.boton_Conectar.Size = new System.Drawing.Size(145, 28);
            this.boton_Conectar.TabIndex = 34;
            this.boton_Conectar.Text = "¡Conectar!";
            this.burbuja_informacion.SetToolTip(this.boton_Conectar, "Conectar a ROV Principal");
            this.boton_Conectar.UseVisualStyleBackColor = true;
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
            this.direccion_ip_texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burbuja_informacion.SetToolTip(this.direccion_ip_texto, "Dirección IP del servidor");
            // 
            // raspberry_logo
            // 
            this.raspberry_logo.Image = global::EstacionControl.Properties.Resources.raspberry_micro;
            this.raspberry_logo.Location = new System.Drawing.Point(6, 63);
            this.raspberry_logo.Name = "raspberry_logo";
            this.raspberry_logo.Size = new System.Drawing.Size(40, 40);
            this.raspberry_logo.TabIndex = 10;
            this.raspberry_logo.TabStop = false;
            this.burbuja_informacion.SetToolTip(this.raspberry_logo, "Raspberry ROV Principal");
            // 
            // arduino_logo
            // 
            this.arduino_logo.Image = global::EstacionControl.Properties.Resources.arduino_micro;
            this.arduino_logo.Location = new System.Drawing.Point(203, 63);
            this.arduino_logo.Name = "arduino_logo";
            this.arduino_logo.Size = new System.Drawing.Size(39, 40);
            this.arduino_logo.TabIndex = 9;
            this.arduino_logo.TabStop = false;
            this.burbuja_informacion.SetToolTip(this.arduino_logo, "Arduino ROV Principal");
            // 
            // control2_logo
            // 
            this.control2_logo.Image = global::EstacionControl.Properties.Resources.xbox_micro;
            this.control2_logo.Location = new System.Drawing.Point(203, 17);
            this.control2_logo.Name = "control2_logo";
            this.control2_logo.Size = new System.Drawing.Size(39, 40);
            this.control2_logo.TabIndex = 8;
            this.control2_logo.TabStop = false;
            this.burbuja_informacion.SetToolTip(this.control2_logo, "Control 2");
            // 
            // control1_logo
            // 
            this.control1_logo.Image = global::EstacionControl.Properties.Resources.xbox_micro;
            this.control1_logo.Location = new System.Drawing.Point(6, 17);
            this.control1_logo.Name = "control1_logo";
            this.control1_logo.Size = new System.Drawing.Size(39, 40);
            this.control1_logo.TabIndex = 7;
            this.control1_logo.TabStop = false;
            this.burbuja_informacion.SetToolTip(this.control1_logo, "Control 1");
            // 
            // campo_puerto_MiniROV
            // 
            this.campo_puerto_MiniROV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.campo_puerto_MiniROV.Location = new System.Drawing.Point(6, 216);
            this.campo_puerto_MiniROV.Name = "campo_puerto_MiniROV";
            this.campo_puerto_MiniROV.Size = new System.Drawing.Size(103, 20);
            this.campo_puerto_MiniROV.TabIndex = 36;
            this.campo_puerto_MiniROV.Text = "7000";
            this.campo_puerto_MiniROV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burbuja_informacion.SetToolTip(this.campo_puerto_MiniROV, "Puerto de escucha del servidor");
            // 
            // campo_ip_MiniROV
            // 
            this.campo_ip_MiniROV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.campo_ip_MiniROV.Location = new System.Drawing.Point(6, 176);
            this.campo_ip_MiniROV.Name = "campo_ip_MiniROV";
            this.campo_ip_MiniROV.Size = new System.Drawing.Size(103, 20);
            this.campo_ip_MiniROV.TabIndex = 35;
            this.campo_ip_MiniROV.Text = "192.168.0.8";
            this.campo_ip_MiniROV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.burbuja_informacion.SetToolTip(this.campo_ip_MiniROV, "Dirección IP del servidor");
            // 
            // boton_Desplegar_MiniROV
            // 
            this.boton_Desplegar_MiniROV.BackgroundImage = global::EstacionControl.Properties.Resources.minirov;
            this.boton_Desplegar_MiniROV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Desplegar_MiniROV.Location = new System.Drawing.Point(6, 15);
            this.boton_Desplegar_MiniROV.Name = "boton_Desplegar_MiniROV";
            this.boton_Desplegar_MiniROV.Size = new System.Drawing.Size(103, 88);
            this.boton_Desplegar_MiniROV.TabIndex = 0;
            this.burbuja_informacion.SetToolTip(this.boton_Desplegar_MiniROV, "Desplegar o desactivar Mini ROV");
            this.boton_Desplegar_MiniROV.UseVisualStyleBackColor = true;
            // 
            // groupROVPrincipal
            // 
            this.groupROVPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupROVPrincipal.Controls.Add(this.camera_groupBox);
            this.groupROVPrincipal.Controls.Add(this.grupoCamaraSecundaria);
            this.groupROVPrincipal.Controls.Add(this.herramientasSensores);
            this.groupROVPrincipal.Controls.Add(this.groupConectividad);
            this.groupROVPrincipal.Controls.Add(this.grupo_raspberry);
            this.groupROVPrincipal.Location = new System.Drawing.Point(12, 27);
            this.groupROVPrincipal.Name = "groupROVPrincipal";
            this.groupROVPrincipal.Size = new System.Drawing.Size(1130, 672);
            this.groupROVPrincipal.TabIndex = 71;
            this.groupROVPrincipal.TabStop = false;
            this.groupROVPrincipal.Text = "ROV Principal";
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
            this.grupoCamaraSecundaria.Location = new System.Drawing.Point(6, 223);
            this.grupoCamaraSecundaria.Name = "grupoCamaraSecundaria";
            this.grupoCamaraSecundaria.Size = new System.Drawing.Size(507, 440);
            this.grupoCamaraSecundaria.TabIndex = 73;
            this.grupoCamaraSecundaria.TabStop = false;
            this.grupoCamaraSecundaria.Text = "Cámara 2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 406);
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
            this.boton_video2.Location = new System.Drawing.Point(445, 387);
            this.boton_video2.Name = "boton_video2";
            this.boton_video2.Size = new System.Drawing.Size(48, 47);
            this.boton_video2.TabIndex = 76;
            this.boton_video2.UseVisualStyleBackColor = true;
            // 
            // camara2_conectar
            // 
            this.camara2_conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.camara2_conectar.Enabled = false;
            this.camara2_conectar.Image = global::EstacionControl.Properties.Resources.play_1_micro;
            this.camara2_conectar.Location = new System.Drawing.Point(244, 387);
            this.camara2_conectar.Name = "camara2_conectar";
            this.camara2_conectar.Size = new System.Drawing.Size(62, 47);
            this.camara2_conectar.TabIndex = 70;
            this.camara2_conectar.UseVisualStyleBackColor = true;
            // 
            // boton_fotografia2
            // 
            this.boton_fotografia2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_fotografia2.Enabled = false;
            this.boton_fotografia2.Image = global::EstacionControl.Properties.Resources.foto_micro;
            this.boton_fotografia2.Location = new System.Drawing.Point(385, 387);
            this.boton_fotografia2.Name = "boton_fotografia2";
            this.boton_fotografia2.Size = new System.Drawing.Size(55, 47);
            this.boton_fotografia2.TabIndex = 75;
            this.boton_fotografia2.UseVisualStyleBackColor = true;
            // 
            // lista_camaras2
            // 
            this.lista_camaras2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lista_camaras2.FormattingEnabled = true;
            this.lista_camaras2.Location = new System.Drawing.Point(83, 401);
            this.lista_camaras2.Name = "lista_camaras2";
            this.lista_camaras2.Size = new System.Drawing.Size(121, 21);
            this.lista_camaras2.TabIndex = 72;
            // 
            // camara2_desconectar
            // 
            this.camara2_desconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.camara2_desconectar.Enabled = false;
            this.camara2_desconectar.Image = global::EstacionControl.Properties.Resources.detener_micro;
            this.camara2_desconectar.Location = new System.Drawing.Point(309, 387);
            this.camara2_desconectar.Name = "camara2_desconectar";
            this.camara2_desconectar.Size = new System.Drawing.Size(70, 47);
            this.camara2_desconectar.TabIndex = 74;
            this.camara2_desconectar.UseVisualStyleBackColor = true;
            // 
            // visorCamara2
            // 
            this.visorCamara2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visorCamara2.AutoSize = true;
            this.visorCamara2.BackgroundImage = global::EstacionControl.Properties.Resources.sin_senal_480x360;
            this.visorCamara2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.visorCamara2.Location = new System.Drawing.Point(13, 19);
            this.visorCamara2.Name = "visorCamara2";
            this.visorCamara2.Size = new System.Drawing.Size(481, 362);
            this.visorCamara2.TabIndex = 70;
            // 
            // herramientasSensores
            // 
            this.herramientasSensores.Controls.Add(this.indicador_linternas);
            this.herramientasSensores.Controls.Add(this.indicador_inductivo);
            this.herramientasSensores.Controls.Add(this.label3);
            this.herramientasSensores.Controls.Add(this.indicador_ph);
            this.herramientasSensores.Controls.Add(this.label2);
            this.herramientasSensores.Controls.Add(this.label4);
            this.herramientasSensores.Controls.Add(this.indicador_profundidad);
            this.herramientasSensores.Controls.Add(this.indicador_temperatura);
            this.herramientasSensores.Controls.Add(this.etiqueta_profundidad);
            this.herramientasSensores.Controls.Add(this.etiqueta_temperatura);
            this.herramientasSensores.Location = new System.Drawing.Point(6, 138);
            this.herramientasSensores.Name = "herramientasSensores";
            this.herramientasSensores.Size = new System.Drawing.Size(507, 79);
            this.herramientasSensores.TabIndex = 72;
            this.herramientasSensores.TabStop = false;
            this.herramientasSensores.Text = "Herramientas y sensores";
            // 
            // indicador_linternas
            // 
            this.indicador_linternas.Location = new System.Drawing.Point(392, 46);
            this.indicador_linternas.Name = "indicador_linternas";
            this.indicador_linternas.Size = new System.Drawing.Size(100, 20);
            this.indicador_linternas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.indicador_linternas.TabIndex = 10;
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
            // groupConectividad
            // 
            this.groupConectividad.Controls.Add(this.raspberry_logo);
            this.groupConectividad.Controls.Add(this.arduino_logo);
            this.groupConectividad.Controls.Add(this.control2_logo);
            this.groupConectividad.Controls.Add(this.control1_logo);
            this.groupConectividad.Controls.Add(this.indicador_control2);
            this.groupConectividad.Controls.Add(this.indicador_arduino);
            this.groupConectividad.Controls.Add(this.indicador_raspberry);
            this.groupConectividad.Controls.Add(this.indicador_control1);
            this.groupConectividad.Location = new System.Drawing.Point(157, 19);
            this.groupConectividad.Name = "groupConectividad";
            this.groupConectividad.Size = new System.Drawing.Size(356, 113);
            this.groupConectividad.TabIndex = 62;
            this.groupConectividad.TabStop = false;
            this.groupConectividad.Text = "Conectividad";
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
            // indicador_control1
            // 
            this.indicador_control1.Enabled = false;
            this.indicador_control1.Location = new System.Drawing.Point(51, 22);
            this.indicador_control1.Name = "indicador_control1";
            this.indicador_control1.Size = new System.Drawing.Size(101, 20);
            this.indicador_control1.TabIndex = 0;
            this.indicador_control1.Text = "Desconectado";
            // 
            // grupo_raspberry
            // 
            this.grupo_raspberry.Controls.Add(this.boton_Conectar);
            this.grupo_raspberry.Controls.Add(this.puerto_texto);
            this.grupo_raspberry.Controls.Add(this.direccion_ip_texto);
            this.grupo_raspberry.Controls.Add(this.label1);
            this.grupo_raspberry.Controls.Add(this.camera_ip_label);
            this.grupo_raspberry.Location = new System.Drawing.Point(6, 19);
            this.grupo_raspberry.Name = "grupo_raspberry";
            this.grupo_raspberry.Size = new System.Drawing.Size(145, 113);
            this.grupo_raspberry.TabIndex = 12;
            this.grupo_raspberry.TabStop = false;
            this.grupo_raspberry.Text = "Servidor";
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
            this.grupo_minirov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupo_minirov.Controls.Add(this.etiqueta_indicador_linternas_mini);
            this.grupo_minirov.Controls.Add(this.indicador_mini_desplegado);
            this.grupo_minirov.Controls.Add(this.campo_puerto_MiniROV);
            this.grupo_minirov.Controls.Add(this.label7);
            this.grupo_minirov.Controls.Add(this.indicador_mini_luces);
            this.grupo_minirov.Controls.Add(this.campo_ip_MiniROV);
            this.grupo_minirov.Controls.Add(this.label8);
            this.grupo_minirov.Controls.Add(this.boton_Desplegar_MiniROV);
            this.grupo_minirov.Location = new System.Drawing.Point(1148, 27);
            this.grupo_minirov.Name = "grupo_minirov";
            this.grupo_minirov.Size = new System.Drawing.Size(115, 672);
            this.grupo_minirov.TabIndex = 70;
            this.grupo_minirov.TabStop = false;
            this.grupo_minirov.Text = "Mini ROV";
            // 
            // etiqueta_indicador_linternas_mini
            // 
            this.etiqueta_indicador_linternas_mini.AutoSize = true;
            this.etiqueta_indicador_linternas_mini.Location = new System.Drawing.Point(6, 211);
            this.etiqueta_indicador_linternas_mini.Name = "etiqueta_indicador_linternas_mini";
            this.etiqueta_indicador_linternas_mini.Size = new System.Drawing.Size(50, 13);
            this.etiqueta_indicador_linternas_mini.TabIndex = 37;
            this.etiqueta_indicador_linternas_mini.Text = "Linternas";
            // 
            // indicador_mini_desplegado
            // 
            this.indicador_mini_desplegado.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.indicador_mini_desplegado.Enabled = false;
            this.indicador_mini_desplegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicador_mini_desplegado.ForeColor = System.Drawing.Color.Yellow;
            this.indicador_mini_desplegado.Location = new System.Drawing.Point(6, 109);
            this.indicador_mini_desplegado.Name = "indicador_mini_desplegado";
            this.indicador_mini_desplegado.ReadOnly = true;
            this.indicador_mini_desplegado.Size = new System.Drawing.Size(103, 20);
            this.indicador_mini_desplegado.TabIndex = 11;
            this.indicador_mini_desplegado.Text = "No Desplegado";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Puerto";
            // 
            // indicador_mini_luces
            // 
            this.indicador_mini_luces.Location = new System.Drawing.Point(6, 227);
            this.indicador_mini_luces.Name = "indicador_mini_luces";
            this.indicador_mini_luces.Size = new System.Drawing.Size(103, 23);
            this.indicador_mini_luces.TabIndex = 3;
            this.indicador_mini_luces.Value = 27;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Dirección IP";
            // 
            // camera_groupBox
            // 
            this.camera_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camera_groupBox.Controls.Add(this.label6);
            this.camera_groupBox.Controls.Add(this.lista_camaras1);
            this.camera_groupBox.Controls.Add(this.boton_generarQR);
            this.camera_groupBox.Controls.Add(this.boton_video1);
            this.camera_groupBox.Controls.Add(this.boton_fotografia1);
            this.camera_groupBox.Controls.Add(this.camara1_desconectar);
            this.camera_groupBox.Controls.Add(this.camara1_conectar);
            this.camera_groupBox.Controls.Add(this.visorCamara1);
            this.camera_groupBox.Controls.Add(this.botonReconociento);
            this.camera_groupBox.Location = new System.Drawing.Point(519, 19);
            this.camera_groupBox.Name = "camera_groupBox";
            this.camera_groupBox.Size = new System.Drawing.Size(604, 644);
            this.camera_groupBox.TabIndex = 74;
            this.camera_groupBox.TabStop = false;
            this.camera_groupBox.Text = "Cámara 1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(10, 601);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "IP cámara 1";
            // 
            // lista_camaras1
            // 
            this.lista_camaras1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lista_camaras1.FormattingEnabled = true;
            this.lista_camaras1.Location = new System.Drawing.Point(77, 598);
            this.lista_camaras1.Name = "lista_camaras1";
            this.lista_camaras1.Size = new System.Drawing.Size(115, 21);
            this.lista_camaras1.TabIndex = 104;
            // 
            // boton_generarQR
            // 
            this.boton_generarQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_generarQR.BackgroundImage = global::EstacionControl.Properties.Resources.QR;
            this.boton_generarQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_generarQR.Location = new System.Drawing.Point(470, 576);
            this.boton_generarQR.Name = "boton_generarQR";
            this.boton_generarQR.Size = new System.Drawing.Size(62, 62);
            this.boton_generarQR.TabIndex = 102;
            this.boton_generarQR.Text = "Generar QR";
            this.burbuja_informacion.SetToolTip(this.boton_generarQR, "Generar QR para obtener enlace de streaming para Cámara 1");
            this.boton_generarQR.UseVisualStyleBackColor = true;
            // 
            // boton_video1
            // 
            this.boton_video1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_video1.Enabled = false;
            this.boton_video1.Image = global::EstacionControl.Properties.Resources.video_1_micro;
            this.boton_video1.Location = new System.Drawing.Point(402, 576);
            this.boton_video1.Name = "boton_video1";
            this.boton_video1.Size = new System.Drawing.Size(62, 62);
            this.boton_video1.TabIndex = 101;
            this.burbuja_informacion.SetToolTip(this.boton_video1, "Grabar video con Cámara 1");
            this.boton_video1.UseVisualStyleBackColor = true;
            // 
            // boton_fotografia1
            // 
            this.boton_fotografia1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_fotografia1.Enabled = false;
            this.boton_fotografia1.Image = global::EstacionControl.Properties.Resources.foto_micro;
            this.boton_fotografia1.Location = new System.Drawing.Point(334, 576);
            this.boton_fotografia1.Name = "boton_fotografia1";
            this.boton_fotografia1.Size = new System.Drawing.Size(62, 62);
            this.boton_fotografia1.TabIndex = 100;
            this.burbuja_informacion.SetToolTip(this.boton_fotografia1, "Tomar fotografía con Cámara 1");
            this.boton_fotografia1.UseVisualStyleBackColor = true;
            // 
            // camara1_desconectar
            // 
            this.camara1_desconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camara1_desconectar.Enabled = false;
            this.camara1_desconectar.Image = global::EstacionControl.Properties.Resources.detener_micro;
            this.camara1_desconectar.Location = new System.Drawing.Point(266, 576);
            this.camara1_desconectar.Name = "camara1_desconectar";
            this.camara1_desconectar.Size = new System.Drawing.Size(62, 62);
            this.camara1_desconectar.TabIndex = 99;
            this.burbuja_informacion.SetToolTip(this.camara1_desconectar, "Detener transmisión de video de cámara 1");
            this.camara1_desconectar.UseVisualStyleBackColor = true;
            // 
            // camara1_conectar
            // 
            this.camara1_conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camara1_conectar.Enabled = false;
            this.camara1_conectar.Image = global::EstacionControl.Properties.Resources.play_1_micro;
            this.camara1_conectar.Location = new System.Drawing.Point(198, 576);
            this.camara1_conectar.Name = "camara1_conectar";
            this.camara1_conectar.Size = new System.Drawing.Size(62, 62);
            this.camara1_conectar.TabIndex = 98;
            this.burbuja_informacion.SetToolTip(this.camara1_conectar, "Iniciar transmisión de video con Cámara 1");
            this.camara1_conectar.UseVisualStyleBackColor = true;
            // 
            // visorCamara1
            // 
            this.visorCamara1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visorCamara1.AutoSize = true;
            this.visorCamara1.BackgroundImage = global::EstacionControl.Properties.Resources.tmmx_nuevo;
            this.visorCamara1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visorCamara1.Location = new System.Drawing.Point(13, 17);
            this.visorCamara1.Name = "visorCamara1";
            this.visorCamara1.Size = new System.Drawing.Size(581, 543);
            this.visorCamara1.TabIndex = 103;
            // 
            // botonReconociento
            // 
            this.botonReconociento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonReconociento.Location = new System.Drawing.Point(536, 576);
            this.botonReconociento.Name = "botonReconociento";
            this.botonReconociento.Size = new System.Drawing.Size(62, 62);
            this.botonReconociento.TabIndex = 97;
            this.botonReconociento.Text = "Identificar Especies";
            this.burbuja_informacion.SetToolTip(this.botonReconociento, "Objeto de misión: Identificación de especies bentónicas");
            this.botonReconociento.UseVisualStyleBackColor = true;
            // 
            // PantallaEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 729);
            this.Controls.Add(this.grupo_minirov);
            this.Controls.Add(this.groupROVPrincipal);
            this.Controls.Add(this.menuCinta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuCinta;
            this.Name = "PantallaEstacion";
            this.Text = "Estación de Control - Tecnologías Marinas México";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuCinta.ResumeLayout(false);
            this.menuCinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspberry_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arduino_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control2_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control1_logo)).EndInit();
            this.groupROVPrincipal.ResumeLayout(false);
            this.grupoCamaraSecundaria.ResumeLayout(false);
            this.grupoCamaraSecundaria.PerformLayout();
            this.herramientasSensores.ResumeLayout(false);
            this.herramientasSensores.PerformLayout();
            this.groupConectividad.ResumeLayout(false);
            this.groupConectividad.PerformLayout();
            this.grupo_raspberry.ResumeLayout(false);
            this.grupo_raspberry.PerformLayout();
            this.grupo_minirov.ResumeLayout(false);
            this.grupo_minirov.PerformLayout();
            this.camera_groupBox.ResumeLayout(false);
            this.camera_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuCinta;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giroscopioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaDeFotografíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDeCámarasToolStripMenuItem;
        private System.Windows.Forms.ToolTip burbuja_informacion;
        private System.Windows.Forms.ToolStripMenuItem visorDeCámaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularVolumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diafragmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoVictoriaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupROVPrincipal;
        private System.Windows.Forms.GroupBox grupo_minirov;
        private System.Windows.Forms.Label etiqueta_indicador_linternas_mini;
        private System.Windows.Forms.TextBox indicador_mini_desplegado;
        private System.Windows.Forms.TextBox campo_puerto_MiniROV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar indicador_mini_luces;
        private System.Windows.Forms.TextBox campo_ip_MiniROV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button boton_Desplegar_MiniROV;
        private System.Windows.Forms.GroupBox grupoCamaraSecundaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton_video2;
        private System.Windows.Forms.Button camara2_conectar;
        private System.Windows.Forms.Button boton_fotografia2;
        private System.Windows.Forms.ComboBox lista_camaras2;
        private System.Windows.Forms.Button camara2_desconectar;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl visorCamara2;
        private System.Windows.Forms.GroupBox herramientasSensores;
        private System.Windows.Forms.ProgressBar indicador_linternas;
        private System.Windows.Forms.TextBox indicador_inductivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox indicador_ph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indicador_profundidad;
        private System.Windows.Forms.TextBox indicador_temperatura;
        private System.Windows.Forms.Label etiqueta_profundidad;
        private System.Windows.Forms.Label etiqueta_temperatura;
        private System.Windows.Forms.GroupBox groupConectividad;
        private System.Windows.Forms.PictureBox raspberry_logo;
        private System.Windows.Forms.PictureBox arduino_logo;
        private System.Windows.Forms.PictureBox control2_logo;
        private System.Windows.Forms.PictureBox control1_logo;
        private System.Windows.Forms.TextBox indicador_control2;
        private System.Windows.Forms.TextBox indicador_arduino;
        private System.Windows.Forms.TextBox indicador_raspberry;
        private System.Windows.Forms.TextBox indicador_control1;
        private System.Windows.Forms.GroupBox grupo_raspberry;
        private System.Windows.Forms.Button boton_Conectar;
        private System.Windows.Forms.TextBox puerto_texto;
        private System.Windows.Forms.TextBox direccion_ip_texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label camera_ip_label;
        private System.Windows.Forms.GroupBox camera_groupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lista_camaras1;
        private System.Windows.Forms.Button boton_generarQR;
        private System.Windows.Forms.Button boton_video1;
        private System.Windows.Forms.Button boton_fotografia1;
        private System.Windows.Forms.Button camara1_desconectar;
        private System.Windows.Forms.Button camara1_conectar;
        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl visorCamara1;
        private System.Windows.Forms.Button botonReconociento;
    }
}

