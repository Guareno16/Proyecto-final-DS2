using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Detalles_Cliente : Form
    {
        AerolineaDBEntities1 db;

        static int id = 0;

        public Detalles_Cliente([Optional] int ? Id)
        {
            InitializeComponent();
            if (Id != null)
            {
                BotonGuardar.Visible = false;
                db = new AerolineaDBEntities1();
                Detalle_Clientes cliente = db.Detalle_Clientes.Where(a => a.Id == Id).FirstOrDefault();
                id = cliente.Id;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDireccion.Text = cliente.Direccion;
                txtNacimiento.Value = (DateTime)cliente.Fecha_de_Nacimiento;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
            }

            else 
            {
                BotonActualizar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AerolineaDBEntities1 db = new AerolineaDBEntities1();
            Detalle_Clientes Clientes = new Detalle_Clientes
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Fecha_de_Nacimiento = txtNacimiento.Value,
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };

            db.Detalle_Clientes.Add(Clientes);
            db.SaveChanges();

            MessageBox.Show("Datos guardados");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new AerolineaDBEntities1();
            Detalle_Clientes cliente = db.Detalle_Clientes.Where(a => a.Id == id).FirstOrDefault();
            cliente.Nombre = txtNombre.Text ;
            cliente.Apellido =txtApellido.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Fecha_de_Nacimiento = txtNacimiento.Value ;
            cliente.Email = txtEmail.Text ;
            cliente.Telefono = txtTelefono.Text;

            db.SaveChanges();

            MessageBox.Show("Datos Actualizados");
        }
    }
}
