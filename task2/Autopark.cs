using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace task2
{
    class Autopark
    {
		public static long CalculateCarsCost(List<Car> cars)
		{
			long sum = 0;
			foreach (Car car in cars)
			{
				sum += car.Price;
			}
			return sum;
		}

		public static List<Car> SearchBySpeed(List<Car> cars, int min, int max)
		{
			List<Car> carSelection = new List<Car>();

			foreach (Car car in cars)
			{
				if (car.MaxSpeed >= min && car.MaxSpeed <= max)
				{
					carSelection.Add(car);
				}
			}

			return carSelection;
		}

		public static void SortByFuelConsuption(List<Car> cars)
		{
			cars.Sort(delegate(Car car1, Car car2)
			{
				return car1.FuelConsumption.CompareTo(car2.FuelConsumption);
			});
			
		}
	}
}
