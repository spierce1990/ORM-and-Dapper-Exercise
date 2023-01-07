using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal class product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public bool Onsale { get; set; }
        public int MyProperty { get; set; }
        public int StockLevel { get; set; }


    }
}
