namespace EstacionControl
{
    partial class CodigoQR
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
            this.label1 = new System.Windows.Forms.Label();
            this.cuadro_QR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cuadro_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de acceso a Streaming";
            // 
            // cuadro_QR
            // 
            this.cuadro_QR.Location = new System.Drawing.Point(38, 49);
            this.cuadro_QR.Name = "cuadro_QR";
            this.cuadro_QR.Size = new System.Drawing.Size(150, 150);
            this.cuadro_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuadro_QR.TabIndex = 0;
            this.cuadro_QR.TabStop = false;
            // 
            // CodigoQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuadro_QR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodigoQR";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodigoQR";
            this.Load += new System.EventHandler(this.CodigoQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuadro_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cuadro_QR;
        private System.Windows.Forms.Label label1;
    }
}