using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl2.Data.Game.Map
{
	public class MapArea
	{
		int m_MapHeight = 0;
		int m_MapWidth = 0;
		Dictionary<int, Location> m_Locations = new Dictionary<int, Location>();
		int[,] m_Map;

		public int MapHeight { get { return m_MapHeight; } }
		public int MapWidth { get { return m_MapWidth; } }
		public int[,] Map { get { return m_Map; } set { m_Map = value; } }

		public MapArea(int height, int width)
		{
			m_MapHeight = height;
			m_MapWidth = width;

			m_Map = new int[height, width];
		}
		public bool GetLocation(int key, ref Location refLocation)
		{
			if (m_Locations.TryGetValue(key, out Location value))
			{
				refLocation = value;
				return true;
         }
         else
         {
				return false;
         }
		}
		
		public bool InsertLocation(Location newLocation)
		{
			try 
			{
				m_Locations.Add(newLocation.XPos, newLocation);
				return true;
			}
			catch
			{
				return false;
         }
      }
	}
}
