using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class FoodEntrees :Base
    {
        public FoodEntrees(string name) : base(name)
        {

        }
        public FoodEntrees()
        {

        }
    }
}
