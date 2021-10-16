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
    public partial class Reservacion : Form
    {
        AerolineaDBEntities1 db;


        public Reservacion()
        {
            InitializeComponent();
            db = new AerolineaDBEntities1();

            BindOrigenCombox();
            BindDestinoCombox();
            //se invocan dos metodos: Uno para el Combox de origen y otro para el destino//
        }


        private void BindDestinoCombox()
        {
            var itemes = db.Detalle_Vuelos.ToList();
            DestinoCombox.DataSource = itemes;
            DestinoCombox.DisplayMember = "Destino_Vuelo";
           /*El metodo BindDestinoCombox Utiliza como recurso los valores de la columna "Destino_Vuelo" de la tabla 
           "Detalle_Vuelos" y los muestra en el Combox */
           
        }

        private void BindOrigenCombox()
        {
            var itemes = db.Detalle_Vuelos.ToList();
            OrigenCombox.DataSource = itemes;
            OrigenCombox.DisplayMember = "Origen_Vuelo";
            /*El metodo BindOrigenCombox Utiliza como recurso los valores de la columna "Origen_Vuelo" de la tabla 
            "Detalle_Vuelos" */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OrigenCombox.Text != DestinoCombox.Text)
            {
                dataGridView1.DataSource = db.Detalle_Vuelos.Where(a => a.Origen_Vuelo.Equals(OrigenCombox.Text)
                && a.Destino_Vuelo.Equals(DestinoCombox.Text)).ToList();
                
            }

            else 
            {
                MessageBox.Show("El destino y el origen deben ser distintos");
                
            }

            /*El metodo "button1_Click"(boton MOSTRAR) hara una lista en el dataGridView1 indicando los vuelos que conicidan en cuanto a 
             Origen y destino de la tabla "Detalle_Vuelos"*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtIDCLIENTE.Text);
            var itemes = db.Detalle_Clientes.Where(a => a.Id == id).FirstOrDefault();

            if (itemes == null) /*En caso de que el valor ID devueldo de la variable "itemes" sera null, es decir, que no exista en la tabla "Detalle_Clientes" */
            {
                MessageBox.Show("ID introducido no corresponde a un cliente. intentelo de nuevo");
            }

            else { 
            txtNOMBRECLIENTE.Text = itemes.Nombre;
            txtAPELLIDOCLIENTE.Text = itemes.Apellido;
            dateTimePicker1.Value = (DateTime)itemes.Fecha_de_Nacimiento;
            txtEMAILCLIENTE.Text = itemes.Email;
            txtTELEFCLIENTE.Text = itemes.Telefono;
            txtDIRECCION.Text = itemes.Direccion;

            }

            /*El metodo button3_Click(hacer click en el boton BUSCAR) hara un consulta a la tabla "Detalle_Clientes" del ID del usuario y llenará
            los cuadros de texto correspondientes a los datos del usuario a modo un "resumen"*/

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var IDvuelo = dataGridView1.SelectedRows[0].Cells[0].Value;
            txtIDVUELO.Text = IDvuelo.ToString();

            /*El metodo dataGridView1_CellClick(hacer click en el id de un vuelo) tomara el ID de vuelo seleccionao del dataGridView1
             * y lo colocará en cuadro de texto correspondiente*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtASIENTOCLIENTE.Text) <= 110)
            {


                if (AsientosDisponibles() == true)
                {

                    Ticket Ticket = new Ticket();
                    Ticket.Cliente_ID = Convert.ToInt32(txtIDCLIENTE.Text);
                    Ticket.Cliente_FECHADEVIEAJE = dateTimePicker2.Value;
                    Ticket.CLIENTE_IDVUELO = Convert.ToInt32(txtIDVUELO.Text);
                    Ticket.CLLIENTE_ASIENTO_ = Convert.ToInt32(txtASIENTOCLIENTE.Text);

                    db.Tickets.Add(Ticket);
                    db.SaveChanges();

                    MessageBox.Show("Ticket Reservado excitosamente.");


                }

                else
                {
                    MessageBox.Show("Asiento reservado por otro CLiente. Intentelo de nuevo");

                }
                /*Condicional if invocando al metodo booleano "AsientosDisponibles" y comparandolo. en caso de que
                 sea verdadero, guardará en la tabla Tickets los parámetros indicados en los cuadros de texto*/

            }

            else 
            {

                MessageBox.Show("El número de asiento debe ser menor o igual a 110");
            
            }
            /* el metodo button2_Click(hacer click el boton RESERVAR) guardará los datos de vuelo en la tabla "Tickets" */
        }



        private bool AsientosDisponibles()
        {
            int IDVUELO = Convert.ToInt32(txtIDVUELO.Text);
            int ASIENTONo = Convert.ToInt32(txtASIENTOCLIENTE.Text);    
            string FECHAVUELO = dateTimePicker2.Value.ToString("dd/MM/yyy");
            var itemes = db.Tickets.Where(a =>a.CLIENTE_IDVUELO == IDVUELO && a.CLLIENTE_ASIENTO_ == ASIENTONo).FirstOrDefault();



            if (itemes != null) 
            {
                string ExisteFecha = ((DateTime)itemes.Cliente_FECHADEVIEAJE).ToString("dd/MM/yyy");

                if (ExisteFecha == FECHAVUELO) 
                { 
                    return false; 
                }


                else 
                {
                   
                    return false;

                } 
            }

            else 
            {
                return true; 
            
            }
            /*El metodo "AsientosDisponibles" Hace una consulta a la base de datos y compara si los valores en la tabla "Tickets" coinciden con los de los 
            de los cuadros de texto. */
        }
    }
}
