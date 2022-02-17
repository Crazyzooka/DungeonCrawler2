using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl2.Data.Game.Map
{
	public class MapGenerator
	{
		private static readonly MapGenerator s_Singleton = new MapGenerator();
		static MapGenerator() {}
		private MapGenerator() {}
		public static MapGenerator Get
		{
			get { return s_Singleton; }
		}

		public MapArea Generate(int height, int width)
		{
			MapArea map = new MapArea(height, width);
			GenerateLocations(ref map);

			return map;
		}
		private void GenerateLocations(ref MapArea resultMap)
		{
			Random rand = new Random();
			int numLocations = rand.Next(resultMap.MapHeight * resultMap.MapWidth / 6);

			Dictionary<int, Location> occupiedX = new Dictionary<int, Location>();
			Dictionary<int, Location> occupiedY = new Dictionary<int, Location>();

			for (int location = 0; location < numLocations; location++)
			{
				Location area = new Location();
				int x = rand.Next(resultMap.MapHeight);
				int y = rand.Next(resultMap.MapWidth);

				if (occupiedX.TryGetValue(x, out bool value) == false && occupiedY.TryGetValue(y, out bool value2) == false)
				{
					area.SetLocation(x, y);
				}
			}
		}
		private void GeneratePath(ref MapArea resultMap)
		{
		}
		private int CalculateCellDistance(int x1, int y1, int x2, int y2)
		{
			int xDist = Math.Abs(x1 - x2);
			int yDist = Math.Abs(y1 - y2);

			return xDist > yDist ? xDist : yDist;
		}
	}
}
