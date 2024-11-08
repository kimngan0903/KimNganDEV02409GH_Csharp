using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tạo namespace kinh doanh
namespace Business
{
    // Lớp ở nhà
    public class House
    {
        public string HouseNo { get; set; }
        public decimal Price { get; set; }
    }

    // Tạo namespace con đại lý lồng bên trong namespace kinh doanh
    namespace Dealership
    {
        // Tạo lớp xe
        public class Car
        {
            public string CarNo { get; set; }
            public decimal Price { get; set; }
        }
    }
}
