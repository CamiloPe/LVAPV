using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pollo
{
    public partial class FrmJuego : Form
    {
        int contMovimientos = 1;
        bool volar = false;
        int distancia = 0;
        Random Posicion = new Random();

        public FrmJuego()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public void IniciarJuego()
        {
            pctjugador.Location = new Point(19, 225);
            distancia = Posicion.Next(-160, 118);
            pctArriba.Location = new Point(270, -173 - distancia);
            pctAbajo.Location = new Point(270, -173 - distancia);
            lblPuntaje.Text = "0";
        }
    

        private void tmrAnimacion_Tick(object sender, EventArgs e)
        {
            int cantMovimientos = 5;
            if (contMovimientos <= cantMovimientos)
            {
                pctjugador.Image = Properties.Resources.pollow2;
                contMovimientos++;
            }
            if ((contMovimientos > cantMovimientos / 2) && (contMovimientos <= cantMovimientos * 2))
            {
                pctjugador.Image = Properties.Resources.pollow1;
                contMovimientos++;     
            }
            contMovimientos = (contMovimientos > cantMovimientos) ? 0 : contMovimientos;

            int x = pctjugador.Location.X;
            int y = pctjugador.Location.Y;

            if (volar)
            {
                y = y - 15;
                volar = false;
            }
            else
            {
                y = y+5;
            }

            pctjugador.Location = new Point(pctjugador.Location.X, y);

            if((pctjugador.Bounds.IntersectsWith(pctPiso.Bounds)) || 
                (pctjugador.Bounds.IntersectsWith(pctArriba.Bounds)) || 
                (pctjugador.Bounds.IntersectsWith(pctAbajo.Bounds)))
            {
                IniciarJuego();
            }

            /*lblPuntaje.Location = new Point(pctjugador.Location.X + 30, pctjugador.Location.Y - 25);
            lblPuntaje.Text = (pctArriba.Location.X == pctjugador.Location.X) ? 
                Convert.ToString((Convert.ToInt32(lblPuntaje.Text) + 1)).ToString() : lblPuntaje.Text;*/
            
        }

        private void FrmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Space))
            {
                volar = true;
            }
        }

        private void tmrTubos_Tick(object sender, EventArgs e)
        {
            if (pctAbajo.Location.X > -140)
            {
                pctAbajo.Location = new Point((pctAbajo.Location.X) - 1, pctAbajo.Location.Y);
                pctArriba.Location = new Point((pctArriba.Location.X) - 1, pctArriba.Location.Y);
            }
            else
            {
                distancia = Posicion.Next(-170, 118);
                pctAbajo.Location = new Point(400, 319 + distancia);
                pctArriba.Location = new Point(400, -173 + distancia);
            }
        }
    }
}
