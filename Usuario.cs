using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_KATIADOMINGUES_PROGRAII
{
    public class Usuario
    {
        public long DNI { get; set; }
        public string CONTRA { get; set; }
        public Boolean esAdmin { get; set; }

        List<Pelicula> listaPeliculasAlq = new List<Pelicula>();



        public Usuario(long dni, string contraseña, Boolean admin)
        {
            DNI = dni;
            CONTRA = contraseña;
            esAdmin = admin;

        }

        public void PeliculasAlq(Pelicula peli)
        {
            listaPeliculasAlq.Add(peli);
        }



    }
}
