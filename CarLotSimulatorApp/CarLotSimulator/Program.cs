using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO







            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarLot lot = new CarLot();
           

            Car car1 = new Car(2013, "BMW", "M3", "Vroom(in german)", "Das honk", true);
            lot.CarList.Add(car1);
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            Car car2 = new Car(2020, "Toyota", "Supra", "Whaaahhh", "meep", true);
            lot.CarList.Add(car2);
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Car car3 = new Car(2009, "Ford", "Mustang", "Clank", "Neigh", false);
            lot.CarList.Add(car3);
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} ");
                Console.WriteLine($"{car.Model} goes {car.EngineNoise} and says { car.HonkNoise} ");
            }

        }
    }
}
