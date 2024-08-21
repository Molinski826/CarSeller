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

        public static List<Car> carList = new List<Car>();

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
            return $"{Make}, {Model}, {Year}, ${Price:F2}";
        }
        public static void ListCars()
        {
            for (int i = 0; i < carList.Count; i++)
            {
                System.Console.WriteLine($"{i+1}. Car: {carList[i]}");
            }
        }

        public static void Remove(int index)
        {
            if (index >= 0 && index < carList.Count)
            {
                carList.RemoveAt(index);
            }
            else
            {
                System.Console.WriteLine("Invalid index");
            }
        }
    }
}
