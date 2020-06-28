using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class SendOrders:Base
    {
        public int indexTable { get; set; }
        public Dishes dishes { get; set; } = new Dishes();
        public Dessert dessert { get; set; } = new Dessert();
        public FoodEntrees foodEntrees { get; set; } = new FoodEntrees();
        public Drinks drinks { get; set; } = new Drinks();


        public SendOrders(string name, Dishes dishes, Dessert dessert, FoodEntrees foodEntrees, Drinks drinks) : base(name)
        {

            this.dishes = dishes;
            this.drinks = drinks;
            this.dessert = dessert;
            this.foodEntrees = foodEntrees;

        }
    }
}
