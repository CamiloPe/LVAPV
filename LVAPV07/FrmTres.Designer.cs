
namespace LVAPV07
{
    partial class FrmTres
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
            this.lblFormaTres = new System.Windows.Forms.Label();
            this.btnLlamarFormaDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormaTres
            // 
            this.lblFormaTres.AutoSize = true;
            this.lblFormaTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaTres.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFormaTres.Location = new System.Drawing.Point(71, 50);
            this.lblFormaTres.Name = "lblFormaTres";
            this.lblFormaTres.Size = new System.Drawing.Size(113, 25);
            this.lblFormaTres.TabIndex = 0;
            this.lblFormaTres.Text = "Forma Tres";
            // 
            // btnLlamarFormaDos
            // 
            this.btnLlamarFormaDos.Location = new System.Drawing.Point(74, 172);
            this.btnLlamarFormaDos.Name = "btnLlamarFormaDos";
            this.btnLlamarFormaDos.Size = new System.Drawing.Size(431, 23);
            this.btnLlamarFormaDos.TabIndex = 1;
            this.btnLlamarFormaDos.Text = "llamar forma dos";
            this.btnLlamarFormaDos.UseVisualStyleBackColor = true;
            this.btnLlamarFormaDos.Click += new System.EventHandler(this.btnLlamarFormaDos_Click);
            // 
            // FrmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamarFormaDos);
            this.Controls.Add(this.lblFormaTres);
            this.Name = "FrmTres";
            this.Text = "FrmTres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaTres;
        private System.Windows.Forms.Button btnLlamarFormaDos;
    }
}