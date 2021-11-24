using System;

namespace Ninjutsu_Database
{
	class Program
	{
		static void Main(string[] args)
		{
			Database database = new Database();

			database.AddNinjutsu(new Ninjutsu("Fire Release: Great Fireball Technique", "Flame Style"));
			database.AddNinjutsu(new Ninjutsu("Fire Release: Great Fire Annihilation", "Flame Style"));
			database.AddNinjutsu(new Ninjutsu("Shadow Clone Technique", "Supplementary"));
			database.AddNinjutsu(new Ninjutsu("Flying Thunder God Technique", "Supplementary"));
			database.AddNinjutsu(new Ninjutsu("Eight Trigrams Thirty-Two Palms", "Kekkei-Genkei Byuagugan"));
			database.AddNinjutsu(new Ninjutsu("Eight Trigrams Sealing Style", "Sealing Techniques"));
			database.AddNinjutsu(new Ninjutsu("Rasengan", "Ninjutsu"));

			foreach (Ninjutsu ninjustu in database.GetNinjutsu())
			{
				Console.WriteLine(ninjustu.NinjutsuName + " | " + ninjustu.NinjustuType);
			}


		}
	}
}
