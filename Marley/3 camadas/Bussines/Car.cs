
using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
    public class Car : IBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Description { get; set; }

    }
}