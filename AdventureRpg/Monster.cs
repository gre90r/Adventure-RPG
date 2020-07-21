using System.Collections.Generic;

namespace AdventureRpg
{
    public class Monster
    {
        /*************/
        /* variables */ //Static objects (int string,bool)
        /*************/
        public string Name { get; set; }
        public int Hp { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Armor { get; set; } = 4;
        //----------------------------------------------------------
        //   We want the list.                    Wehre the list is
        //                                      The place where its stored
        //public List<Item> loot { get; set; } = new List<Item>();
       
        public List<Item> loot { get; set; } = new List<Item>(); //instanz machen

        /*************/
        /* functions */
        /*************/
        public void attack(ref Character character)
        {
            character.Hp = character.Hp - (this.Attack - character.Armor);
        }
    }
}