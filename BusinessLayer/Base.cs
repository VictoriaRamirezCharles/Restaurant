﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Base
    {
        public string Name { get; set; }
    

        public Base(string name)
        {
            this.Name=name;
            
        }
        public Base()
        {

        }
    }
}
