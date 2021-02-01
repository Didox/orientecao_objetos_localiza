using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
    {
    public class CarService
    {

        public static void Save(Car car)
        {
            CarDBService.Save(car);
        }
    }
}