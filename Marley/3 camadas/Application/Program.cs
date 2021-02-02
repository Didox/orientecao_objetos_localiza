
using Bussines;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Year = 2015;
            car.Name = "Jetta";
            CarService.Save(car);
        }
    }
}