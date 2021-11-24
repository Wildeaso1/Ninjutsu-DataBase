using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class Ninjutsu
	{
		public string NinjutsuName { get; private set; }
		public string NinjustuType { get; private set; }

		public Ninjutsu(string name, string type)
		{
			NinjutsuName = name;
			NinjustuType = type;
		}
	}
}
