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

		public MapArea Generate(uint height, uint width)
		{
			MapArea map = new MapArea(height, width);
			map.Locations = GenerateLocations(height, width);
			//GeneratePaths(map);

			return map;
		}
		private List<Location> GenerateLocations(uint height, uint width)
		{
			List<Location> locations = new List<Location>();
			Random rand = new Random();

			for (int row = 0; row < height; row++)
			{
				for (int col = 0; col < width; col++)
				{
					map[row,col] = 0;

					if (rand.Next(10) == 0)
					{
						map[row, col] = 2;
					}
				}
			}
			return locations;
		}
		private uint[,] GeneratePath(uint[,] map)
		{
			return map;
		}
		private int CalculateCellDistance(int x1, int y1, int x2, int y2)
		{
			int xDist = Math.Abs(x1 - x2);
			int yDist = Math.Abs(y1 - y2);

			return xDist > yDist ? xDist : yDist;
		}
	}
}
