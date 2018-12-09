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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            peliculaBindingSource.DataSource = Form1.Peliculas;
            pelicula_eGeneroBindingSource.DataSource = Enum.GetNames(typeof(Pelicula.eGenero));


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula(nombreTextBox.Text,actorPrincipalTextBox.Text, fechaDateTimePicker.Value, reseñaTextBox.Text, (Pelicula.eGenero)Enum.Parse(typeof(Pelicula.eGenero), pelicula_eGeneroComboBox.SelectedItem.ToString()), directorTextBox.Text, Convert.ToInt16(puntuacionTextBox.Text));

            Form1.Peliculas.Add(pelicula);
            peliculaBindingSource.Position = peliculaBindingSource.IndexOf(pelicula);
            peliculaBindingSource.EndEdit();
            peliculaBindingSource.ResetBindings(false);

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int index = peliculaDataGridView.SelectedRows[0].Index;

            peliculaBindingSource.RemoveAt(index);
            peliculaBindingSource.EndEdit();
            peliculaBindingSource.ResetBindings(false);
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            int index = peliculaDataGridView.SelectedRows[0].Index;
            Form1.Peliculas[index].Precio = Form1.Peliculas[index].Precio / 2;

            peliculaBindingSource.EndEdit();
            peliculaBindingSource.ResetBindings(false);

        }
    }
}
