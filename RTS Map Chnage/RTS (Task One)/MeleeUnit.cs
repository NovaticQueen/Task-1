using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS__Task_One_
{
    class MeleeUnit : Unit
    {
        static Random random = new Random(); 

        public MeleeUnit() : base( 0,  0,  100, 2, 5,  1,  "Melee", "@", false)
        {
            
        } 

        override public int XPOS
        {
            get; set;
        }
        override public int YPOS
        {
            get;set;
        }

        override public int HP
        {
            get;set;
        }        

        override public int SPEED
        {
            get;set;
        }

        override public int ATTACK
        {
            get;set;
        }

        override public int ATTACKRANGE
        {
            get;set;
        }

        override public string TEAM
        {
            get;set;
        }

        override public string SYMBOL
        {
            get;set;
        }
        
        override public void MovePosition()
        {
            
        }
        override public void Combat()
        {

        }
        override public void OtherUnitAttackRange()
        {

        }
        override public void ReturnUnitPosition()
        {

        }
        override public void UnitDeath()
        {

        }
        override public string ToString()
        {
            return $"Unit type {Team}, {X} Row, {Y} Column, {Health} HP, {Speed} Speed " + "\n";
            /*"Unit Information: " + "\n" + "Health: " + HP + "\n" + "Row & Column: " + X + ";" + Y + "\n" + "Speed: " + Speed;*/            
        }
    }
}
