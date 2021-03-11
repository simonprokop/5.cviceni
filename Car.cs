using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.cviceni
{
	class Car
	{
		public enum FuelType //výčtový typ pro druhy paliv
		{
			Benzine,
			Oil
		}
		//nemozne zmeny uzivatelem
		protected double SizeOfTank;
		protected double TankCondition;

		protected FuelType fuel;
		private CarRadio radio = new CarRadio();

		//Jednotlivé zapouzdřené vlastnosti (z prednasek)
		public Car(double Tank, FuelType MyFuel)
		{
			TankCondition = Tank;
			fuel = MyFuel;
		}
		public double sizeoftank
		{
			get
			{ return SizeOfTank; }
			set
			{ SizeOfTank = value; }
		}

		public double Tankcondition
		{
			get
			{ return TankCondition; }
			set
			{ TankCondition = value; }

		}

		public FuelType typeoffuel
		{
			get
			{ return fuel; }
			set
			{ fuel = value; }
		}

		//Zastávka na pumpě
		public void Refuel(FuelType fuel, double amount) 
		{
			if ((TankCondition + amount) <= SizeOfTank && this.fuel == fuel)
			{
				TankCondition += amount;
				Console.WriteLine("New tank condition is: {0}l ", Tankcondition);
			}
			else
			{
				Console.WriteLine("Wrong fuel type or amount of fuel!");
			}
		}

		//Nastaveni radia
		public void setRadio(bool ON)
		{
			radio.OnRadio(ON);
		}
		
		public void setPreset(int number, double frequency)
		{
			radio.setPreset(number, frequency);
		}

		public void retuneToPreset(int number)
		{
			radio.retuneToPreset(number);
		}
		public void displayRadio()
		{
			Console.WriteLine(radio);
		}

		
	}

}
