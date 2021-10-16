using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DandG
{
    public class Charcter
    {
        public string name;
        public int helth, damage_max;
        public bool dam_bonus;

        

        public int attack()
        {
            Random random_val;
                random_val = new Random();

            int damage = random_val.Next(this.damage_max);
            return damage;
        }
        public void defend(int damage)
        {
            this.helth -= damage;
        }



    }
}