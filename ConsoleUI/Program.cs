using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq.Expressions;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            carTest();

        }

        public static void carTest()
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var item in carManager.GetPrice(40000))
            //{
            //    Console.WriteLine(item.DailyPrice);

            ////}


        }

    }
}
