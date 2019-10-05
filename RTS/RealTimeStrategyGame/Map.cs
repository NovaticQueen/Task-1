using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeStrategyGame
{
    class Map
    {
        int mapSize = 20;
        Random r = new Random();
        int numUnits;
        Unit[] units;
        string[,] map;
        string[] team = { "A- Team", "B-Team" };

        public Map(int numUnits)
        {
            this.numUnits = numUnits;
            Reset();
        }
        public Unit[] Units
        {
            get { return units; }
        }
        public int Size
        {
            get { return mapSize; }
        }

        public string MapDisplay() //Determines the layout of the map
        {
            string mapString = "";
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    mapString += map[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }

        public void Reset() //Resets the map for a new game
        {
            map = new string[mapSize, mapSize];
            units = new Unit[numUnits];
            InitialiseUnits();
            UpdateMap();
        }

        public void UpdateMap() //Updates the map throughout the game looping
        {
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    map[x, y] = "  .  ";
                }
            }

            foreach (Unit unit in units) //Places a unit where there is a  "  .  "
            {
                map[unit.X, unit.Y] = unit.Team[0] + "/" + unit.Symbol;
            }
        }

        public void InitialiseUnits() //Determines which units are placed where at the start of a game
        {
            for (int i = 0; i < units.Length; i++)
            {
                int x = r.Next(0, mapSize);
                int y = r.Next(0, mapSize);
                int teamIndex = r.Next(0, 2);
                int unitType = r.Next(0, 2);

                while (map[x,y] != null)
                {
                    x = r.Next(0, mapSize);
                    y = r.Next(0, mapSize);
                }

                if (unitType == 0 )
                {
                    units[i] = new MeleeUnit(x, y, team[teamIndex]); //Melee Unit
                }
                else
                {
                    units[i] = new RangedUnit(x, y, team[teamIndex]); //Ranged Unit
                }

                map[x, y] = units[i].Team[0] + "/" + units[i].Symbol;
            }
        }
    }
}
