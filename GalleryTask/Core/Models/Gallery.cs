using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Gallery
    {
        static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        Car[] Cars = new Car[] {};

        public Gallery()
        {
            _id++;
            Id = _id;
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }
        public void ShowAllCars()
        {
            foreach (var car in Cars) 
            {
                Console.Write($"\nId: {car.Id}\n Name: {car.Name}\n Speed: {car.Speed}\n CarCode: {car.CarCode}");
            }
        }
        public Car[] GetAllCars()
        {
            return Cars;
        }
        public Car[] FindCarById(int id)
        {
            bool check = false;
            Car[] filteredCars = new Car[] {};
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    check = true;
                    Array.Resize(ref filteredCars,filteredCars.Length + 1);
                    filteredCars[filteredCars.Length - 1] = Cars[i];
                }
            }
            if (!check)
            {
                Console.WriteLine($"Bu {id} idli masin yoxdur ");
            }
            return filteredCars;
        }
        public Car[] FindCarByCarCode(string carCode)
        {
            bool check = false;
            Car[] filteredCar = new Car[] { };
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == carCode)
                {
                    check= true;
                    Array.Resize(ref filteredCar, filteredCar.Length + 1);
                    filteredCar[filteredCar.Length - 1] = Cars[i];
                }
            }
            if (!check)
            {
                Console.WriteLine($" Bu {carCode} carcodlu masin yoxdur");
            }
            return filteredCar;
        }
        public Car[] FindCarBySpeedInterval(int minSpeed,int maxSpeed)
        {
            bool check = false;
            Car[] filteredCars = new Car[] { };
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed >= minSpeed && Cars[i].Speed <= maxSpeed)
                {
                    check = true;
                    Array.Resize(ref filteredCars, filteredCars.Length + 1);
                    filteredCars[filteredCars.Length - 1] = Cars[i];
                }
            }
            if (!check) 
            {
                Console.WriteLine("Bu suret araliqinda masin yoxdur ");
            }
            return filteredCars;
        }
    }
}
