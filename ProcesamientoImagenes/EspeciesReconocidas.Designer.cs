namespace EstacionControl.ProcesamientoImagenes
{
    partial class EspeciesReconocidas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contadorCirculos = new System.Windows.Forms.Label();
            this.contadorCuadrados = new System.Windows.Forms.Label();
            this.contadorRectangulos = new System.Windows.Forms.Label();
            this.contadorTriangulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contadorCirculos
            // 
            this.contadorCirculos.AutoSize = true;
            this.contadorCirculos.Location = new System.Drawing.Point(491, 13);
            this.contadorCirculos.Name = "contadorCirculos";
            this.contadorCirculos.Size = new System.Drawing.Size(35, 13);
            this.contadorCirculos.TabIndex = 1;
            this.contadorCirculos.Text = "label1";
            // 
            // contadorCuadrados
            // 
            this.contadorCuadrados.AutoSize = true;
            this.contadorCuadrados.Location = new System.Drawing.Point(490, 34);
            this.contadorCuadrados.Name = "contadorCuadrados";
            this.contadorCuadrados.Size = new System.Drawing.Size(35, 13);
            this.contadorCuadrados.TabIndex = 2;
            this.contadorCuadrados.Text = "label1";
            // 
            // contadorRectangulos
            // 
            this.contadorRectangulos.AutoSize = true;
            this.contadorRectangulos.Location = new System.Drawing.Point(490, 57);
            this.contadorRectangulos.Name = "contadorRectangulos";
            this.contadorRectangulos.Size = new System.Drawing.Size(35, 13);
            this.contadorRectangulos.TabIndex = 3;
            this.contadorRectangulos.Text = "label2";
            // 
            // contadorTriangulos
            // 
            this.contadorTriangulos.AutoSize = true;
            this.contadorTriangulos.Location = new System.Drawing.Point(494, 74);
            this.contadorTriangulos.Name = "contadorTriangulos";
            this.contadorTriangulos.Size = new System.Drawing.Size(35, 13);
            this.contadorTriangulos.TabIndex = 4;
            this.contadorTriangulos.Text = "label3";
            // 
            // EspeciesReconocidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 361);
            this.Controls.Add(this.contadorTriangulos);
            this.Controls.Add(this.contadorRectangulos);
            this.Controls.Add(this.contadorCuadrados);
            this.Controls.Add(this.contadorCirculos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EspeciesReconocidas";
            this.Text = "EspeciesReconocidas";
            this.Load += new System.EventHandler(this.EspeciesReconocidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label contadorCirculos;
        private System.Windows.Forms.Label contadorCuadrados;
        private System.Windows.Forms.Label contadorRectangulos;
        private System.Windows.Forms.Label contadorTriangulos;
    }
}