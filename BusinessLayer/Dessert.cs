using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Dessert :Base
    {
        public Dessert(string name) : base(name)
        {

        }
        public Dessert()
        {

        }
    }
}
