using System;

namespace OOPcar
{
    class Program
    {
      class Car
        {
            string mark;
            string model;
            string registrationnumber;
            string color;
            int odometer;
            int fuel;

            public Car(string _mark, string _model, string _registrationnumber, string _color)
            {
                mark = _mark;
                model = _model;
                registrationnumber = _registrationnumber;
                color = _color;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"{color} {mark} {model} {registrationnumber} has been created.");
            }








            public void ShowCarInfo()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"RegistrationNumber: {registrationnumber}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odometer: {odometer}");
                Console.WriteLine($"Fuel: {fuel}");
            }

          public string Model
            {
                get { return model; }
            }

            public string Mark
            {
                get { return mark; }
            }
            public string Registrationnumber
            {
                get { return registrationnumber; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fuel
            {
                get { return fuel; }
            }

            public void drive()
            {
                fuel -= 5;
                odometer += 100;
                Console.WriteLine("Happy-V8-Noises");
            }

            



        }


        static void Main(string[] args)
        {
            Car myCar = new Car("Mercedes", "C63AMG", "666AMG", "White");


            while(myCar.Fuel > 0)
            {
                myCar.drive();
            }

            myCar.ShowCarInfo();
        }
    }
}
