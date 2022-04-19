using System;
using System.Collections.Generic;

namespace task2
{
	
	class Program
    {
        static void Main(string[] args)
        {
			List<Car> cars = new List<Car>
			{
				 new Car(Manufacturer.BMW, Type.SUV, "AMG", 60000, 2021, 360, 10000, Transmission.Automatic, 12),
				 new Car(Manufacturer.Cadillac, Type.SUV, "Escalede", 52000, 2020, 290, 32000, Transmission.Manual, 15),
				 new Car(Manufacturer.Jeep, Type.SUV, "Cherokee", 33000, 2022, 280, 2000, Transmission.Automatic, 14),
				 new Car(Manufacturer.Kia, Type.Sedun, "RIO", 28000, 2021, 260, 3000, Transmission.Automatic, 13),
				 new Car(Manufacturer.Porsche, Type.Coupe, "Cayenne", 63000, 2019, 300, 70000, Transmission.Automatic, 14),
				 new Car(Manufacturer.Ferrari, Type.Coupe, "488", 25000, 2022, 361, 0, Transmission.Automatic, 11),
			};

            Console.WriteLine($"The price of the whole autopark is {Autopark.CalculateCarsCost(cars)}");
			Autopark.SortByFuelConsuption(cars);

			Console.WriteLine();
            foreach (var car in cars)
            {
                Console.WriteLine("CarInfo:\n"+car.ToString());
            }
			
			Console.ReadKey();

        }
    }
}
