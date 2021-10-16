using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DandG
{
    public partial class _default : System.Web.UI.Page
    {
        
   
        protected void Page_Load(object sender, EventArgs e)
        {

            Charcter hero = new Charcter();
            Charcter monster = new Charcter();

            #region chartecter_stats
            hero.name = "john";
            hero.helth = 35;
            hero.damage_max = 20;
            hero.dam_bonus = false;

            monster.name = "ghoul";
            monster.helth = 10;
            monster.damage_max = 20;
            monster.dam_bonus = false;
            #endregion

            int damage;
            damage = hero.attack();
            print_stats(hero);
            monster.defend(damage);
           
        }
        private void print_stats(Charcter charcter)
        {
            label_result.Text += String.Format("charcter name - {0} / charter helth = {1} / maxium damage = {2} / has attack bonus enabled - {3}",
                charcter.name,
                charcter.helth,
                charcter.damage_max,
                charcter.dam_bonus);
        }

       

        
    }
}