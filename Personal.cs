using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.cviceni
{
	class Personal : Car
	{
		private new int MaxPeople;
		private int transportedPeople;

		public Personal(int numberofPeople, double conditionOfFuel, FuelType MyFuel) : base(conditionOfFuel, MyFuel) //base odkazuje na hlavni tridu Car
		{
			MaxPeople = 5; //nastaveni maxim pro osoby  v aute a velikost nadrze
			sizeoftank = 60;

			if (numberofPeople <= MaxPeople && conditionOfFuel <= SizeOfTank) // hlídač počtu osob a plnosti nádrže
			{
				transportedPeople = numberofPeople;
				fuel = MyFuel;
			}
			else
			{
				Console.WriteLine("Personal Car: Too much people in the car or amount of fuel! \n");

			}
			

		}
		public override string ToString() // vypis osobniho auta
		{
			return String.Format($"\nTransported people: {transportedPeople} \nFuel condition: {Tankcondition}l \nFuel type: {fuel}");
		}

	}
}
