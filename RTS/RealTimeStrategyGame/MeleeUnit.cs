using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeStrategyGame
{
    class MeleeUnit : Unit
    {
        public MeleeUnit(int x, int y, string team): base(x, y, 100, 1, 10, 3, team, 'M') 
        {

        }
        public override int X
        {
            get { return x; }
            set { x = value; }
        }
        public override int Y
        {
            get { return y; }
            set { y = value; }
        }
        public override int Health
        {
            get { return health; }
            set { health = value; }
        }
        public override int MaxHealth
        {
            get { return health; }
        }
        public override string Team
        {
            get { return team; }
        }
        public override char Symbol
        {
            get { return symbol; }
        }
        public override bool IsDead
        {
            get { return isDead; }
        }
        public override bool IsInRange(Unit otherunit) //Checks if units are in range to attack
        {
            return GetDistance(otherunit) <= attackRange;
        }
        public override void Destroy() //Displays an X when a unit is destroyed
        {
            isDead = true;
            isAttacking = false;
            symbol = 'X';
        }
        public override Unit GetClosestUnit(Unit[] units) //Checks the distance between units
        {
            double closestDistance = int.MaxValue;
            Unit closestUnit = null;

            foreach (Unit otherUnit in units)
            {
                if (otherUnit == this || otherUnit.Team == Team || otherUnit.IsDead)
                {
                    continue;
                }

                double distance = GetDistance(otherUnit);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestUnit = otherUnit;
                }
            }
            return closestUnit;
        }
        public override void Attack(Unit otherUnit) //Determines if units can attack
        {
            isAttacking = false;
            otherUnit.Health -= attack;

            if (otherUnit.Health <= 0)
            {
                otherUnit.Destroy();
            }
        }

        public override void MovePosition(Unit closestUnit) //Moves units around map if they arent attacking
        {
            isAttacking = false;
            int xDirection = closestUnit.X - X;
            int yDirection = closestUnit.Y - Y;

            if (Math.Abs(xDirection) > Math.Abs(yDirection))
            {
                x += Math.Sign(xDirection);
            }
            else
            {
                y += Math.Sign(yDirection);
            }
        }
        public override void RunAway() //Moves units away from each other 
        {
            isAttacking = false;
            int direction = r.Next(0, 4);
            if (direction == 0)
            {
                x += 1;
            }
            else if (direction == 1)
            {
                x -= 1;
            }
            else if (direction == 2)
            {
                y += 1;
            }
            else
            {
                y -= 1;
            }
        }
    }
}
