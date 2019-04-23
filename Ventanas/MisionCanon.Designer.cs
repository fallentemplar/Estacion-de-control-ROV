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
            ((System.ComponentModel.ISupportInitialize)(this.imagen_procesamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen_procesamiento
            // 
            this.imagen_procesamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagen_procesamiento.Location = new System.Drawing.Point(0, 0);
            this.imagen_procesamiento.Margin = new System.Windows.Forms.Padding(0);
            this.imagen_procesamiento.Name = "imagen_procesamiento";
            this.imagen_procesamiento.Size = new System.Drawing.Size(304, 216);
            this.imagen_procesamiento.TabIndex = 0;
            this.imagen_procesamiento.TabStop = false;
            this.imagen_procesamiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ObtenerCoordenadasMouse);
            // 
            // MisionCanon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 216);
            this.ControlBox = false;
            this.Controls.Add(this.imagen_procesamiento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MisionCanon";
            this.Text = "Misión Cañón";
            this.Load += new System.EventHandler(this.MisionCanon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen_procesamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen_procesamiento;
    }
}