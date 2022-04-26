using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
	class Car:IComparable
	{
		public Manufacturer Manufacturer { set; get; }
		public Type Type { set; get; }
		public string Model { set; get; }
		public int Price { set; get; }
		public int Year { set; get; }
		public int Mileage { set; get; }
		public int MaxSpeed { set; get; }
		public Transmission Transmission { set; get; }
        public int FuelConsumption { get; set; }

        public Car(Manufacturer Manufacturer, Type Type, string Model, int Price, int Year, int MaxSpeed, int Mileage, Transmission Transmission, int FuelConsumption)
		{
			this.Manufacturer = Manufacturer;
			this.Type = Type;
			this.Model = Model;
			this.Price = Price;
			this.Year = Year;
			this.Mileage = Mileage;
			this.MaxSpeed = MaxSpeed;
			this.Transmission = Transmission;
			this.FuelConsumption = FuelConsumption;

		}

		public override string ToString()
		{
			string carInfo = $"Manufacturer: {Manufacturer}, Type: {Type}, Model: {Model}, Price: {Price}$, Year: {Year}, MaxSpeed: {MaxSpeed} km/h, Mileage: {Mileage} km, Fuel consumption: {FuelConsumption} km/l";

			return carInfo;
		}

        public int CompareTo(object obj)
        {
			
			if(obj is Car car)
            {
				if (this.FuelConsumption < car.FuelConsumption)
				{
					return -1;
				}
				else if(this.FuelConsumption > car.FuelConsumption)
                {
					return 1;
                }
                else
                {
					return 0;
                }
            }
            else
            {
				throw new Exception("Invalid data");
			}

        }
    }
	enum Transmission
	{
		Automatic,
		Manual
	}
	enum Manufacturer
	{
		Acura,
		AlfaRomeo,
		AstonMartin,
		Audi,
		Bentley,
		BMW,
		Bugatti,
		Buick,
		Cadillac,
		Chevrolet6,
		Chrysler,
		Citroen,
		Dodge,
		Ferrari,
		Fiat,
		Ford,
		Geely,
		GMC,
		Honda,
		Hyundai,
		Infiniti,
		Jaguar,
		Jeep,
		Kia,
		Lamborghini,
		LandRover,
		Lexus,
		Maserati,
		Mazda,
		McLaren,
		MercedesBenz,
		Mini2,
		Mitsubishi,
		Nissan,
		Peugeot,
		Porsche,
		Renault,
		RollsRoyce,
		Subaru,
		Suzuki,
		Tesla,
		Toyota,
		Volkswagen,
		Volvo,
	}
	enum Type
	{
		Convertible,
		Coupe,
		Hatchback,
		Sedun,
		SUV,
		Van
	}
}
