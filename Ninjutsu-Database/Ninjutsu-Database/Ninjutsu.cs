using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class Ninjutsu
	{
		public string NinjutsuName { get; private set; }

		public Ninjutsu(string ninjutsuName)
		{
			NinjutsuName = ninjutsuName;
		}
	}
}
