using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.cviceni
{
	class Lorry : Car
	{

		private int maxCargo;
		private int transportedCargo;

		public Lorry(int sizeOfCargo, double conditionOfTank, FuelType fuel) : base(conditionOfTank, fuel)
		{
			maxCargo = 100; //nastaveni maxim pro naklad a nadrz
			sizeoftank = 100;
		

			if (sizeOfCargo <= maxCargo && conditionOfTank <= sizeoftank) //Kamion na vaze + mereni nadrze
			{
				transportedCargo = sizeOfCargo;
				this.fuel = fuel;
			}
			else
				Console.WriteLine("Lorry: Overload or overfilled tank! \n");
		}

		public override string ToString() // vypis nakladniho vozu
		{
			return String.Format($"Transported cargo: {transportedCargo}t \nFuel condition: {Tankcondition}l \nFuel type:{fuel}");
		}

	}
}
