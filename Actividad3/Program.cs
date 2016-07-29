using System;
using System.Collections.Generic

namespace Actividad3
{
	enum AreasPercentage : byte { Mercadotecnia = 20, QnA = 20, Production = 40, Sales = 20 };
	enum MarketingProjectsPercentage : byte { Proyecto1_M = 40, Proyecto2_M = 30, Proyecto3_M = 30 };
	enum QnAProjectsPercentage : byte { Proyecto1_C = 40, Proyecto2_C = 60 };
	enum ProductionProjectsPercentage : byte { Proyecto1_P = 15, Proyecto2_P = 30, Proyecto3_P = 30, Proyecto4_P = 25 };
	enum SalesProjectsPercentage : byte { Proyecto3_V = 100 };

	class MainClass
	{
		public static void Main(string[] args)
		{
			string userEntry;
			decimal budget;

			string marketingBudgetOutput;
			string qnaBudgetOutput;
			string productionBudgetOutput;
			string salesBudgetOutput;

			for()


			userEntry = Console.ReadLine();
			budget = Math.Round(Convert.ToDecimal(userEntry), 2);

			string output = @"
Presupuesto Inicial: {0}

  Presupuesto {} (20%): {1}
  Presupuesto {} (20%): {1}
  Presupuesto {} (40%): {1}
  Presupuesto Mercadotecnia (20%): {1}

			";

			string finalOutput = string.Format(output, asd); 
			Console.WriteLine(budget);
		}
	}
}
