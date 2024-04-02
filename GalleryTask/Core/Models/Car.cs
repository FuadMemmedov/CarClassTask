using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car
    {
        static int _id {  get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        static int _carCode { get; set;}
        public string CarCode { get; set; }
       


        public Car(string name,int speed, string carCode)
        {
            

           Name = name;
           Speed = speed;
           CarCode = carCode;
            CarCode += "100";
            _carCode++;
            CarCode += _carCode;
           
            _id++;
            Id = _id;




        }




    }
}
