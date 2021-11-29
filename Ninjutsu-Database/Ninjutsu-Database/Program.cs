using System;

namespace Ninjutsu_Database
{
	class Program
	{
		static void Main(string[] args)
		{
			Database database = new Database();

			Ninjutsu FireballJutsu = new GreatFireBallJutsu("Great Fire Ball Jutsu", "\nThe user kneads chakra in their body and turns it into fire, which they then expel from their" +
				" mouth; the more chakra they use, the more flames that are produced.\n");

			Ninjutsu flyingRaijin = new FlyingRaijin("Flying Thunder God Technique", "\nBy entering a dimensional void, users can instantly teleport to a technique " +
				"formula's location whenever they please, regardless of distance.\n");

			database.AddNinjutsu(FireballJutsu);
			database.AddNinjutsu(flyingRaijin);

			foreach (Ninjutsu ninjutsu in database.GetNinjutsu())
			{
				Console.WriteLine(ninjutsu.NinjutsuName + ninjutsu.NinjutsuDescription);
			}

			database.Use(1);
		}
	}
}
