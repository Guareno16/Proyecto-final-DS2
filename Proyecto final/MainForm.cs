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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void añadirNuevoVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalles_Vuelo vuelo = new Detalles_Vuelo();
            vuelo.MdiParent = this;
            vuelo.Show();//abrira la ventana "Detalles_Vuelo" dentro de "Main Form".

        }

        private void añadirNueboClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalles_Cliente cliente = new Detalles_Cliente();
            cliente.MdiParent = this;
            cliente.Show();//abrira la ventana "Detalles_Cliente" dentro de "Main Form".
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Cliente buscar = new Buscar_Cliente();
            buscar.MdiParent = this;
            buscar.Show();//abrira la ventana "Buscar_Cliente" dentro de "Main Form".
        }

        private void reservarNuevoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservacion ticket = new Reservacion();
            ticket.MdiParent = this;
            ticket.Show();//abrira la ventana "Reservacion" dentro de "Main Form".
        }
    }
}
