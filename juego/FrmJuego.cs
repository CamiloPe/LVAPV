using System;
using System.Drawing;
using System.Windows.Forms;

namespace juego
{

    public partial class frmJuego : Form
    {
        int velocidad;
        int positionFrame;
        Personaje Link;
        Personaje planta;
        Personaje enemigo;

        public frmJuego()
        {
            //cubo morado es un metodo 
            //cubo azul es un atributo
            //llave inglesa propiedad
            
            InitializeComponent();
            velocidad = 10;
            positionFrame = 0;
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
            Link.Mover(e.KeyChar);
            pctPlayer.Location = Link.Posicion;
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
            Link = new Personaje("Link", @"C:\\Users\\camil\\Desktop\\Shcuela\\LVA\\RepositorioUno\\LVAPV\\slime1.png", 100, 10, new Point(0,0), new Size(120,120));
            pctPlayer.Location = Link.Posicion;
            pctPlayer.Size = Link.Tamanio;
            pctPlayer.Image = Link.GetFrame(0);
            enemigo = new Personaje("Link", @"C:\\Users\\camil\\Desktop\\Shcuela\\LVA\\RepositorioUno\\LVAPV\\slime1.png", 100, 10, new Point(300, 300), new Size(120, 120));
            pctEnemigo.Location = enemigo.Posicion;
            pctEnemigo.Size = enemigo.Tamanio;
            pctEnemigo.Image = Link.GetFrame(20);
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if(positionFrame < 40)
            {
                pctPlayer.Image = Link.GetFrame(positionFrame);
                positionFrame++;
            }else
            {
                positionFrame = 0;
            }
        }

        private void tmrEnemigo_Tick(object sender, EventArgs e)
        {
            if (positionFrame < 40)
            {
                pctPlayer.Image = Link.GetFrame(positionFrame);
                positionFrame++;
            }
            else
            {
                positionFrame = 0;
            }
        }

        private void pctPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
