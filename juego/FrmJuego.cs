using System;
using System.Drawing;
using System.Windows.Forms;

namespace juego
{

    public partial class frmJuego : Form
    {
        int velocidad;
        Personaje pollo;
        Personaje planta;

        public frmJuego()
        {
            //cubo morado es un metodo 
            //cubo azul es un atributo
            //llave inglesa propiedad
            
            InitializeComponent();
            velocidad = 10;
            //pollo = new Personaje("pollo", 100, 10, new Point(10, 10), new Size(10, 10));
            //planta = new Personaje("planta", 100, 10, new Point(10, 10), new Size(10, 10));
            //MessageBox.Show(planta.ToString());
            //planta.Velocidad = 2;
            //planta.AgregarVelocidad(-1);
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
            pollo.Mover(e.KeyChar);
            pctPlayer.Location = pollo.Posicion;
            if(pctPlayer.Bounds.IntersectsWith(pctEnemigo.Bounds))
            {
                MessageBox.Show("kaboom");
            }
        }

        private void izquierda ()
        {
            
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            pollo = new Personaje();
            pctPlayer.Location = pollo.Posicion;
            pctPlayer.Size = pollo.Tamanio;
            pctPlayer.Image = pollo.Sprite;
        }
    }
}
