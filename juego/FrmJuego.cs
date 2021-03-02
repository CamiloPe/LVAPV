using System;
using System.Drawing;
using System.Windows.Forms;

namespace juego
{

    public partial class frmJuego : Form
    {
        int velocidad;
        Personaje pollo;

        public frmJuego()
        {
            //cubo morado es un metodo 
            //cubo azul es un atributo
            //llave inglesa propiedad
            velocidad = 1;
            InitializeComponent();
            pollo = new Personaje();
            pollo.

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X + pctPlayer.Size.Width + velocidad < grpCampo.Size.Width)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X + velocidad, pctPlayer.Location.Y);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.Y - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y - velocidad);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.Y + pctPlayer.Size.Height + velocidad < grpCampo.Size.Height)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y + velocidad);
            }
        }

        private void trcVelocidad_Scroll(object sender, EventArgs e)
        {
            velocidad = (int)trcVelocidad.Value;

            /*int vel = int.Parse(nmrVelocidadPlayer.Value.ToString());*/
            /*int vel = Convert.ToInt32(nmrVelocidadPlayer.Value.ToString());*/
            //int vel = (int)nmrVelocidadPlayer.Value;

        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A')
            {
                
            }
        }

        private void izquierda ()
        {
            if (pctPlayer.Location.X - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
            }
        }

    }
}
