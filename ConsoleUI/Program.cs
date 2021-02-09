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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("---------GetCarsByBrandId----------");

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("------BrandName--------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            //Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.
            carManager.Add(new Car {CarId=11,CarName="i7",BrandId=2,ColorId=2,DailyPrice=0,ModelYear="2018",Description="Dizel" });
        }
    }
}
