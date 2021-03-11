using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.cviceni
{
	class CarRadio
	{

		private double tuneFreq;
		private bool RadioOn = false;

		private Dictionary<int, double> AllFreq; //knihovna pro frekvence radia
		private int totalamountOfFreq = 0;

		public void OnRadio(bool ON) //zapnuti-vypnuti radia
		{
			if (ON)
			{
				RadioOn = true;
			}
			else
				RadioOn = false;
		}

		public void setPreset(int number, double Freq) // nastaveni predvoleb stanic a ulozeni do Dictionary
		{
			if (totalamountOfFreq == 0)
			{
				AllFreq = new Dictionary<int, double>(); //pri nulovem poctu frekvenci nejdrive vytvori
														 //slozku Dictionary a pak ulozi novou frekvenci
				totalamountOfFreq += 1;
				AllFreq.Add(number, Freq);
			}
			else
			{
				AllFreq.Add(number, Freq);
			}

		}

		public void retuneToPreset(int number)
		{
			if (AllFreq.ContainsKey(number))
			{
				tuneFreq = AllFreq[number]; //preladeni na jinou stanici pres cislo v Dictionary
			}
			else
			{
				Console.WriteLine("Not found frequency");
			}
		}

		public override string ToString()
		{
			if (RadioOn)
			{
				return String.Format($"RadioOn:{RadioOn}, Frequency:{tuneFreq}");
			}
			else
				return String.Format($"RadioOn:{RadioOn}");
		}

	}
}
