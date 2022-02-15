using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl2.Data.Game.Map
{
	public class MapArea
	{
		uint m_MapHeight = 0;
		uint m_MapWidth = 0;
		List<Location> m_Locations = new List<Location>();
		uint[,] m_Map;

		public uint MapHeight { get { return m_MapHeight; } }
		public uint MapWidth { get { return m_MapWidth; } }
		public List<Location> Locations { get { return m_Locations; } set { m_Locations = value; } }
		public uint[,] Map { get { return m_Map; } set { m_Map = value; } }

		public MapArea(uint height, uint width)
		{
			m_MapHeight = height;
			m_MapWidth = width;

			m_Map = new uint[height, width];
		}
	}
}
