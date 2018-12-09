using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL_KATIADOMINGUES_PROGRAII
{
    public partial class Form1 : Form
    {
        public static HASH usuarios = new HASH();
        public static List<Pelicula> Peliculas = new List<Pelicula>();

        public Form1()
        {
            InitializeComponent();

            crearUsuarios();

            if (Peliculas.Count == 0)
                crearPeliculas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 abrirnuevousuario = new Form4();
            abrirnuevousuario.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            long dni = Convert.ToInt64(txtDNI.Text);
            string contra = txtContra.Text;
            Boolean ingresamo = iniciarsesion(dni, contra);

            if(ingresamo == false)
            {
                txtContra.Clear();
                txtDNI.Clear();
            }

            else
            {
                if(Form1.usuarios.HL[Form1.usuarios.Buscar(dni)].usuario.esAdmin==true)
                {
                    this.Hide();
                    Form2 abriradmin = new Form2();
                    abriradmin.Show();
                }

                else
                {
                    this.Hide();
                    Form3 abrirusuario = new Form3();
                    abrirusuario.Show();
                }
            }

        }

        public Boolean iniciarsesion(long dni, string contra)
        {
            long p = Form1.usuarios.Buscar(dni);
            if (p == -1)
            {
                MessageBox.Show("DNI no registrado!");
                return false;
            }
            else
            {
                if (contra == Form1.usuarios.HL[p].usuario.CONTRA)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta!");
                    return false;
                }
            }
            
        }

        void crearPeliculas()
        {
            Pelicula pelicula1, pelicula2, pelicula3;

            
            pelicula1 = new Pelicula("Toy Story","Woody", DateTime.Parse("19/11/1995"), "Cuando no los ves," +
                " los juguetes cobran vida", Pelicula.eGenero.Infantil, "Jere Hassan", 5);
            Peliculas.Add(pelicula1);

            
            pelicula2 = new Pelicula("IT", "Tim Curry", DateTime.Parse("18/11/1990"), "Un tranquilo y pequeño " +
                "pueblo de Maine está siendo aterrorizado por una fuerza malévola oculta tras la máscara" +
                " de un payaso, y que tan sólo se la conoce como It. Tras sus primeras víctimas, una pandilla" +
                " formada por siete amigos de la infancia dedicen volver a reunirse para atacar el mal y destruirlo," +
                " intentando librar así del terror a su pueblo natal.", Pelicula.eGenero.Terror, "Mark Bacino", 4);
            Peliculas.Add(pelicula2);

            
            pelicula3 = new Pelicula("El diario de Bridget Jones","Renee Zellweger", DateTime.Parse("13/09/2001"), "Bridget" +
                " Jones es una mujer londinense de 32 años llena de complejos cuya vida sentimental está en " +
                "perpetua crisis.", Pelicula.eGenero.Comedia, "Sharon Maguire", 3);
            Peliculas.Add(pelicula3);
            
        }
        void crearUsuarios()
        {
            Usuario usuario = new Usuario(39210289, "ferrante", false);
            usuarios.Agregar(usuario.DNI, usuario);


            Usuario usuario1 = new Usuario(40951402, "katikat", true);
            usuarios.Agregar(usuario1.DNI, usuario1);
            
        }

    }
}
