using System.Drawing;
using System.Windows.Forms;

namespace juego
{
    public class Personaje
    {
        #region atributos
        //qui van los atributos 
        private Point posicion;
        //los atributos de preferencia son provados
        private Size tamanio;
        private int velocidad;
        private string nombre;
        private string fileName;
        private int vida;
        private Image sprite;
        #endregion

        #region propiedades
        public Image Sprite
        {
            get { return this.sprite; }
            set { this.sprite = value;  }
        }
        public int Vida 
        { 
            get { return this.vida; }
            //signo de interrogacion es el if y los dos puntos es el else

            set { this.vida = (0<= value && value <=100)?value:this.vida; } 
            /*set 
            {
                if(0 <= value && value <= 100)
                {
                    this.vida = value;
                }
                else
                {
                    this.vida = this.vida;
                }
            }*/
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = (1 < value && value <= 10) ? value : this.vida; }
        }
        public Point Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        public Size Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }
        #endregion

        #region metodos
        #region constructores
        
        //constructor por defecto
        //el metodo construntor no regresa nada de preferencia se usa el atributo
        public Personaje()
        {
            this.nombre = "pollo";
            this.vida = 100;
            this.velocidad = 10;
            this.posicion = new Point(0, 0);
            this.tamanio = new Size(200, 200);
            this.FileName = @"C:\Users\camil\Desktop\proyectos juegos\godot plataform 1\FB pirata\\pollo.png";
            this.Sprite = Bitmap.FromFile(this.FileName);
        }
        //constructor sobrecargado
        // ctor tab tab para crear rapido
        public Personaje(string nombre, int vida, int velocidad)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.velocidad = velocidad;
            this.posicion = new Point(0, 0);
            this.tamanio = new Size(100, 100);
        }

        public Personaje(string nombre, int vida, int velocidad, Point posicion, Size tamanio)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.velocidad = velocidad;
            this.posicion = posicion;
            this.tamanio = tamanio;
        }
        #endregion
        //sobreescritura

        #region metodos genericos
        public override string ToString()
        {
            return $"nombre de personaje:{this.Nombre}-\nvida:{this.Vida}-\nvelocidad:{this.Velocidad}-\nposicion:{this.Posicion}-\ntamaño:{this.Tamanio}";
        }

        public void AgregarVelocidad(int velocidad)
        {
            if (velocidad > 0 && this.velocidad + velocidad <= 10)
            {
                this.velocidad += velocidad;
            }
            else if (velocidad < 0 && this.velocidad - velocidad > 0)
            {
                this.velocidad += velocidad;
            }
        }

        public void Mover (char tecla)
        {
            if(tecla == 'a' || tecla == 'A')
            {
                this.Posicion = new Point(this.Posicion.X - velocidad, this.Posicion.Y) ;
            }
            if (tecla == 'd' || tecla == 'D')
            {
                this.Posicion = new Point(this.Posicion.X + velocidad, this.Posicion.Y);
            }
            if (tecla == 's' || tecla == 'S')
            {
                this.Posicion = new Point(this.Posicion.X, this.Posicion.Y + velocidad);
            }
            if (tecla == 'w' || tecla == 'W')
            {
                this.Posicion = new Point(this.Posicion.X, this.Posicion.Y - velocidad);
            }
        }
        #endregion



        #endregion
    }
}
