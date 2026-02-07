using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Character
    {
        private static int speed = 10;
        public int Health { get; set; } = 100;
        public string Race { get; private set; }
        public int Armor { get; private set; }
        public Character(string race)
        {
            Race = race;
            Armor = 30;
        }
        public Character(string race, int armor = 30)
        {
            Race = race;
            Armor = armor;
        }

        public void Hit(int damage)
        {
            if (Health == 0)
                throw new InvalidOperationException("Can't hit a dead character.");

            if (damage > Health)
                throw new ArgumentException("damage can't be greater than current Health");

            if (damage > Health)
                damage = Health;

            //health -= damage;
            Health -= damage;
        }

        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            //speed += 10;
        }
    }
}


//public int Health
//{
//    get
//    {
//        return health;
//    }
//    private set
//    {
//        health = value;
//    }
//}

//Чем свойства есть на самом деле
//public int GetHealth()
//{
//    return health;
//}
//private void SetHealth(int value)
//{
//    health = value;
//}

