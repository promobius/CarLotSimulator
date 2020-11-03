using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarLotSimulator
{
   
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }



   
        public Car()
        {
            
        }

        public Car( int year, string make, string model, string enginenoise, string honknoise, bool isdrivable = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDrivable = isdrivable;
        }

        public void MakeEngineNoise()
        {
            
        }

        public void MakeHonkNoise()
        {
            
        }
    }
}
