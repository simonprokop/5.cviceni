using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.cviceni
{
	class Program
	{
		static void Main(string[] args)
		{
			// nastaveni osobniho auta
			Personal CarPersonal = new Personal(4, 5, Car.FuelType.Benzine);

			//Popis Osobniho auta
			Console.WriteLine("Informations about Personal car:\n{0}", CarPersonal);


			//nastaveni radia
			CarPersonal.setRadio(true);
			CarPersonal.setPreset(1, 150);
			CarPersonal.setPreset(4, 87.8);
			CarPersonal.retuneToPreset(1);
			CarPersonal.displayRadio();
		

			CarPersonal.retuneToPreset(4);
			CarPersonal.displayRadio();

			//doplneni paliva
			Console.WriteLine("\nRefuel:");
			CarPersonal.Refuel(Car.FuelType.Benzine, 10);

			Console.WriteLine("\n--------------------------------");








			//nastaveni nakladniho auta
			Lorry CarLorry = new Lorry(10, 70, Car.FuelType.Oil);


			Console.WriteLine("\nInformations about Lorry:\n{0}", CarLorry);
			

			CarLorry.setRadio(false); //zapne radio
			CarLorry.setPreset(2, 105.5); //nastavi druhou predvolbu
			CarLorry.setPreset(6, 88.5); //nastavi dalsi predvolbu
			CarLorry.retuneToPreset(2);
			CarLorry.displayRadio();


			Console.WriteLine("\nRefuel:");
			CarLorry.Refuel(Car.FuelType.Oil, 20);

			Console.WriteLine("\n--------------------------------");

			//ukazka preladeni radia
			Console.WriteLine("\n*Retune from 105.5 to 88.5, please.*");
			CarLorry.retuneToPreset(6);
			CarLorry.displayRadio();


			Console.WriteLine("\n*Retune from 105.5 to 120.5, please.*");
			CarLorry.retuneToPreset(1);


	



			Console.ReadLine();
		}
	}
}
