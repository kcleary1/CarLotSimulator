using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot lot = new CarLot();
            

            Car carOne = new Car();
            carOne.Year = "1992";
            carOne.Make = "Toyota";
            carOne.Model = "Corolla";
            carOne.EngineNoise = "\"clackity clack\"";
            carOne.HonkNoise = "\"honkity honk\"";
            carOne.IsDrivable = "questionable";

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);

            lot.CarList.Add(carOne);

            Console.WriteLine($"The first car is a {carOne.Year} {carOne.Make} {carOne.Model}. Its engine makes a {(carOne.MakeEngineNoise(carOne.EngineNoise))} sound, and its horn makes a {(carOne.MakeHonkNoise(carOne.HonkNoise))} noise. Its drivability is {carOne.IsDrivable}.");

            Car carTwo = new Car();
            carTwo.Year = "2000";
            carTwo.Make = "BMW";
            carTwo.Model = "325";
            carTwo.EngineNoise = "\"hmmmm\"";
            carTwo.HonkNoise = "\"beep\"";
            carTwo.IsDrivable = "without question";

            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);

            lot.CarList.Add(carTwo);

            Console.WriteLine($"The second car is a {carTwo.Year} {carTwo.Make} {carTwo.Model}. Its engine makes a {carTwo.MakeEngineNoise(carTwo.EngineNoise)} sound, and its horn makes a {carTwo.MakeHonkNoise(carTwo.HonkNoise)} noise. Its drivability is {carTwo.IsDrivable}.");

            Car carThree = new Car();
            carThree.Year = "1998";
            carThree.Make = "Ford";
            carThree.Model = "F350";
            carThree.EngineNoise = "\"vrooom\"";
            carThree.HonkNoise = "\"hooonk\"";
            carThree.IsDrivable = "fair";

            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);

            lot.CarList.Add(carThree);

            Console.WriteLine($"The third car is a {carThree.Year} {carThree.Make} {carThree.Model}. Its engine makes a {carThree.MakeEngineNoise(carThree.EngineNoise)} sound, and its horn makes a {carThree.MakeHonkNoise(carThree.HonkNoise)} noise. Its drivability is {carThree.IsDrivable}.");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car carFour = new Car() {Year = "2001", Make = "Mazda", Model = "Miata", EngineNoise = "\"Zzzzzzz\"", HonkNoise = "\"Tweet\"", IsDrivable = "Yes" };

            carFour.MakeEngineNoise(carFour.EngineNoise);
            carFour.MakeHonkNoise(carFour.HonkNoise);

            lot.CarList.Add(carFour);

            Console.WriteLine("Here is a list of all cars on the lot.");
            
            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} ");
            }

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
