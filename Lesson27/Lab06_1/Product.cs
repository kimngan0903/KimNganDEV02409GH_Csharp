using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    internal class Product
    {
        // Khai báo trường
        string name;
        double cost;
        int onhand;

        // Constructor
        public Product(string n, double c, int h)
        {
            this.name = n;
            this.cost = c;
            this.onhand = h;
        }

        // Ghi đè phương thức
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} Onhand: {2}", name, cost, onhand);
        }
    }
}
