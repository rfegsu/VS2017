using System;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Player hero = new Player(name);
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Your starting stats are:");
            Console.WriteLine("Health: {0}", hero.getHealth());
            Console.WriteLine("Strength: {0}", hero.getStrength());
            Console.WriteLine("Dexterity: {0}", hero.getDexterity());
            Console.WriteLine("Mana: {0}", hero.getMana());
            hero.levelUp();
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
        private int level;

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
            this.strength = 20;
            this.dexterity = 20;
            this.mana = 20;
            this.level = 1;
        }

        public void levelUp()
        {
            Console.WriteLine("Congrats choose a stat to level up:");
            Console.WriteLine("health, strength, dexterity or mana>");
            string choice = Console.ReadLine().ToLower();
            switch(choice)
            {
                case "health":
                    this.level++;
                    this.health +=5;
                    Console.WriteLine("Health increased to {0}", this.health);
                    break;
                case "strength":
                    this.level++;
                    this.strength++;
                    Console.WriteLine("Strength increased to {0}", this.strength);
                    break;
                case "dexterity":
                    this.level++;
                    this.dexterity++;
                    Console.WriteLine("Dexterity increased to {0}", this.dexterity);
                    break;
                case "mana":
                    this.level++;
                    this.mana++;
                    Console.WriteLine("Mana increased to {0}", this.mana);
                    break;
                default:
                    Console.WriteLine("broken??");
                    break;
            }
        }

        public void damage(int damage)
        {
            this.health -= damage;
        }

        //getters
        public int[] getStats()
        {
            int[] arr = { health, strength, dexterity, mana };
            return arr;
        }
        public int getHealth()
        {
            return this.health;
        }
        public int getStrength()
        {
           return this.strength;
        }
        public int getDexterity()
        {
            return this.dexterity;
        }
        public int getMana()
        {
            return this.mana;
        }
        public string getName()
        {
            return this.name;
        }
        public int getLevel()
        {
            return this.level;
        }
    }


    class enemy
    {
        private string name;
        private int health;
        private int strength;
        private int dexterity;
        private int mana;
        private float scaler = 0.1;

        public enemy(Player player)
        {
            this.health = 10 * player.getLevel();
            this.strength = 5 * player.getLevel();
            this.dexterity = 5 * player.getLevel();
            this.mana = 5 * player.getLevel();
        }

        public  int attack(Player player)
        {
            return Math.Round((this.strength * this.dexterity * scaler));
        }
    }
}
