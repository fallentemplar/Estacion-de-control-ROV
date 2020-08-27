namespace EstacionControl.Ventanas
{
    partial class VisorCamara
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
            this.lista_camaras1 = new System.Windows.Forms.ComboBox();
            this.boton_video1 = new System.Windows.Forms.Button();
            this.boton_fotografia1 = new System.Windows.Forms.Button();
            this.camara1_desconectar = new System.Windows.Forms.Button();
            this.camara1_conectar = new System.Windows.Forms.Button();
            this.visorCamara1 = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.SuspendLayout();
            // 
            // lista_camaras1
            // 
            this.lista_camaras1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lista_camaras1.FormattingEnabled = true;
            this.lista_camaras1.Location = new System.Drawing.Point(13, 589);
            this.lista_camaras1.Name = "lista_camaras1";
            this.lista_camaras1.Size = new System.Drawing.Size(121, 21);
            this.lista_camaras1.TabIndex = 83;
            this.lista_camaras1.Click += new System.EventHandler(this.ActualizarIPs);
            // 
            // boton_video1
            // 
            this.boton_video1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_video1.Enabled = false;
            this.boton_video1.Image = global::EstacionControl.Properties.Resources.video_1_micro;
            this.boton_video1.Location = new System.Drawing.Point(335, 575);
            this.boton_video1.Name = "boton_video1";
            this.boton_video1.Size = new System.Drawing.Size(53, 47);
            this.boton_video1.TabIndex = 82;
            this.boton_video1.UseVisualStyleBackColor = true;
            // 
            // boton_fotografia1
            // 
            this.boton_fotografia1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_fotografia1.Enabled = false;
            this.boton_fotografia1.Image = global::EstacionControl.Properties.Resources.foto_micro;
            this.boton_fotografia1.Location = new System.Drawing.Point(267, 576);
            this.boton_fotografia1.Name = "boton_fotografia1";
            this.boton_fotografia1.Size = new System.Drawing.Size(62, 47);
            this.boton_fotografia1.TabIndex = 81;
            this.boton_fotografia1.UseVisualStyleBackColor = true;
            this.boton_fotografia1.Click += new System.EventHandler(this.boton_fotografia1_Click);
            // 
            // camara1_desconectar
            // 
            this.camara1_desconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camara1_desconectar.Enabled = false;
            this.camara1_desconectar.Image = global::EstacionControl.Properties.Resources.detener_micro;
            this.camara1_desconectar.Location = new System.Drawing.Point(208, 576);
            this.camara1_desconectar.Name = "camara1_desconectar";
            this.camara1_desconectar.Size = new System.Drawing.Size(53, 47);
            this.camara1_desconectar.TabIndex = 80;
            this.camara1_desconectar.UseVisualStyleBackColor = true;
            this.camara1_desconectar.Click += new System.EventHandler(this.camara1_desconectar_Click);
            // 
            // camara1_conectar
            // 
            this.camara1_conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.camara1_conectar.Image = global::EstacionControl.Properties.Resources.play_1_micro;
            this.camara1_conectar.Location = new System.Drawing.Point(140, 576);
            this.camara1_conectar.Name = "camara1_conectar";
            this.camara1_conectar.Size = new System.Drawing.Size(62, 47);
            this.camara1_conectar.TabIndex = 79;
            this.camara1_conectar.UseVisualStyleBackColor = true;
            this.camara1_conectar.Click += new System.EventHandler(this.camara1_conectar_Click);
            // 
            // visorCamara1
            // 
            this.visorCamara1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visorCamara1.AutoSize = true;
            this.visorCamara1.BackgroundImage = global::EstacionControl.Properties.Resources.tmmx_nuevo;
            this.visorCamara1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visorCamara1.Location = new System.Drawing.Point(13, 13);
            this.visorCamara1.Name = "visorCamara1";
            this.visorCamara1.Size = new System.Drawing.Size(685, 557);
            this.visorCamara1.TabIndex = 0;
            // 
            // VisorCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 634);
            this.Controls.Add(this.lista_camaras1);
            this.Controls.Add(this.boton_video1);
            this.Controls.Add(this.boton_fotografia1);
            this.Controls.Add(this.camara1_desconectar);
            this.Controls.Add(this.camara1_conectar);
            this.Controls.Add(this.visorCamara1);
            this.Name = "VisorCamara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de cámara";
            this.Load += new System.EventHandler(this.VisorCamara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl visorCamara1;
        private System.Windows.Forms.ComboBox lista_camaras1;
        private System.Windows.Forms.Button boton_video1;
        private System.Windows.Forms.Button boton_fotografia1;
        private System.Windows.Forms.Button camara1_desconectar;
        private System.Windows.Forms.Button camara1_conectar;
    }
}