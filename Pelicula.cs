using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_KATIADOMINGUES_PROGRAII
{
    public class Pelicula
    {
        private string text1;
        private string text2;
        private DateTime value;
        private string text3;
        private string v;
        private string text4;
        private object p;

        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public float Precio { get; set; }
        public string Reseña { get; set; }
        public bool Alquilada { get; set; }
        public int Puntuacion { get; set; }
        public string ActorPrincipal { get; set; }




        public enum eGenero
        {
            Accion,
            CienciaFiccion,
            Comedia,
            Drama,
            Terror,
            Infantil
        }

        public eGenero Genero { get; set; }
        public string Director { get; set; }
        public int contadoralquiladas { get; set; }
        public int contadorvistas { get; set; }

        public Pelicula() { }//Constructor por defecto

        public Pelicula(Pelicula pelicula) //Constructor por copia
        {
            this.Nombre = pelicula.Nombre;
            this.Fecha = pelicula.Fecha;
            this.ActorPrincipal = pelicula.ActorPrincipal;
            this.Precio = pelicula.Precio;
            this.Reseña = pelicula.Reseña;
            this.Alquilada = pelicula.Alquilada;
            this.Genero = pelicula.Genero;
            this.Director = pelicula.Director;
            this.contadoralquiladas = pelicula.contadoralquiladas;
            this.contadorvistas = pelicula.contadorvistas;
            this.Puntuacion = pelicula.Puntuacion;
        }
        public Pelicula(string nombre, string actorprincipal, DateTime fecha, string reseña, eGenero genero, string director, int punt)
        {
            this.ActorPrincipal = actorprincipal;
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Precio = 50;
            this.Reseña = reseña;
            this.Alquilada = false;
            this.Genero = genero;
            this.Director = director;
            this.contadoralquiladas = 0;
            this.contadorvistas = 0;

            this.Puntuacion = punt;
        }

        public Pelicula(string text1, string text2, DateTime value, string text3, string v, string text4, object p)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.value = value;
            this.text3 = text3;
            this.v = v;
            this.text4 = text4;
            this.p = p;
        }
    }
}
