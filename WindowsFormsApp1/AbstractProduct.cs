using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp1
{
    class Product
    {
        public String productName;
        int stock;
        public Mutex productLock;

        public Product(String name)
        {
            this.productName = name;
            this.stock = 20;
            productLock = new Mutex();
        }

        public Product(String name, int initialStock)
        {
            this.productName = name;
            this.stock = initialStock;
            productLock = new Mutex();
        }

        public void increaseStock(int amount)
        {
            stock += amount;
        }

        public bool decreaseStock(int amount)
        {
            if(stock - amount < 0)
            {
                return false;
            }
            else
            {
                stock -= amount;
                return true;
            }
        }

        public int getStock()
        {
            return stock;
        }
    }
}
