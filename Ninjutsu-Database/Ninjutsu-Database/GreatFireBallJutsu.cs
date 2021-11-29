using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class GreatFireBallJutsu : Ninjutsu
	{
		private int damage = 10;

		public GreatFireBallJutsu(string name, string description) : base(name, description)
		{
		}

		public override void UseNinjutsu()
		{
			Console.WriteLine($"You just used {NinjutsuName} on the enemy dealing {damage} damage!");
		}
	}
}
