using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character
    {
        public int Health { get; private set; } = 100;

        public void Hit (int damage)
        {
            if (damage > Health)
                damage = Health;

            //health -= damage;
            Health -= damage;
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

