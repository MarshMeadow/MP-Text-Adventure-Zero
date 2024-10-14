using System;

namespace FancyPantsAdventureCat
{
    // Enum representing the possible moods of the cat.
    enum CatMood
    {
        Curious,
        Playful,
        Sleepy,
        Hungry
    }

    // Struct to group the cat's stats together.
    struct CatStats
    {
        public string Name;
        public int Energy;
        public int Happiness;
        public CatMood Mood;

        public CatStats(string name, int energy, int happiness, CatMood mood)
        {
            Name = name;
            Energy = energy;
            Happiness = happiness;
            Mood = mood;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"\n{Name}'s Current Stats:");
            Console.WriteLine($"Energy: {Energy}");
            Console.WriteLine($"Happiness: {Happiness}");
            Console.WriteLine($"Mood: {Mood}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize game variables
            string catName;
            int adventureCount = 0;
            bool isPlaying = true;

            // Welcome the player and ask for the cat's name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Fancy Pants' Cat Adventure!");
            Console.ResetColor();

            Console.Write("What is your cat's name? ");
            catName = Console.ReadLine();

            // Initialize cat stats using a struct
            CatStats cat = new CatStats(catName, 10, 10, CatMood.Curious);

            Console.Clear();
            Console.WriteLine($"{catName} awakens in the soft glow of the Fancy Pants universe...");

            // Main game loop
            while (isPlaying)
            {
                // Display the current cat stats
                cat.DisplayStats();
                Console.WriteLine("\nWhat will your cat do?");
                Console.WriteLine("1. Explore the grasslands");
                Console.WriteLine("2. Chase the squiggly pencil monster");
                Console.WriteLine("3. Nap in the golden sun");
                Console.WriteLine("4. Eat some Fancy Fish");
                Console.WriteLine("5. Exit the game");

                string choice = Console.ReadLine();

                // Use switch case to handle the cat's actions
                switch (choice)
                {
                    case "1":
                        ExploreGrasslands(ref cat, ref adventureCount);
                        break;
                    case "2":
                        ChasePencilMonster(ref cat);
                        break;
                    case "3":
                        NapInTheSun(ref cat);
                        break;
                    case "4":
                        EatFancyFish(ref cat);
                        break;
                    case "5":
                        isPlaying = false;
                        Console.WriteLine("Thank you for playing! Meow!");
                        break;
                    default:
                        Console.WriteLine("That is not a valid option, please choose again.");
                        break;
                }

                // End game if energy is too low
                if (cat.Energy <= 0)
                {
                    Console.WriteLine($"\n{catName} is too tired to continue adventuring. Time to rest.");
                    isPlaying = false;
                }
            }
        }

        // Method for exploring grasslands
        static void ExploreGrasslands(ref CatStats cat, ref int adventureCount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{cat.Name} bounds through the tall grass, chasing after shadows and whispers of wind.");
            Console.ResetColor();

            cat.Energy -= 2;
            cat.Happiness += 3;
            cat.Mood = CatMood.Playful;
            adventureCount++;
            Console.WriteLine($"{cat.Name} had a great time exploring!");

            if (adventureCount % 3 == 0) // Every 3 adventures, increase difficulty
            {
                Console.WriteLine("The adventures are becoming more tiring, but more rewarding.");
                cat.Energy -= 1; // Additional energy drain
            }
        }

        // Method for chasing the pencil monster
        static void ChasePencilMonster(ref CatStats cat)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{cat.Name} pounces at the squiggly pencil monster, its movements erratic but exciting.");
            Console.ResetColor();

            cat.Energy -= 3;
            cat.Happiness += 5;
            cat.Mood = CatMood.Curious;
        }

        // Method for napping in the sun
        static void NapInTheSun(ref CatStats cat)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n{cat.Name} finds a warm spot and curls up, drifting into a peaceful slumber.");
            Console.ResetColor();

            cat.Energy += 5;
            cat.Happiness += 2;
            cat.Mood = CatMood.Sleepy;
        }

        // Method for eating Fancy Fish
        static void EatFancyFish(ref CatStats cat)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n{cat.Name} nibbles on some Fancy Fish, savoring every bite.");
            Console.ResetColor();

            cat.Energy += 3;
            cat.Happiness += 3;
            cat.Mood = CatMood.Hungry;
        }
    }
}