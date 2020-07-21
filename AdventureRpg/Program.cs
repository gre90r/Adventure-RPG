using System;

namespace AdventureRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Character myCharacter = new Character();
            Monster BearMonster = new Monster();            
            BearMonster.loot.Add(new Item { Name = "SuperSword", Armor = 0, Attack = 4 });
            BearMonster.loot.Add(new Item { Name = "Schield", Armor = 5, Attack = 0 });
            BearMonster.loot.Add(new Item { Name = "Axe", Armor = 0, Attack = 3 });
            BearMonster.loot.Add(new Item { Name = "Speer", Armor = 0, Attack = 2 });
            
            //drop items in the caracter

            



            // hp before attack
            Console.WriteLine("chracter hp = " + myCharacter.Hp);
            Console.WriteLine("monster hp = " + BearMonster.Hp);

            // deal damage
            while (myCharacter.Hp > 0 && BearMonster.Hp > 0)
            {
                if (myCharacter.Hp > 0)
                {
                    myCharacter.attack(ref BearMonster);
                }
                if (BearMonster.Hp > 0)
                {
                    BearMonster.attack(ref myCharacter);
                }

                // hp after attack
                Console.WriteLine("chracter hp = " + myCharacter.Hp);
                Console.WriteLine("monster hp = " + BearMonster.Hp);
            }
            // who has won (in the Program file)
            if (myCharacter.Hp > 0)
            {
                Console.WriteLine("character has won.");//monster is dead

                // choose a random drop from loot list
                Random RandomNumber = new Random(); // Instansiate the random object
                int OurRandomLootNumber = RandomNumber.Next(0, BearMonster.loot.Count - 1); // Gets a random number
                Console.WriteLine(BearMonster.loot[OurRandomLootNumber].Name); // Write out the item's name 

                // add loot to character's item list
                myCharacter.Items.Add(BearMonster.loot[OurRandomLootNumber]);
            }
            if (BearMonster.Hp > 0)
            {
                Console.WriteLine("monster has won.");
                
            } 
            

            // hp after attack
            Console.WriteLine("chracter hp = " + myCharacter.Hp);
            Console.WriteLine("monster hp = " + BearMonster.Hp);





        }
    }
}
