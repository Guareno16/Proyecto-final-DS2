using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AerolineaDBEntities1 db = new AerolineaDBEntities1();
            if (txtUsuario.Text != string.Empty && TxtContraseña.Text != string.Empty)/*si ambos cuadros de texto no estan vacios*/
            {
                var usuario = db.Admins.Where(a => a.Usuario.Equals(txtUsuario.Text)).SingleOrDefault(); 
                /*compara el valor de la columna "Usuario" de la tabla "Admin" con el valor introducido en el cuadro de texto.
                 En caso de ser verdadero, se guarda el valor en la variable usuario.
                 en caso de ser falso, tomara un valor "null"*/

                if (usuario != null)
                {
                    if (usuario.Contraseña.Equals(TxtContraseña.Text)) 
                    {
                        MessageBox.Show("Sesión iniciada exitosamente");
                        MainForm Mainform = new MainForm();
                        Mainform.Show();
                        TxtContraseña.Text = "";
                        this.WindowState = FormWindowState.Minimized;

                        /*Si el valor "Contraseña" de la tabla conincide con el valor
                        introducido en el cuadro de texto, entonces se incia la sesión
                        Abriendose la ventana principal(MainForm)*/
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta. Intentelo de nuevo por favor");

                    }

                }
                else 
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta. Intentelo de nuevo por favor");

                }
            }

            else 
            {
                MessageBox.Show("Favor de llenar todos los campos");

            }
        }
    }
}
