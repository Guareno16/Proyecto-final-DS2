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
    public partial class Buscar_Cliente : Form
    {
        public Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void Buscar_Cliente_Load(object sender, EventArgs e)
        {
            AerolineaDBEntities1 db = new AerolineaDBEntities1();
            var Itemes = db.Detalle_Clientes.ToList();
            dataGridView1.DataSource = Itemes;
            //Al momento de abrir la ventana "Buscar_Cliente" se creará una tabla con los datos de los clientes"
        }


        private void txtUsuarioBuscador_TextChanged(object sender, EventArgs e)
        {
            AerolineaDBEntities1 db = new AerolineaDBEntities1();
            var Itemes = db.Detalle_Clientes.Where(a => a.Apellido.Equals(txtUsuarioBuscador.Text)).ToList();
            dataGridView1.DataSource = Itemes;
            //Mostrara en la tabla el usuario correspondiente al apellido escrito en el cuadro de texto"
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Detalles_Cliente c1 = new Detalles_Cliente(id);
            c1.ShowDialog();

            //Mostrara la ventana "Detalles_Cliente"con la informacion del cliente seleccioado

        }

    }
}
