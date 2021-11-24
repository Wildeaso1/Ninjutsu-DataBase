using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class NinjutsuCatagory
	{
		public string NinjutsuTypeName { get; private set; }

		public NinjutsuCatagory(string Typename)
		{
			NinjutsuTypeName = Typename;
		}
	}
}
