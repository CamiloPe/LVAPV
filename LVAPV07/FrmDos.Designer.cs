
namespace LVAPV07
{
    partial class FrmDos
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
            this.lblFormaDos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormaDos
            // 
            this.lblFormaDos.AutoSize = true;
            this.lblFormaDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFormaDos.Location = new System.Drawing.Point(36, 85);
            this.lblFormaDos.Name = "lblFormaDos";
            this.lblFormaDos.Size = new System.Drawing.Size(77, 17);
            this.lblFormaDos.TabIndex = 0;
            this.lblFormaDos.Text = "Forma Dos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(39, 163);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LVAPV07.Properties.Resources._25se;
            this.pictureBox1.Location = new System.Drawing.Point(181, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFormaDos);
            this.Name = "FrmDos";
            this.Text = "FrmDos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaDos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}