namespace EstacionControl.Ventanas
{
    partial class CamaraPanel
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
            this.etiqueta_camara1 = new System.Windows.Forms.Label();
            this.campo_ipCamara1 = new System.Windows.Forms.TextBox();
            this.campo_puertoCamara1 = new System.Windows.Forms.TextBox();
            this.campo_puertoCamara2 = new System.Windows.Forms.TextBox();
            this.campo_ipCamara2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campo_puertoCamara3 = new System.Windows.Forms.TextBox();
            this.campo_ipCamara3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_actualizarCamaras = new System.Windows.Forms.Button();
            this.descripcionCamaras = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // etiqueta_camara1
            // 
            this.etiqueta_camara1.AutoSize = true;
            this.etiqueta_camara1.Location = new System.Drawing.Point(12, 9);
            this.etiqueta_camara1.Name = "etiqueta_camara1";
            this.etiqueta_camara1.Size = new System.Drawing.Size(52, 13);
            this.etiqueta_camara1.TabIndex = 0;
            this.etiqueta_camara1.Text = "Cámara 1";
            // 
            // campo_ipCamara1
            // 
            this.campo_ipCamara1.Location = new System.Drawing.Point(70, 6);
            this.campo_ipCamara1.MaxLength = 15;
            this.campo_ipCamara1.Name = "campo_ipCamara1";
            this.campo_ipCamara1.Size = new System.Drawing.Size(100, 20);
            this.campo_ipCamara1.TabIndex = 1;
            this.campo_ipCamara1.Text = "192.168.0.7";
            this.campo_ipCamara1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campo_puertoCamara1
            // 
            this.campo_puertoCamara1.Location = new System.Drawing.Point(176, 6);
            this.campo_puertoCamara1.MaxLength = 4;
            this.campo_puertoCamara1.Name = "campo_puertoCamara1";
            this.campo_puertoCamara1.Size = new System.Drawing.Size(61, 20);
            this.campo_puertoCamara1.TabIndex = 2;
            this.campo_puertoCamara1.Text = "9000";
            this.campo_puertoCamara1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campo_puertoCamara2
            // 
            this.campo_puertoCamara2.Location = new System.Drawing.Point(176, 32);
            this.campo_puertoCamara2.MaxLength = 4;
            this.campo_puertoCamara2.Name = "campo_puertoCamara2";
            this.campo_puertoCamara2.Size = new System.Drawing.Size(61, 20);
            this.campo_puertoCamara2.TabIndex = 5;
            this.campo_puertoCamara2.Text = "9001";
            this.campo_puertoCamara2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campo_ipCamara2
            // 
            this.campo_ipCamara2.Location = new System.Drawing.Point(70, 32);
            this.campo_ipCamara2.MaxLength = 15;
            this.campo_ipCamara2.Name = "campo_ipCamara2";
            this.campo_ipCamara2.Size = new System.Drawing.Size(100, 20);
            this.campo_ipCamara2.TabIndex = 4;
            this.campo_ipCamara2.Text = "192.168.0.7";
            this.campo_ipCamara2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cámara 2";
            // 
            // campo_puertoCamara3
            // 
            this.campo_puertoCamara3.Location = new System.Drawing.Point(176, 58);
            this.campo_puertoCamara3.MaxLength = 4;
            this.campo_puertoCamara3.Name = "campo_puertoCamara3";
            this.campo_puertoCamara3.Size = new System.Drawing.Size(61, 20);
            this.campo_puertoCamara3.TabIndex = 8;
            this.campo_puertoCamara3.Text = "9000";
            this.campo_puertoCamara3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campo_ipCamara3
            // 
            this.campo_ipCamara3.Location = new System.Drawing.Point(70, 58);
            this.campo_ipCamara3.MaxLength = 15;
            this.campo_ipCamara3.Name = "campo_ipCamara3";
            this.campo_ipCamara3.Size = new System.Drawing.Size(100, 20);
            this.campo_ipCamara3.TabIndex = 7;
            this.campo_ipCamara3.Text = "192.168.0.8";
            this.campo_ipCamara3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cámara 3";
            // 
            // boton_actualizarCamaras
            // 
            this.boton_actualizarCamaras.Location = new System.Drawing.Point(176, 84);
            this.boton_actualizarCamaras.Name = "boton_actualizarCamaras";
            this.boton_actualizarCamaras.Size = new System.Drawing.Size(61, 46);
            this.boton_actualizarCamaras.TabIndex = 9;
            this.boton_actualizarCamaras.Text = "Guardar cambios";
            this.boton_actualizarCamaras.UseVisualStyleBackColor = true;
            this.boton_actualizarCamaras.Click += new System.EventHandler(this.boton_actualizarCamaras_Click);
            // 
            // descripcionCamaras
            // 
            this.descripcionCamaras.IsBalloon = true;
            // 
            // CamaraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 137);
            this.ControlBox = false;
            this.Controls.Add(this.boton_actualizarCamaras);
            this.Controls.Add(this.campo_puertoCamara3);
            this.Controls.Add(this.campo_ipCamara3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campo_puertoCamara2);
            this.Controls.Add(this.campo_ipCamara2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campo_puertoCamara1);
            this.Controls.Add(this.campo_ipCamara1);
            this.Controls.Add(this.etiqueta_camara1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamaraPanel";
            this.ShowInTaskbar = false;
            this.Text = "Configuración de cámaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqueta_camara1;
        private System.Windows.Forms.TextBox campo_ipCamara1;
        private System.Windows.Forms.TextBox campo_puertoCamara1;
        private System.Windows.Forms.TextBox campo_puertoCamara2;
        private System.Windows.Forms.TextBox campo_ipCamara2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campo_puertoCamara3;
        private System.Windows.Forms.TextBox campo_ipCamara3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_actualizarCamaras;
        private System.Windows.Forms.ToolTip descripcionCamaras;
    }
}