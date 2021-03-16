
namespace juego
{
    partial class frmJuego
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
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.nmrVelocidadPlayer = new System.Windows.Forms.NumericUpDown();
            this.trcVelocidad = new System.Windows.Forms.TrackBar();
            this.pctEnemigo = new System.Windows.Forms.PictureBox();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.grpCampo = new System.Windows.Forms.GroupBox();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemigo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrVelocidadPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            this.grpCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(848, 551);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 1;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(1010, 551);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(929, 522);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 3;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(929, 551);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 4;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // nmrVelocidadPlayer
            // 
            this.nmrVelocidadPlayer.Location = new System.Drawing.Point(848, 580);
            this.nmrVelocidadPlayer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrVelocidadPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrVelocidadPlayer.Name = "nmrVelocidadPlayer";
            this.nmrVelocidadPlayer.Size = new System.Drawing.Size(237, 22);
            this.nmrVelocidadPlayer.TabIndex = 5;
            this.nmrVelocidadPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // trcVelocidad
            // 
            this.trcVelocidad.Location = new System.Drawing.Point(738, 546);
            this.trcVelocidad.Minimum = 1;
            this.trcVelocidad.Name = "trcVelocidad";
            this.trcVelocidad.Size = new System.Drawing.Size(104, 56);
            this.trcVelocidad.TabIndex = 6;
            this.trcVelocidad.Value = 1;
            this.trcVelocidad.Scroll += new System.EventHandler(this.trcVelocidad_Scroll);
            // 
            // pctEnemigo
            // 
            this.pctEnemigo.Image = global::juego.Properties.Resources.pinshi_flama_mrda;
            this.pctEnemigo.Location = new System.Drawing.Point(425, 354);
            this.pctEnemigo.Name = "pctEnemigo";
            this.pctEnemigo.Size = new System.Drawing.Size(145, 190);
            this.pctEnemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEnemigo.TabIndex = 7;
            this.pctEnemigo.TabStop = false;
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::juego.Properties.Resources.polloimagen;
            this.pctPlayer.Location = new System.Drawing.Point(232, 120);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(100, 115);
            this.pctPlayer.TabIndex = 0;
            this.pctPlayer.TabStop = false;
            this.pctPlayer.Click += new System.EventHandler(this.pctPlayer_Click);
            // 
            // grpCampo
            // 
            this.grpCampo.Controls.Add(this.pctPlayer);
            this.grpCampo.Controls.Add(this.pctEnemigo);
            this.grpCampo.Location = new System.Drawing.Point(23, 30);
            this.grpCampo.Name = "grpCampo";
            this.grpCampo.Size = new System.Drawing.Size(629, 572);
            this.grpCampo.TabIndex = 8;
            this.grpCampo.TabStop = false;
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // tmrEnemigo
            // 
            this.tmrEnemigo.Interval = 500;
            this.tmrEnemigo.Tick += new System.EventHandler(this.tmrEnemigo_Tick);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 629);
            this.Controls.Add(this.grpCampo);
            this.Controls.Add(this.trcVelocidad);
            this.Controls.Add(this.nmrVelocidadPlayer);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmJuego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.nmrVelocidadPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            this.grpCampo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.NumericUpDown nmrVelocidadPlayer;
        private System.Windows.Forms.TrackBar trcVelocidad;
        private System.Windows.Forms.PictureBox pctEnemigo;
        private System.Windows.Forms.GroupBox grpCampo;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.Timer tmrEnemigo;
    }
}

