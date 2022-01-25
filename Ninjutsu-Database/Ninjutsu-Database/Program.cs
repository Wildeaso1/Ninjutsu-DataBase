using System;

namespace Ninjutsu_Database
{

	
	class Program
	{
		static void Main(string[] args)
		{
			int Index = 1;
			int NinjutsuCount = 0;
			Database database = new Database();

			Ninjutsu FireballJutsu = new GreatFireBallJutsu("Great Fire Ball Jutsu", "\nThe user kneads chakra in their body and turns it into fire, which they then expel from their" +
				" mouth; the more chakra they use, the more flames that are produced.\n");

			Ninjutsu flyingRaijin = new FlyingRaijin("Flying Thunder God Technique", "\nBy entering a dimensional void, users can instantly teleport to a technique " +
				"formula's location whenever they please, regardless of distance.\n");

			database.AddNinjutsu(FireballJutsu);
			database.AddNinjutsu(flyingRaijin);

			Console.WriteLine("Which Ninjutsu do you wanna use?\n");
			
			foreach (Ninjutsu ninjutsu in database.GetNinjutsu())
			{
				
				Console.WriteLine(ninjutsu.NinjutsuName + ninjutsu.NinjutsuDescription);
				NinjutsuCount = database.GetNinjutsuCount();
			}

			foreach (Ninjutsu ninjutsu in database.GetNinjutsu())
			{
				Console.WriteLine($"Jutsu: {Index}  {ninjutsu.NinjutsuName}\n");
				Index++;
			}

			while (true)
			{
				int Jutsu;
				string Input = Console.ReadLine();
				Int32.TryParse(Input, out Jutsu);
				Console.Clear();
				Index = 1;
				if (!Int32.TryParse(Input, out Jutsu))
				{
					Console.WriteLine("You can't use nothing!\n");
					foreach (Ninjutsu ninjutsu in database.GetNinjutsu())
					{
						Console.WriteLine($"Jutsu: {Index}  {ninjutsu.NinjutsuName}\n");
						Index++;
					}

				}
				if (Int32.TryParse(Input, out Jutsu) && Jutsu <= NinjutsuCount)
				{
					database.Use(Jutsu);
					Console.WriteLine("\n");
					foreach (Ninjutsu ninjutsu in database.GetNinjutsu())
					{
						Console.WriteLine($"Jutsu: {Index}  {ninjutsu.NinjutsuName}\n");
						Index++;
					}
				}

				if (Jutsu > NinjutsuCount)
				{
					Console.WriteLine("You can't use nothing!\n");
					foreach (Ninjutsu ninjutsu in database.GetNinjutsu())
					{
						Console.WriteLine($"Jutsu: {Index}  {ninjutsu.NinjutsuName}\n");
						Index++;
					}
				}
			}

			/*while (true)
			{
				ConsoleKeyInfo Keyinfo = Console.ReadKey();
				Console.Clear();
				switch (Keyinfo.KeyChar)
				{
					case '1':
						database.Use(0);
						break;
					case '2':
						database.Use(1);
						break;
					default:
						Console.WriteLine("You ran away.. Sad..");
						break;
				}
			}*/
		}
	}
}
