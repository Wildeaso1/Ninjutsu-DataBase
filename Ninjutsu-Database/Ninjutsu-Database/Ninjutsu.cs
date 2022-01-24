using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	public abstract class Ninjutsu
	{
		public string NinjutsuName { get; private set; }
		public string NinjutsuDescription { get; private set; }


		public Ninjutsu(string ninjutsuName, string description)
		{
			this.NinjutsuName = ninjutsuName;
			this.NinjutsuDescription = description;

		}

		public abstract void UseNinjutsu();
	}
}
