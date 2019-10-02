using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS__Task_One_
{
    public abstract class Unit
    {
        protected int X;
        protected int Y;
        protected int Health;
        protected int MaxHealth;
        protected int Speed;
        protected int Attack;
        protected int AttackRange;
        protected string Team;
        protected string Symbol;
        protected bool unitIsAttacking;

        public Unit(int X, int Y, int Health, int Speed, int Attack, int AttackRange, string Team, string Symbol, bool unitIsAttacking) //Constructor that receives parameters for each variable
        {
            this.X = X;
            this.Y = Y;
            this.Health = Health;
            this.MaxHealth = Health;
            this.Speed = Speed;
            this.Attack = Attack;
            this.AttackRange = AttackRange;
            this.Team = Team;
            this.Symbol = Symbol;
            this.unitIsAttacking = unitIsAttacking;
        }

         abstract public int XPOS
        {
            get;set;
        }

        abstract public int YPOS
        {
            get;set;
        }

        virtual public int HP
        {
            get;set;
        }

        virtual public int SPEED
        {
            get;set;
        }

        virtual public int ATTACK
        {
            get;set;
        }

        virtual public int ATTACKRANGE
        {
            get;set;
        }

         virtual public string TEAM
        {
            get;set;
        }

        virtual public string SYMBOL
        {
            get;set;
        }

        public abstract void MovePosition();
        public abstract void Combat();
        public abstract void OtherUnitAttackRange();
        public abstract void ReturnUnitPosition();
        public abstract void UnitDeath();
        public abstract override string ToString();    //added new cause it was shouting at me :\ 


    }







}

    

