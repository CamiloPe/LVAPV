using System.Drawing;

namespace pollo
{
    public class Personaje
    {
        #region atributos
        private int velocidad;
        private string nombre;
        private int vida;
        #endregion
        #region propiedades
        public int Vida
        {
            get { return this.vida; }
            set { this.vida = (0 <= value && value <= 1) ? value : this.vida; }

        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = (1 < value && value <= 10) ? value : this.vida; }
        }
        #endregion
        public Personaje()
        {
            this.nombre = "pollo";
            this.vida = 1;
            this.velocidad = 5;
        }
        // ctor tab tab para crear rapido
        public Personaje(string nombre, string fileName, int vida, int velocidad)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.velocidad = velocidad;
        }
        public Personaje(string nombre, string fileName, int vida, int velocidad,
            Point posicion, Size tamanio)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.velocidad = velocidad;
        }
        #region metodos genericos
        public override string ToString()
        {
            return $"nombre de personaje:{this.Nombre}-\nvida:{this.Vida}-\nvelocidad:{this.Velocidad}";
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
        #endregion
    }
}
