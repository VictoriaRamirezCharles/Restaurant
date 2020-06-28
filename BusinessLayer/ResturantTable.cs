using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class ResturantTable
    {
        public string Name { get; set; }
        public int People { get; set; }

        public string State { get; set; }
        public ResturantTable(string name, int people, string state)
        {
            this.Name = name;
            this.People = people;
            this.State = state;

        }
        public ResturantTable()
        {

        }
        public string Datos
        {
            get
            {
                return Name + ": Cantidad de Personas: " + People + " Estado: " + State;

            }
        }
    }
}
