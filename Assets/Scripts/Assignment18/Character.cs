using System;
using UnityEngine;

namespace Assignment18
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set { health = Math.Min(value, 100); }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) 
        {
            
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("Name :" +  name);
            Debug.Log("Health : " +  health);
            this.position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.Health = target.Health - damage;
        }

        public void Attack(int damage, Character target, string attackType)
        {
            this.Attack(damage, target);
            Debug.Log("Attack type : " + attackType);
        }


    }
}
