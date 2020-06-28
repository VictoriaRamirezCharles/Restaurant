using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public sealed class Repository
    {
        public List<ResturantTable> resurantTables { get; set; } = new List<ResturantTable>();
        public List<Orders> orders { get; set; } = new List<Orders>();
        public List<SendOrders> sendOrders { get; set; } = new List<SendOrders>();
        public List<Dishes> dishes { get; set; } = new List<Dishes>();

        public List<Dessert> dessert { get; set; } = new List<Dessert>();
        public List<FoodEntrees> foodEntrees { get; set; } = new List<FoodEntrees>();
        public List<Drinks> drinks { get; set; } = new List<Drinks>();
        public static Repository Instancia { get; } = new Repository();


        private Repository()
        {

        }
    }
}
