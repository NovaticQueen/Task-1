using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeStrategyGame
{
    abstract class Unit
    {
        protected int x, y, health, maxHealth, speed, attack, attackRange; //Declare all required variables 
        protected string team;
        protected char symbol;
        protected bool isAttacking = false;
        protected bool isDead = false;

        public static Random r = new Random();

        public Unit(int x, int y, int health, int speed, int attack, int attackRange, string team, char symbol) //Constructor that receives parameters for each variable
        {
            this.x = x;
            this.y = y;
            this.health = health;
            maxHealth = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.team = team;
            this.symbol = symbol;
        }

        public abstract int X { get; set; }
        public abstract int Y { get; set; }
        public abstract int Health { get; set; }
        public abstract int MaxHealth { get; }
        public abstract string Team { get; }
        public abstract char Symbol { get; }
        public abstract bool IsDead { get; }


        public abstract void MovePosition(Unit closestUnit);
        public abstract void Attack(Unit otherUnit);
        public abstract void RunAway();
        public abstract bool IsInRange(Unit otherunit);
        public abstract Unit GetClosestUnit(Unit[] units);
        public abstract void Destroy();

        protected double GetDistance(Unit otherUnit)
        {
            double xDistance = otherUnit.X - X;
            double yDistance = otherUnit.Y - Y;
            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }

        public override string ToString()
        {
            return "Position: " + x + "," + y + "\n" +
                   "Health: " + health + "||" + maxHealth + "\n" +
                   "Team: " + team + "  ( " + symbol + " )  \n";
        }
    }
}
