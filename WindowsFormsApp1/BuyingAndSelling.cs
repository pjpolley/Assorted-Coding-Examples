using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApp1
{
    class BuyingAndSelling
    {
        int desiredThreads;
        int numProducts;
        Product[] products;
        Random rand = new Random();

        public BuyingAndSelling(int numProducts)
        {
            this.numProducts = numProducts;
            products = new Product[4];
            for (int i = 0; i < numProducts; i++)
            {
                products[i] = new Product("Product" + i.ToString(), 0);
            }
            this.desiredThreads = 4;
        }

        public BuyingAndSelling(int numProducts, int desiredThreads)
        {
            this.numProducts = numProducts;
            products = new Product[numProducts];
            for(int i = 0; i < numProducts; i++)
            {
                products[i] = new Product("Product" + i.ToString(), 20);
            }
            this.desiredThreads = desiredThreads;
        }

        public BuyingAndSelling(int desiredThreads, Product[] products)
        {
            this.numProducts = products.Length;
            this.products = products;
            this.desiredThreads = desiredThreads;
        }

        public BuyingAndSelling(Product[] products)
        {
            this.numProducts = products.Length;
            this.products = products;
            this.desiredThreads = 4;
        }

        public Product[] getProductInformation()
        {
            return products;
        }

        public void RunSimulationStep()
        {

            for(int i = 0; i < desiredThreads; i++)
            {
                Thread newThread = new Thread(new ThreadStart(UpdateStocks));
                newThread.Name = String.Format("Thread{0}", i + 1);
                newThread.Start();
            }
        }


        private void UpdateStocks()
        {
            int productToCheck =  rand.Next(0, numProducts);
            Console.WriteLine("Modifying product " + productToCheck.ToString());
            int buyingOrSelling = rand.Next(0, 2);

            bool aquiredMutex = false;

            // Wait until it is safe to enter.
            while (!aquiredMutex)
            {
                try
                {
                    products[productToCheck].productLock.WaitOne();
                    aquiredMutex = true;
                }
                //this will check if the tread or system that took the mutex last has broken or in some way failed to release the mutex in the default allocated time.
                catch (AbandonedMutexException e)
                {
                    e.Mutex.ReleaseMutex();
                }
            }

            //we have the mutex and can now proceed with the knowledge that we can safely edit our protected variables
            if (buyingOrSelling == 0)
            {
                if (products[productToCheck].decreaseStock(rand.Next(0, 10)))
                {
                    Console.WriteLine("Thread " + Thread.CurrentThread.Name + " has decreased the stock of " + products[productToCheck].productName + " to " + products[productToCheck].getStock().ToString());
                }
                else
                {
                    Console.WriteLine("Thread " + Thread.CurrentThread.Name + " tried to decrease the stock of " + products[productToCheck].productName + " by more than is currently held (" + products[productToCheck].getStock().ToString() + ")");
                }
            }
            else
            {
                products[productToCheck].increaseStock(rand.Next(0, 10));
                Console.WriteLine("Thread " + Thread.CurrentThread.Name + " has increased the stock of " + products[productToCheck].productName + " to " + products[productToCheck].getStock().ToString());
            }

            //and finally we will release the mutex so that other threads can use it
            products[productToCheck].productLock.ReleaseMutex();
        }
    }
}
