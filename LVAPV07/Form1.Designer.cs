
namespace LVAPV07
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLlamarFormaDos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btmLlamarFormaTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnLlamarFormaDos
            // 
            this.btnLlamarFormaDos.Location = new System.Drawing.Point(329, 285);
            this.btnLlamarFormaDos.Name = "btnLlamarFormaDos";
            this.btnLlamarFormaDos.Size = new System.Drawing.Size(243, 23);
            this.btnLlamarFormaDos.TabIndex = 1;
            this.btnLlamarFormaDos.Text = "Llamar a forma fos";
            this.btnLlamarFormaDos.UseVisualStyleBackColor = true;
            this.btnLlamarFormaDos.Click += new System.EventHandler(this.btnLlamarFormaDos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(131, 285);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btmLlamarFormaTres
            // 
            this.btmLlamarFormaTres.Location = new System.Drawing.Point(329, 314);
            this.btmLlamarFormaTres.Name = "btmLlamarFormaTres";
            this.btmLlamarFormaTres.Size = new System.Drawing.Size(243, 23);
            this.btmLlamarFormaTres.TabIndex = 4;
            this.btmLlamarFormaTres.Text = "llamar a forma tres";
            this.btmLlamarFormaTres.UseVisualStyleBackColor = true;
            this.btmLlamarFormaTres.Click += new System.EventHandler(this.btmLlamarFormaTres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmLlamarFormaTres);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLlamarFormaDos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLlamarFormaDos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btmLlamarFormaTres;
    }
}

