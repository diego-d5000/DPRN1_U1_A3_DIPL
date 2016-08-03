using System;
using System.Collections.Generic;

// Namespace with classes declared
namespace Actividad3
{
	// initial class that executes on init 
	class MainClass
	{
		// porcentages constants of 4 areas in byte because is just a number of max value 100
		const byte MARKETING_BUDGET_PORCENTAGE = 20;
		const byte QNA_BUDGET_PORCENTAGE = 20;
		const byte PRODUCTION_BUDGET_PORCENTAGE = 40;
		const byte SALES_BUDGET_PORCENTAGE = 20;

		// initial method that executes first
		public static void Main(string[] args)
		{

			// declate string of user entry and total budget parsed in decimal because it can be a big number with two decimals
			string userEntry;
			decimal budget;

			// Appears in the console a message for the user
			Console.WriteLine("Entre el presupuesto inicial total: ");

			// assign read line in userEntry var
			userEntry = Console.ReadLine();
			// convert user entry in decimal type with two decimals
			budget = Math.Round(Convert.ToDecimal(userEntry), 2);

			// obtain respective budgets per area
			double marketingBudget = MARKETING_BUDGET_PORCENTAGE * (double)budget / 100;
			double qnaBudget = QNA_BUDGET_PORCENTAGE * (double)budget / 100;
			double productionBudget = PRODUCTION_BUDGET_PORCENTAGE * (double)budget / 100;
			double salesBudget = SALES_BUDGET_PORCENTAGE * (double)budget / 100;


			// Here we create a formatted string with projects names and format its sub-budget

			string marketingBudgetOutput = String.Format(
				@"
			Proyecto1_M (40%): ${0}
			Proyecto2_M (30%): ${1}
			Proyecto3_M (30%): ${2}
				",
			0.40 * marketingBudget,
			0.30 * marketingBudget,
			0.30 * marketingBudget);

			string qnaBudgetOutput = String.Format(
				@"
			Proyecto1_C (40%): ${0}
			Proyecto2_C (60%): ${1}
				",
			0.40 * qnaBudget,
			0.60 * qnaBudget);

			string productionBudgetOutput = String.Format(
				@"
			Proyecto1_P (15%): ${0}
			Proyecto2_P (30%): ${1}
			Proyecto3_P (30%): ${2}
			Proyecto4_P (25%): ${3}
				",
			0.15 * productionBudget,
			0.30 * productionBudget,
			0.30 * productionBudget,
			0.25 * productionBudget
		);

			string salesBudgetOutput = String.Format(
				@"
			Proyecto1_V (100%): ${0}
				",
			salesBudget
		);

			// finally format a final String with its area name and budget
			// in the formatted vars we found area budgets and previusly formatted string 

			string finalOutput = String.Format(
				@"
Presupuesto Total: ${0}
	
	Presupuesto  Mercadotecnia (20%): ${1}
	{2}
	Presupuesto  Calidad (20%): ${3}
	{4}
	Presupuesto  Producción (40%): ${5}
	{6}
	Presupuesto  Ventas (20%): ${7}
	{8}
				",
			budget,
			marketingBudget, marketingBudgetOutput,
			qnaBudget, qnaBudgetOutput,
			productionBudget, productionBudgetOutput,
			salesBudget, salesBudgetOutput
		);

			// and write all string in the console
			Console.WriteLine(finalOutput);
		}
	}
}
