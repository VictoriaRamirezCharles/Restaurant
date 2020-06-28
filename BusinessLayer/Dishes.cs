using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Dishes:Base
    {
       
        public Dishes(string name) : base(name)
        {
            
        }
        public Dishes()
        {

        }
    }
}
