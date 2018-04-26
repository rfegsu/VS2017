using System;

namespace TestApp1
{
    class general
    {
        public static void printInt32(int[] arr)
        {
            string str = "";
            for(int x =0; x<arr.Length; x++)
            {
                str = str + arr[x] + ",";
            }
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Player hero = new Player(name);
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Your starting stats are:");
            general.printInt32(hero.getStats());
            Console.ReadKey();
        }
    }
    class Player
    {
        private string name;
        private int health;
        private int strength;
        private int dexterity;
        private int mana;

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
            this.strength = 20;
            this.dexterity = 20;
            this.mana = 20;
        }

        public int[] getStats()
        {
            int[] arr = { health, strength, dexterity, mana };
            return arr;
        }


    }
}
