using System;

namespace Ninjutsu_Database
{
	class Program
	{
		static void Main(string[] args)
		{
			Database database = new Database();

			database.AddNinjutsu(new Ninjutsu("Fireball Jutsu"));
			database.AddNinjutsu(new Ninjutsu("Majestic Flame Dragon"));
			foreach (Ninjutsu ninjustu in database.GetNinjutsu())
			{
				Console.WriteLine(ninjustu.NinjutsuName);
			}


		}
	}
}
