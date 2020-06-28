using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class OrdersForm : Form
    {
        private readonly SerializationService serializationService = new SerializationService();
        private readonly OrderService service;

        public int? indexMesa;
        public int? orderQuantity;

        #region PersistenceConst

        private const string OrdersDirectory = "Orders";
        private const string OrdersFileName = "orders.dat";
        private const string SendOrdersDirectory = "SendOrders";
        private const string SendOrdersFileName = "sendOrders.dat";
        private const string OrderQuantityDirectory = "OrderQuantity";
        private const string OrderQuantityFileName = "orderQuantity.dat";
        private const string TablesDirectory = "Tables";
        private const string TablesFileName = "tables.dat";
        #endregion

        public OrdersForm()
        {
            service = new OrderService();
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

            btnCancel.Enabled = false;
            btnSendOrder.Enabled = false;

            var ordersDeserialize = (List<Orders>)serializationService.Deserialize(OrdersDirectory, OrdersFileName);

            var ordersTable = Repository.Instancia.orders;

            ordersTable = ordersDeserialize ?? new List<Orders>();

            lblTableNo.Text = indexMesa.ToString();
            int n = 1;
            lblTableNo.Text = (indexMesa.Value + n).ToString();

            lboPedidos.BeginUpdate();

            lboPedidos.Items.Clear();

            lblOrderNo.Text = orderQuantity.Value.ToString();

            if (ordersTable != null)
            {
                for (int i = 0; i < ordersTable.Count; i++)
                {
                    if (ordersTable[i].indexTable == indexMesa.Value)
                    {

                        if (ordersTable[i].indexTable == indexMesa)
                        {
                            btnCancel.Enabled = true;
                            btnSendOrder.Enabled = true;
                            lboPedidos.Items.Add($"Nombre : {ordersTable[i].Name}" +
                                                 $"Entrada : {ordersTable[i].foodEntrees.Name} Bebida : {ordersTable[i].drinks.Name}" +
                                                 $"Plato Fuerte : {ordersTable[i].dishes.Name} Postre : {ordersTable[i].dessert.Name}");
                             

                        }
                    }
                }
            }

            lboPedidos.EndUpdate();

            fillLists();
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    Tables tables = Tables.Instancia;
        //    tables.Show();
        //    this.Hide();
        //}

        public void fillLists()
        {
            #region ListVar

            var dishes = Repository.Instancia.dishes;
            var dessert = Repository.Instancia.dessert;
            var drinks = Repository.Instancia.drinks;
            var entrees = Repository.Instancia.foodEntrees;

            #endregion

            #region FoodEntrees


            FoodEntrees entrees1 = new FoodEntrees("Quipes");
            FoodEntrees entrees2 = new FoodEntrees("Croquetas con Queso");
            FoodEntrees entrees3 = new FoodEntrees("Sushi");
            FoodEntrees entrees4 = new FoodEntrees("Tomate Relleno");
            FoodEntrees entrees5 = new FoodEntrees("Ensalada de Aguacate");

            entrees.Add(entrees1);
            entrees.Add(entrees2);
            entrees.Add(entrees3);
            entrees.Add(entrees4);
            entrees.Add(entrees5);

            #endregion

            #region Dishes

            Dishes dishes1 = new Dishes("Arroz con Camaron");
            Dishes dishes2 = new Dishes("Canelones con Queso");
            Dishes dishes3 = new Dishes("Tablilla de Res");
            Dishes dishes4 = new Dishes("Carne de Ternera");
            Dishes dishes5 = new Dishes("Espaguetti Carbonara");
            Dishes dishes6 = new Dishes("Espaguetti al Peso con Camarones");
            Dishes dishes7 = new Dishes("Pechuga a la Plancha");
            Dishes dishes8 = new Dishes("Tacos de Pescado");
            Dishes dishes9 = new Dishes("Fajitas de Pollo");
            Dishes dishes10 = new Dishes("Arroz de la Casa");

            dishes.Add(dishes1);
            dishes.Add(dishes2);
            dishes.Add(dishes3);
            dishes.Add(dishes4);
            dishes.Add(dishes5);
            dishes.Add(dishes6);
            dishes.Add(dishes7);
            dishes.Add(dishes8);
            dishes.Add(dishes9);
            dishes.Add(dishes10);

            #endregion

            #region Dessert

            Dessert dessert1 = new Dessert("Arroz con Leche");
            Dessert dessert2 = new Dessert("Gelatina");
            Dessert dessert3 = new Dessert("Cocada");
            Dessert dessert4 = new Dessert("Pastel de Frutas");
            Dessert dessert5 = new Dessert("Tarta de Chocolate");
            Dessert dessert6 = new Dessert("Dulce de Coco");
            Dessert dessert7 = new Dessert("Helado");
            Dessert dessert8 = new Dessert("Turron");
            Dessert dessert9 = new Dessert("Donas");
            Dessert dessert10 = new Dessert("Manzada de Caramelos");

            dessert.Add(dessert1);
            dessert.Add(dessert2);
            dessert.Add(dessert3);
            dessert.Add(dessert4);
            dessert.Add(dessert5);
            dessert.Add(dessert6);
            dessert.Add(dessert7);
            dessert.Add(dessert8);
            dessert.Add(dessert9);
            dessert.Add(dessert10);

            #endregion

            #region Drinks


            Drinks drinks1 = new Drinks("Cerveza");
            Drinks drinks2 = new Drinks("Vino");
            Drinks drinks3 = new Drinks("Sidra");
            Drinks drinks4 = new Drinks("Jugos Naturales");
            Drinks drinks5 = new Drinks("Batidos");

            drinks.Add(drinks1);
            drinks.Add(drinks2);
            drinks.Add(drinks3);
            drinks.Add(drinks4);
            drinks.Add(drinks5);

            #endregion

            #region ElementsInComboBox


            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione una opcion",
                Value = null
            };

            cboDessert.Items.Add(opcionPorDefecto);
            cboDessert.SelectedItem = opcionPorDefecto;
            cboDishes.Items.Add(opcionPorDefecto);
            cboDishes.SelectedItem = opcionPorDefecto;

            for (int i = 0; i < 10; i++)
            {
                cboDessert.Items.Add(dessert[i].Name);
                cboDishes.Items.Add(dishes[i].Name);
            }

            cboEntrees.Items.Add(opcionPorDefecto);
            cboEntrees.SelectedItem = opcionPorDefecto;
            cboDrinks.Items.Add(opcionPorDefecto);
            cboDrinks.SelectedItem = opcionPorDefecto;

            for (int i = 0; i < 5; i++)
            {
                cboDrinks.Items.Add(drinks[i].Name);
                cboEntrees.Items.Add(entrees[i].Name);
            }

            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Length > 0 && cboDishes.SelectedIndex > 0 && cboDrinks.SelectedIndex > 0 && cboDessert.SelectedIndex > 0 && cboEntrees.SelectedIndex > 0)
            {
                Dishes dish = new Dishes(cboDishes.SelectedItem.ToString());
                Drinks drinks = new Drinks(cboDrinks.SelectedItem.ToString());
                Dessert dessert = new Dessert(cboDessert.SelectedItem.ToString());
                FoodEntrees entrees = new FoodEntrees(cboEntrees.SelectedItem.ToString());
                Orders order = new Orders(txtName.Text, dish, dessert, entrees, drinks);
                order.indexTable = indexMesa.Value;


                var ordersDeserialize = (List<Orders>)serializationService.Deserialize(OrdersDirectory, OrdersFileName);
                var orders = Repository.Instancia.orders;


                if (ordersDeserialize != null)
                {
                    orders = ordersDeserialize ?? new List<Orders>();

                }

                if (lboPedidos.Items.Count != Convert.ToInt32(lblOrderNo.Text))
                {
                    orders.Add(order);
                    //service.AddOrder(order, OrdersDirectory, OrdersFileName);
                   
                    btnCancel.Enabled = true;
                    btnSendOrder.Enabled = true;

                    lboPedidos.BeginUpdate();


                    var orderIndex = orders.IndexOf(order);

                    var OrderQuantityDeserialize = serializationService.Deserialize(OrderQuantityDirectory, OrderQuantityFileName);

                    serializationService.Serialize(orderQuantity, OrderQuantityDirectory, OrderQuantityFileName);
                    serializationService.Serialize(orders, OrdersDirectory, OrdersFileName);

                    for (int i = 0; i < 1; i++)
                    {
                        lboPedidos.Items.Add($"Nombre : {orders[orderIndex].Name} " +
                                      $"Entrada : {orders[orderIndex].foodEntrees.Name} Bebida :{orders[orderIndex].drinks.Name} " +
                                      $"Plato Fuerte :{orders[orderIndex].dishes.Name} Postre :{orders[orderIndex].dessert.Name} ");
                    }
                    lboPedidos.EndUpdate();
                    txtName.Text = "";
                    cboDessert.SelectedIndex = 0;
                    cboDishes.SelectedIndex = 0;
                    cboDrinks.SelectedIndex = 0;
                    cboEntrees.SelectedIndex = 0;


                }
                else
                {
                    MessageBox.Show($"Ha llegado al limite de ordenes, envie sus ordenes para ser procesadas", "Ordenes");
                    btnSave.Enabled = false;
                    txtName.Text = "";
                    cboDessert.SelectedIndex = 0;
                    cboDishes.SelectedIndex = 0;
                    cboDrinks.SelectedIndex = 0;
                    cboEntrees.SelectedIndex = 0;

                }
            }
            else
            {
                MessageBox.Show($"No pueden existir campos vacios ", "Advertencia");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var ordersDeserialize = (List<Orders>)serializationService.Deserialize(OrdersDirectory, OrdersFileName);
            var ordersTable = Repository.Instancia.orders;
            ordersTable = ordersDeserialize ?? new List<Orders>();


            lboPedidos.BeginUpdate();
            lboPedidos.Items.Clear();


            if (ordersTable != null)
            {

                for (int i = ordersTable.Count() - 1; i >=0; i--)
                {
                    if (ordersTable[i].indexTable == indexMesa.Value)
                    {

                        if (ordersTable[i].indexTable == indexMesa)
                        {


                            lboPedidos.Items.Remove($"Nombre:{ordersTable[i].Name}" +
                                               $"Entrada:{ordersTable[i].foodEntrees.Name} Bebida:{ordersTable[i].drinks.Name}" +
                                                 $"Plato Fuerte:{ordersTable[i].dishes.Name} Postre:{ordersTable[i].dessert.Name}");

                            ordersTable.RemoveAt(i);

                            serializationService.Serialize(ordersTable, OrdersDirectory, OrdersFileName);

                            Repository.Instancia.resurantTables[indexMesa.Value].People =0;

                            Repository.Instancia.resurantTables[indexMesa.Value].State = tablesStates((int)States.AVAILABLE);

                            serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);

                            btnCancel.Enabled = false;

                            btnSendOrder.Enabled = false;


                        }

                    }
                }
                lboPedidos.EndUpdate();
                DialogResult respuest = MessageBox.Show("Sus ordenes fueron eliminadas Satisfactoriamente, Desea volver al menu principal?", "Notificacion", MessageBoxButtons.OKCancel);

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

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            var ordersDeserialize = (List<Orders>)serializationService.Deserialize(OrdersDirectory, OrdersFileName);
            var ordersTable = Repository.Instancia.orders;
            ordersTable = ordersDeserialize ?? new List<Orders>();

            var sendOrdersDeserialize = (List<Orders>)serializationService.Deserialize(SendOrdersDirectory, SendOrdersFileName);
            var sendOrdersTable = new List<Orders>();
            sendOrdersTable = sendOrdersDeserialize ?? new List<Orders>();

            DialogResult respuest = MessageBox.Show("Desea enviar estas ordenes para ser procesadas?", "Notificacion", MessageBoxButtons.OKCancel);

            if (respuest == DialogResult.OK)
            {
                lboPedidos.BeginUpdate();
                lboPedidos.Items.Clear();


                if (ordersTable != null)
                {

                    for (int i = ordersTable.Count() - 1; i >= 0; i--)
                    {
                        if (ordersTable[i].indexTable == indexMesa.Value)
                        {

                            if (ordersTable[i].indexTable == indexMesa)
                            {
                                sendOrdersTable.Add(ordersTable[i]);

                                lboPedidos.Items.Remove($"Nombre :{ordersTable[i].Name}" +
                                                   $"Entrada :{ordersTable[i].foodEntrees.Name} Bebida :{ordersTable[i].drinks.Name}" +
                                                     $"Plato Fuerte :{ordersTable[i].dishes.Name} Postre :{ordersTable[i].dessert.Name}");

                                ordersTable.RemoveAt(i);

                                serializationService.Serialize(ordersTable, OrdersDirectory, OrdersFileName);

                                serializationService.Serialize(sendOrdersTable, SendOrdersDirectory, SendOrdersFileName);
                    
                                Repository.Instancia.resurantTables[indexMesa.Value].State = tablesStates((int)States.ATTENDED);

                                serializationService.Serialize(Repository.Instancia.resurantTables, TablesDirectory, TablesFileName);

                                btnCancel.Enabled = false;
                                lboPedidos.EndUpdate();

                            }
                        }
                    }
                }
            }
            DialogResult respuesta = MessageBox.Show("Sus ordenes fueron enviadas Satisfactoriamente, Desea volver al menu principal?", "Notificacion", MessageBoxButtons.OKCancel);

            if (respuest == DialogResult.OK)
            {
                Tables tables = new Tables();
                this.Hide();
                tables.Show();
            }
            else
            {
                btnSendOrder.Enabled = false;
            }
        }

       
    }
}


