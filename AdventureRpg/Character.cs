using System;
using System.Collections.Generic;

namespace AdventureRpg
{
    /**
     * the character you are playing
     */
    public class Character
    {
        /*************/
        /* variables */
        /*************/
        public string Name { get; set; }
        public int Hp { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Armor { get; set; } = 5;
        public List<Item> Items { get; set; } = new List<Item>();

        /*************/
        /* functions */
        /*************/
        /// <summary>
        /// character attacks a monster
        /// </summary>
        /// <param name="monster">this monster gets damage</param>
        public void attack(ref Monster monster)
        {
            monster.Hp = monster.Hp - (this.Attack - monster.Armor);
        }
    }
}
