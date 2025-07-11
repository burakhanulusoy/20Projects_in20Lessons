using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.DTOS.ProductDTOS
{
    public class GetByIdProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitslnStock { get; set; }

    }
}
