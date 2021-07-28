using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //Customer customer1 = new Customer() {UserId=1, CompanyName="Kodlama.io A.Ş" }; 
            ////customerManager.Add(customer1);
            //Customer customer2 = new Customer() { UserId = 2, CompanyName = "BTK Akademi" };
            //customerManager.Add(customer2);

            


        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelYear + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
