using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class Database
	{
		private List<Ninjutsu> _Ninjustu;

		public Database()
		{
			_Ninjustu = new List<Ninjutsu>();
		}

		public void AddNinjutsu(Ninjutsu ninjutsu)
		{
			_Ninjustu.Add(ninjutsu);
		}

		public List<Ninjutsu> GetNinjutsu()
		{
			return _Ninjustu;
		}

		public void Use(int Index)
		{
			_Ninjustu[Index].UseNinjutsu();
		}
	}
}
