using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderService
    {
        private static readonly BaseService baseService = new BaseService();
        public void AddOrder(Orders item, string directory, string fileName)
        {

            baseService.Add(Repository.Instancia.orders, item, directory, fileName);

        }

    }
}
