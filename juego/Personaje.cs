using System.Drawing;

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
        private int vida;
        #endregion

        #region propiedades
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
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
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
        //el metodo construntor no regresa nada de preferencia se usa el atributo
        public Personaje()
        {
            this.nombre = "pollo";
            this.vida = 100;
            this.velocidad = 10;
            this.posicion = new Point(0, 0);
            this.tamanio = new Size(100, 100);
        }

        #endregion
    }
}
