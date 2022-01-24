using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjutsu_Database
{
	class Database
	{
		public List<Ninjutsu> _Ninjutsu { get; private set; }
		public Database()
		{
			_Ninjutsu = new List<Ninjutsu>();
		}

		public void AddNinjutsu(Ninjutsu ninjutsu)
		{
			_Ninjutsu.Add(ninjutsu);
		}

		public List<Ninjutsu> GetNinjutsu()
		{
			return _Ninjutsu;
			
		}

		public int GetNinjutsuCount()
		{
			return _Ninjutsu.Count;
		}
		
		public void Use(int Index)
		{
			_Ninjutsu[Index -1].UseNinjutsu();
		}
	}
}
