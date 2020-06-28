using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Drinks:Base
    {
        public Drinks(string name) : base(name)
        {

        }
        public Drinks()
        {

        }
    }
}
