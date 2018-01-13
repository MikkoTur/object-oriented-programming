﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Class_Car
    {
        //Auton tiedot
        public string Brand;
        public int Speed;

        //Constructor
        public Class_Car()
        {
            Brand = null;
            Speed = 0;

        }

        //Methods

        public void AskData()
        {
            Console.WriteLine($"Syötä auton merkki ja nopeus km/h: ");
            Brand = Console.ReadLine();
            Speed = int.Parse(Console.ReadLine());
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on: {Brand}\n" +
                $"Auton nopeus on: {Speed} km/h\n" +
                $"-------------------------");
        }

        public void Accelerate()
        {
            Console.WriteLine($"Anna kerroin jolla auton nopeuttasi lisätään:");
            float speed1 = float.Parse(Console.ReadLine());

            if (speed1 < 1)
                Console.WriteLine("Negatiivista muutosta ei sallita!");
            else
                Console.WriteLine($"Nopeutta lisättiin {speed1} kertaiseksi, uusi nopeutesi on: {speed1 * Speed} km/h\n ");
        }
    }
}