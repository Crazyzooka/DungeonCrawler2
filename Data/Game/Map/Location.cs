using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonCrawl2.Data.System.Macros;

namespace DungeonCrawl2.Data.Game.Map
{
	public class Location
	{
		string m_Name;
		uint m_XPos;
		uint m_YPos;
		bool m_IsInWorld;
		uint[] lootTable = new uint[(uint)ItemType._END];

		public string Name { get { return m_Name; } set { m_Name = value; } }
		public uint XPos { get { return m_XPos; } set { m_XPos = value; } }
		public uint YPos { get { return m_YPos; } set { m_YPos = value; } }
		public bool IsInWorld { get { return m_IsInWorld; } set { m_IsInWorld = value; } }
		public Location()
		{
			m_IsInWorld = false;
		}
		public void SetLocation(uint xPos, uint yPos)
		{
			m_XPos = xPos;
			m_YPos = yPos;

			m_IsInWorld = true;
		}
	}
}
