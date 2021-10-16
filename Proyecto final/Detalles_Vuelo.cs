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
    public partial class Detalles_Vuelo : Form
    {
        AerolineaDBEntities1 db;

        public Detalles_Vuelo()
        {
            InitializeComponent();
            db = new AerolineaDBEntities1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detalle_Vuelos dv = new Detalle_Vuelos();
            dv.Nombre_Vuelo  = txtNombre_Vuelo.Text;
            dv.Origen_Vuelo  = txtOrigen_Vuelo.Text;
            dv.Destino_Vuelo = txtDestino_Vuelo.Text;
            dv.Salida_Tiempo = txtSalida_Tiempo.Text;
            dv.Llegada_Tiempo = txtLlegada_Tiempo.Text;
            dv.Clase_Vuelo = txtClase_Vuelo.Text;
            dv.Cargos_Vuelo = Convert.ToDecimal(txtCargos_Vuelo.Text);
            dv.Asientos = Convert.ToInt16(txtAsientos.Text);
            db.Detalle_Vuelos.Add(dv);
            db.SaveChanges();
            MessageBox.Show("Detalles guardados");

            /*El metodo "button1_Click" (hacer click en el boton AÑADIR VUELO) tomara los valores introducidos en los cuadros de texto y los guardará
             en una nueva fila de la tabla "Detalle_Vuelos"*/
        }
    }
}
