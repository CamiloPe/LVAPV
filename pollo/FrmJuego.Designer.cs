
namespace pollo
{
    partial class FrmJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pctAbajo = new System.Windows.Forms.PictureBox();
            this.pctjugador = new System.Windows.Forms.PictureBox();
            this.pctArriba = new System.Windows.Forms.PictureBox();
            this.pctPiso = new System.Windows.Forms.PictureBox();
            this.tmrAnimacion = new System.Windows.Forms.Timer(this.components);
            this.tmrTubos = new System.Windows.Forms.Timer(this.components);
            this.lblPuntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctjugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAbajo
            // 
            this.pctAbajo.Image = global::pollo.Properties.Resources.Rectangulo;
            this.pctAbajo.Location = new System.Drawing.Point(192, 415);
            this.pctAbajo.Name = "pctAbajo";
            this.pctAbajo.Size = new System.Drawing.Size(87, 234);
            this.pctAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAbajo.TabIndex = 0;
            this.pctAbajo.TabStop = false;
            // 
            // pctjugador
            // 
            this.pctjugador.Image = global::pollo.Properties.Resources.pollow1;
            this.pctjugador.Location = new System.Drawing.Point(53, 243);
            this.pctjugador.Name = "pctjugador";
            this.pctjugador.Size = new System.Drawing.Size(95, 95);
            this.pctjugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctjugador.TabIndex = 1;
            this.pctjugador.TabStop = false;
            // 
            // pctArriba
            // 
            this.pctArriba.Image = global::pollo.Properties.Resources.Rectangulo2;
            this.pctArriba.Location = new System.Drawing.Point(184, 5);
            this.pctArriba.Name = "pctArriba";
            this.pctArriba.Size = new System.Drawing.Size(95, 216);
            this.pctArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctArriba.TabIndex = 2;
            this.pctArriba.TabStop = false;
            // 
            // pctPiso
            // 
            this.pctPiso.Image = global::pollo.Properties.Resources.Rectangulo;
            this.pctPiso.Location = new System.Drawing.Point(-20, 529);
            this.pctPiso.Name = "pctPiso";
            this.pctPiso.Size = new System.Drawing.Size(492, 51);
            this.pctPiso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPiso.TabIndex = 3;
            this.pctPiso.TabStop = false;
            // 
            // tmrAnimacion
            // 
            this.tmrAnimacion.Enabled = true;
            this.tmrAnimacion.Tick += new System.EventHandler(this.tmrAnimacion_Tick);
            // 
            // tmrTubos
            // 
            this.tmrTubos.Enabled = true;
            this.tmrTubos.Interval = 1;
            this.tmrTubos.Tick += new System.EventHandler(this.tmrTubos_Tick);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(64, 204);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(0, 17);
            this.lblPuntaje.TabIndex = 4;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pctPiso);
            this.Controls.Add(this.pctArriba);
            this.Controls.Add(this.pctjugador);
            this.Controls.Add(this.pctAbajo);
            this.Name = "FrmJuego";
            this.Text = "pollo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmJuego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pctAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctjugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAbajo;
        private System.Windows.Forms.PictureBox pctjugador;
        private System.Windows.Forms.PictureBox pctArriba;
        private System.Windows.Forms.PictureBox pctPiso;
        private System.Windows.Forms.Timer tmrAnimacion;
        private System.Windows.Forms.Timer tmrTubos;
        private System.Windows.Forms.Label lblPuntaje;
    }
}

