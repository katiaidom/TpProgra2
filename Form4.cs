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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 retornar = new Form1();
            retornar.Show();

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (checkBoxterminos.Checked==true )
            {
                string contrasena = txtContras.Text;
                if (txtDni.Text == "" || contrasena == "")
                {
                    MessageBox.Show("Campo(s) incompleto");
                    return;
                }
                long dni = Convert.ToInt64(txtDni.Text);
                if (Form1.usuarios.EncontrarPosicion(dni) != -1)
                {
                    Usuario usu = new Usuario(dni, contrasena, false);
                    Form1.usuarios.Agregar(dni, usu);
                    this.Hide();
                    Form3 abrirusuario = new Form3();
                    abrirusuario.Show();

                }
                else
                {
                    MessageBox.Show("DNI ya registrado");
                    txtDni.Clear();
                }
            }
            else
            {
                MessageBox.Show("No vendiste tu alma!");
                return;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
