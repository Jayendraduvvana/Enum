using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace program 
{
    enum VehicleType
    {
     Twowheeler,
     Threewheeler,
     Fourwheeler       
    }
    enum FuelType
    {
        CNG,
        petrol,
        Dieseal,
    }
    class Vehicle
    {
        string engNo;
        VehicleType vType;
        FuelType ftype;
        public Vehicle()
        {

        }
        public Vehicle(string _engNo, VehicleType _vt, FuelType _ft)
        {
            engNo = _engNo;
            vType = _vt;
            ftype = _ft;
        }
        public virtual void Show()
        {
            Console.WriteLine("vehicle Details");
            Console.WriteLine($"engine No:{engNo}\n Vehicle Type:{vType}\nfuel Type");
        }
    }
        class Car : Vehicle
        {
            string make;
            string color;
            double price;
            public Car()
            {

            }
            public Car(string engNo, VehicleType vt, FuelType ft, String _make, string _color, double _price) : base(engNo, vt, ft)
            {
                make = _make;
                color = _color;
                price = _price;
            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"make:{make}\ncolor:{color}\nprice:{price}");
            }
        }
        class Bike : Vehicle
        {
            string make;
            string color;
            double price;
            public Bike()
            {

            }
            public Bike(string engNo, VehicleType vt, FuelType ft, String _make, string _color, double _price) : base(engNo, vt, ft)
            {
                make = _make;
                color = _color;
                price = _price;
            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"make:{make}\ncolor:{color}\nprice:{price}");
            }


        }
        
    class program
    {
        public static void Main(string[] args)
        {
            Car objcar = new Car("BMW", VehicleType.Fourwheeler, FuelType.Dieseal, "Bench", "white", 600000);
            objcar.Show();

            Bike objbike = new Bike("hero", VehicleType.Threewheeler, FuelType.petrol,"shine","orange",80000);
            objbike.Show();
            Console.Read();

        }
    }


}

       

   
    
