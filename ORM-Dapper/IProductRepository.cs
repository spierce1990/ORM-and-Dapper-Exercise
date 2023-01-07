using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal interface IProductRepository
    {
        public void CreateProduct(string name, double price, int categoryID);

        public IEnumerable<product> GetAllProducts();
    }
}
