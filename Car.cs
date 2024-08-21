using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSeller
{
    internal class Car
    {
        //properties
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //constructor
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public override string ToString()
        {
            return $"{Make}, {Model}, {Year}, {Price}";
        }
    }
}
