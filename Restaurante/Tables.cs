
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Restaurante
{
    public partial class Tables : Form
    {
        private readonly SerializationService serializationService = new SerializationService();
        public static Tables Instancia { get; } = new Tables();

        #region PersistenceConst
        private const string TablesDirectory = "Tables";
        private const string TablesFileName = "tables.dat";
        private const string SendOrdersDirectory = "SendOrders";
        private const string SendOrdersFileName = "sendOrders.dat";
        #endregion

        public Tables()
        {

            InitializeComponent();
        }


        private void Tables_Load(object sender, EventArgs e)
        {
            loadTables();
        }

        private void loadTables()
        {
            //Solo en modo Debug
           var filePath =
              System.IO.Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Mesas.csv");

            CsvReader reader = new CsvReader(filePath);

           var tablesDeserialize = 
                (List<ResturantTable>)serializationService.Deserialize(TablesDirectory, TablesFileName);

            if (tablesDeserialize == null)
            {

                Repository.Instancia.resurantTables = reader.ReadingTables();
                serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);

            }
            else
            {

                Repository.Instancia.resurantTables = tablesDeserialize ?? new List<ResturantTable>();
            }
           
             
           lbboxTables.BeginUpdate();

           lbboxTables.Items.Clear();

            var tables = Repository.Instancia.resurantTables;

            foreach (var table in tables)
            {
                lbboxTables.Items.Add(table.Datos);
             
            }
            lbboxTables.EndUpdate();
        }


        private void Tables_VisibleChanged(object sender, EventArgs e)
        {
            loadTables();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var index = lbboxTables.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Debe seleccionar la mesa y luego agregar la(s) orden(es)", "Notificacion");
            }
            else
            {
                if (Repository.Instancia.resurantTables[index].State.Contains(tablesStates((int)States.AVAILABLE)))
                {
              
                        var entry = Interaction.InputBox("Cantidad de Personas", "Cantidad", "0");

                        int.TryParse(entry, out int quantity);

                  
                        switch (quantity)
                        {
                            case 0:
                                MessageBox.Show($"Este valor no es valido ", "Advertencia");

                                break;
                            case int c when c > 4:

                                MessageBox.Show($"El maximo de personas por mesa es 4 ", "Advertencia");

                                break;

                            case int c when c > 0:

                                var result =
                                MessageBox.Show($"Desea agregar {quantity} ordenes? ", "Ordenar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {

                                    Repository.Instancia.resurantTables[index].People = quantity;
                                    Repository.Instancia.resurantTables[index].State = 
                                    tablesStates((int)States.INPROCESS);
                                    serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);

                                    OrdersForm ordersForm = new OrdersForm();
                                    ordersForm.indexMesa = index;
                                    ordersForm.orderQuantity = quantity;
                                    this.Hide();
                                    ordersForm.Show();
                                }
                                break;
                        }
                }
                else
                {
                    MessageBox.Show($"Esta mesa no se encuentra disponible ", "Advertencia");
                }
            }

        }

        public string tablesStates(int state)
        {
            string labelState = "";
            switch (state)
            {
                case (int)(States.AVAILABLE):
                    labelState = "Disponible";
                    break;
                case (int)(States.INPROCESS):
                    labelState = "En proceso de atención";
                    break;
                case (int)(States.RESUME_PROCESS):
                    labelState = "Reanudar proceso de atención";
                    break;

                case (int)(States.ATTENDED):
                    labelState = "Atendida";
                    break;

                default:
                    labelState = "Disponible";
                    break;

            }
            return labelState;
        }

        private void btnResumeProcess_Click(object sender, EventArgs e)
        {
            var index = lbboxTables.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Debe seleccionar la mesa que desea reaunudar", "Notificacion");
            }
            else
            {
                if (
                    Repository.Instancia.resurantTables[index].State.Contains(tablesStates((int)States.RESUME_PROCESS
                    )))
                {
               
                    Repository.Instancia.resurantTables[index].State = tablesStates((int)States.INPROCESS);
                    OrdersForm ordersForm = new OrdersForm();
                    ordersForm.indexMesa = index;
                    ordersForm.orderQuantity = Repository.Instancia.resurantTables[index].People;
                    serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);
                    this.Hide();
                    ordersForm.Show();
                }
                else
                {
                    MessageBox.Show("Esta orden no se encuentra en proceso de Reanudar proceso de atención", "Error");
                }
            }
        }

        private void Tables_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbboxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lbboxTables.SelectedIndex;
            var ordersDeserialize = (List<Orders>)serializationService.Deserialize(SendOrdersDirectory, SendOrdersFileName);
            var ordersTable = Repository.Instancia.orders;
            ordersTable = ordersDeserialize ?? new List<Orders>();

            if (
                    Repository.Instancia.resurantTables[index].State.Contains(tablesStates((int)States.ATTENDED
                    )))
            {
                OrderResume orderResume = new OrderResume();
                orderResume.indexMesa = index;
                orderResume.orderQuantity = Repository.Instancia.resurantTables[index].People;
                this.Hide();
                orderResume.Show();
            }
        }
    }
}
