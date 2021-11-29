using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class FlyingRaijin : Ninjutsu
	{

		public FlyingRaijin(string name, string description) : base(name, description)
		{
		}

		public override void UseNinjutsu()
		{
			Console.WriteLine($"You just used {NinjutsuName}! You instantly teleported to your marked location!");
		}
	}
}
