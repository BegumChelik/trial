using CoffeeShop.Console.Adapters;
using CoffeeShop.Console.Entity;
using CoffeeShop.Console.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { FirstName="Begm",SecondName="Çelik",BirthDate=new DateTime(1990,08,30),NationalId="67030150204"});
            System.Console.ReadLine();
        }
    }
}
