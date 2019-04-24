namespace EstacionControl.Ventanas
{
    partial class MisionCanon
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
            this.imagen_procesamiento = new System.Windows.Forms.PictureBox();
            this.boton_Capturar = new System.Windows.Forms.Button();
            this.grupo_controles = new System.Windows.Forms.GroupBox();
            this.campo_longitud = new System.Windows.Forms.TextBox();
            this.boton_L1 = new System.Windows.Forms.Button();
            this.boton_D3 = new System.Windows.Forms.Button();
            this.boton_D2 = new System.Windows.Forms.Button();
            this.boton_D1 = new System.Windows.Forms.Button();
            this.boton_calcular_volumen = new System.Windows.Forms.Button();
            this.boton_longitudes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_procesamiento)).BeginInit();
            this.grupo_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagen_procesamiento
            // 
            this.imagen_procesamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagen_procesamiento.Location = new System.Drawing.Point(0, 0);
            this.imagen_procesamiento.Margin = new System.Windows.Forms.Padding(0);
            this.imagen_procesamiento.Name = "imagen_procesamiento";
            this.imagen_procesamiento.Size = new System.Drawing.Size(384, 361);
            this.imagen_procesamiento.TabIndex = 0;
            this.imagen_procesamiento.TabStop = false;
            this.imagen_procesamiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ObtenerCoordenadasMouse);
            // 
            // boton_Capturar
            // 
            this.boton_Capturar.Location = new System.Drawing.Point(6, 19);
            this.boton_Capturar.Name = "boton_Capturar";
            this.boton_Capturar.Size = new System.Drawing.Size(137, 23);
            this.boton_Capturar.TabIndex = 1;
            this.boton_Capturar.Text = "Capturar imágen";
            this.boton_Capturar.UseVisualStyleBackColor = true;
            this.boton_Capturar.Click += new System.EventHandler(this.boton_Capturar_Click);
            // 
            // grupo_controles
            // 
            this.grupo_controles.Controls.Add(this.boton_longitudes);
            this.grupo_controles.Controls.Add(this.boton_calcular_volumen);
            this.grupo_controles.Controls.Add(this.campo_longitud);
            this.grupo_controles.Controls.Add(this.boton_L1);
            this.grupo_controles.Controls.Add(this.boton_D3);
            this.grupo_controles.Controls.Add(this.boton_D2);
            this.grupo_controles.Controls.Add(this.boton_D1);
            this.grupo_controles.Controls.Add(this.boton_Capturar);
            this.grupo_controles.Location = new System.Drawing.Point(12, 249);
            this.grupo_controles.Name = "grupo_controles";
            this.grupo_controles.Size = new System.Drawing.Size(372, 100);
            this.grupo_controles.TabIndex = 2;
            this.grupo_controles.TabStop = false;
            this.grupo_controles.Text = "Opciones";
            // 
            // campo_longitud
            // 
            this.campo_longitud.Location = new System.Drawing.Point(149, 21);
            this.campo_longitud.Name = "campo_longitud";
            this.campo_longitud.ReadOnly = true;
            this.campo_longitud.Size = new System.Drawing.Size(137, 20);
            this.campo_longitud.TabIndex = 6;
            // 
            // boton_L1
            // 
            this.boton_L1.Location = new System.Drawing.Point(149, 77);
            this.boton_L1.Name = "boton_L1";
            this.boton_L1.Size = new System.Drawing.Size(137, 23);
            this.boton_L1.TabIndex = 5;
            this.boton_L1.Text = "Guardar como longitud";
            this.boton_L1.UseVisualStyleBackColor = true;
            this.boton_L1.Click += new System.EventHandler(this.boton_L1_Click);
            // 
            // boton_D3
            // 
            this.boton_D3.Location = new System.Drawing.Point(149, 49);
            this.boton_D3.Name = "boton_D3";
            this.boton_D3.Size = new System.Drawing.Size(137, 23);
            this.boton_D3.TabIndex = 4;
            this.boton_D3.Text = "Guardar como diámetro I";
            this.boton_D3.UseVisualStyleBackColor = true;
            this.boton_D3.Click += new System.EventHandler(this.boton_D3_Click);
            // 
            // boton_D2
            // 
            this.boton_D2.Location = new System.Drawing.Point(6, 77);
            this.boton_D2.Name = "boton_D2";
            this.boton_D2.Size = new System.Drawing.Size(137, 23);
            this.boton_D2.TabIndex = 3;
            this.boton_D2.Text = "Guardar como diámetro m";
            this.boton_D2.UseVisualStyleBackColor = true;
            this.boton_D2.Click += new System.EventHandler(this.boton_D2_Click);
            // 
            // boton_D1
            // 
            this.boton_D1.Location = new System.Drawing.Point(6, 49);
            this.boton_D1.Name = "boton_D1";
            this.boton_D1.Size = new System.Drawing.Size(137, 23);
            this.boton_D1.TabIndex = 2;
            this.boton_D1.Text = "Guardar como diámetro M";
            this.boton_D1.UseVisualStyleBackColor = true;
            this.boton_D1.Click += new System.EventHandler(this.boton_D1_Click);
            // 
            // boton_calcular_volumen
            // 
            this.boton_calcular_volumen.Location = new System.Drawing.Point(292, 49);
            this.boton_calcular_volumen.Name = "boton_calcular_volumen";
            this.boton_calcular_volumen.Size = new System.Drawing.Size(74, 51);
            this.boton_calcular_volumen.TabIndex = 7;
            this.boton_calcular_volumen.Text = "Calcular volúmen";
            this.boton_calcular_volumen.UseVisualStyleBackColor = true;
            this.boton_calcular_volumen.Click += new System.EventHandler(this.boton_calcular_volumen_Click);
            // 
            // boton_longitudes
            // 
            this.boton_longitudes.Location = new System.Drawing.Point(293, 21);
            this.boton_longitudes.Name = "boton_longitudes";
            this.boton_longitudes.Size = new System.Drawing.Size(73, 23);
            this.boton_longitudes.TabIndex = 8;
            this.boton_longitudes.Text = "Longitudes";
            this.boton_longitudes.UseVisualStyleBackColor = true;
            this.boton_longitudes.Click += new System.EventHandler(this.boton_longitudes_Click);
            // 
            // MisionCanon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.grupo_controles);
            this.Controls.Add(this.imagen_procesamiento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MisionCanon";
            this.Text = "Misión Cañón";
            this.Load += new System.EventHandler(this.MisionCanon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_procesamiento)).EndInit();
            this.grupo_controles.ResumeLayout(false);
            this.grupo_controles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen_procesamiento;
        private System.Windows.Forms.Button boton_Capturar;
        private System.Windows.Forms.GroupBox grupo_controles;
        private System.Windows.Forms.Button boton_D1;
        private System.Windows.Forms.Button boton_L1;
        private System.Windows.Forms.Button boton_D3;
        private System.Windows.Forms.Button boton_D2;
        private System.Windows.Forms.TextBox campo_longitud;
        private System.Windows.Forms.Button boton_calcular_volumen;
        private System.Windows.Forms.Button boton_longitudes;
    }
}