using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeStrategyGame
{
    class GameEngine
    {
        Map map;
        bool isGameOver = false;
        string winningTeam = "";
        int round = 0;

        public GameEngine()
        {
            map = new Map(10);
        }

        public bool IsGameOver
        {
            get{ return isGameOver; }
        }

        public string WinningTeam
        {
            get { return winningTeam; }
        }

        public int Round
        {
            get { return round; }
        }

        public string MapDisplay() //Gives access for the form
        {
            return map.MapDisplay();
        }

        public string UnitInfo() //Updates textbox with unit information
        {
            string unitInfo = "";
            foreach (Unit unit in map.Units)
            {
                unitInfo += unit + "\n";
            }
            return unitInfo;
        }

        public void Reset() //Resets the game
        {
            map.Reset();
            isGameOver = false;
            round = 0;
        }

        public void GameLoop() //Determines the main game logic 
        {
            foreach (Unit unit in map.Units) //checks if units are dead
            {
                if (unit.IsDead)
                {
                    continue;
                }

                Unit closestUnit = unit.GetClosestUnit(map.Units); //Determines where the closest unit is

                if (closestUnit == null)
                {
                    isGameOver = true;
                    winningTeam = unit.Team;
                    map.UpdateMap();
                    return;
                }

                double healthPercentage = unit.Health / unit.MaxHealth; //Determines what the unit should do if their health is at a certain level
                if (healthPercentage <= 0.25)
                {
                    unit.RunAway();
                }
                else if (unit.IsInRange(closestUnit))
                {
                    unit.Attack(closestUnit);
                }
                else
                {
                    unit.MovePosition(closestUnit);
                }
                StayInBounds(unit, map.Size);
            }

            map.UpdateMap();
            round++;
        }

        private void StayInBounds(Unit unit, int size) //Used so units dont go off the map
        {
            if(unit.X < 0)
            {
                unit.X = 0;
            }
            else if (unit.X >= size)
            {
                unit.X = size - 1;
            }
            if (unit.Y < 0)
            {
                unit.Y = 0;
            }
            else if (unit.Y >= size)
            {
                unit.Y = size - 1;
            }
        }
    }
}
