﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            global::Car car1 = new global::Car();
           
            car1.Year = 2023;
            car1.Make = "Audi";
            car1.Model = "R8";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            global::Car car2 = new global::Car();
            car2.Year = 2020;
            car2.Make = "GMC";
            car2.Model = "Denali";
            car2.EngineNoise = "Roar";
            car2.HonkNoise = "Honk";
            car2.IsDriveable = true;

            global::Car car3 = new global::Car();
            car3.Year = 2023;
            car3.Make = "Volkswagon";
            car3.Model = "Jetta";
            car3.EngineNoise = "Bang";
            car3.HonkNoise = "Beep";
            car3.IsDriveable = true;

                       

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
        } 
    }
}




            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
    

