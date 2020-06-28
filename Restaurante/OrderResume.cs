using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class OrderResume : Form
    {
        private readonly SerializationService serializationService = new SerializationService();
        private readonly OrderService service;

        public int? indexMesa;
        public int? orderQuantity;
        private const string SendOrdersDirectory = "SendOrders";
        private const string SendOrdersFileName = "sendOrders.dat";
        private const string TablesDirectory = "Tables";
        private const string TablesFileName = "tables.dat";
        public OrderResume()
        {
            InitializeComponent();
        }

        private void OrderResume_Load(object sender, EventArgs e)
        {
            var sendOrdersDeserialize = (List<Orders>)serializationService.Deserialize(SendOrdersDirectory, SendOrdersFileName);

            var sendOrdersTable = new List<Orders>();
            int n = 1;
            sendOrdersTable = sendOrdersDeserialize ?? new List<Orders>();
            lblMesa.Text = (indexMesa.Value + n).ToString();
            lblPersonas.Text = orderQuantity.Value.ToString();

            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione un Nombre",
                Value = null
            };
            cboNames.Items.Add(opcionPorDefecto);
            if (sendOrdersTable != null)
            {
                for (int i = 0; i < sendOrdersTable.Count; i++)
                {
                    if (sendOrdersTable[i].indexTable == indexMesa.Value)
                    {

                        if (sendOrdersTable[i].indexTable == indexMesa)
                        {

                            cboNames.Items.Add(sendOrdersTable[i].Name);


                        }
                    }
                }
            }
            cboNames.SelectedItem = opcionPorDefecto;
        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sendOrdersDeserialize = (List<Orders>)serializationService.Deserialize(SendOrdersDirectory, SendOrdersFileName);
            var sendOrdersTable = new List<Orders>();
            sendOrdersTable = sendOrdersDeserialize ?? new List<Orders>();
            lblOrders.Items.Clear();
            if (cboNames.SelectedIndex > 0)
            {

                if (sendOrdersTable != null)
                {
                    for (int i = 0; i < sendOrdersTable.Count; i++)
                    {
                        if (sendOrdersTable[i].indexTable == indexMesa.Value)
                        {

                            if (sendOrdersTable[i].Name == cboNames.SelectedItem.ToString())
                            {
                               
                                lblOrders.Items.Add($"Nombre:{sendOrdersTable[i].Name} |" +
                                                          $"Entrada:{sendOrdersTable[i].foodEntrees.Name} | Bebida:{sendOrdersTable[i].drinks.Name} |" +
                                                            $"Plato Fuerte:{sendOrdersTable[i].dishes.Name} | Postre:{sendOrdersTable[i].dessert.Name}");


                            }
                        }
                    }
                }
            }
            
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e) { 
         var sendOrdersDeserialize = (List<Orders>)serializationService.Deserialize(SendOrdersDirectory, SendOrdersFileName);
          var sendOrdersTable = new List<Orders>();
        sendOrdersTable = sendOrdersDeserialize ?? new List<Orders>();



            lblOrders.BeginUpdate();
            lblOrders.Items.Clear();


            if (sendOrdersTable != null)
            {

                for (int i = sendOrdersTable.Count() - 1; i >= 0; i--)
                {
                    if (sendOrdersTable[i].indexTable == indexMesa.Value)
                    {

                        if (sendOrdersTable[i].indexTable == indexMesa)
                        {




                            sendOrdersTable.RemoveAt(i);
                       serializationService.Serialize(sendOrdersDeserialize, SendOrdersDirectory, SendOrdersFileName);
                       Repository.Instancia.resurantTables[indexMesa.Value].People = 0;
                       Repository.Instancia.resurantTables[indexMesa.Value].State = tablesStates((int)States.AVAILABLE);
                            serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);
                         
                            btnDeleteOrders.Enabled = false;
                        }

                    }
                }
                lblOrders.EndUpdate();
                DialogResult respuest = MessageBox.Show("Sus ordenes fueron finalizadas Satisfactoriamente, Desea volver al menu principal?", "Notificacion", MessageBoxButtons.OKCancel);

                if (respuest == DialogResult.OK)
                {
                    Tables tables = new Tables();
                    this.Hide();
                    tables.Show();
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
    }
}
