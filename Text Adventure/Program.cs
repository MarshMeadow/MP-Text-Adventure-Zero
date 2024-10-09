using System;

namespace CutiePantsAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cutie Pants Adventure!\n");
            Console.WriteLine("You're Fancy Pants Man, and your beloved cat, Cutie Pants, has run off for an adventure!\n");
            Console.WriteLine("You must find him while dodging yarn balls, chasing butterflies, and enjoying some cat naps along the way.\n");

            bool gameOver = false;
            string playerName = "Fancy Pants Man";

            while (!gameOver)
            {
                Console.WriteLine("\nYou find yourself at a crossroad. Where would you like to go?");
                Console.WriteLine("1. Chase the sparkling butterfly.");
                Console.WriteLine("2. Investigate the suspicious pile of yarn.");
                Console.WriteLine("3. Take a catnap in the sunny patch.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ButterflyAdventure();
                        break;
                    case "2":
                        YarnAdventure();
                        break;
                    case "3":
                        CatnapAdventure();
                        break;
                    default:
                        Console.WriteLine("\nCutie Pants meows in confusion. Let's try that again!");
                        break;
                }

                Console.WriteLine("\nDo you want to keep playing? (yes/no)");
                string continuePlaying = Console.ReadLine().ToLower();
                if (continuePlaying == "no")
                {
                    gameOver = true;
                    Console.WriteLine("\nThanks for playing! Cutie Pants will miss you. 🐾");
                }
            }
        }

        static void ButterflyAdventure()
        {
            Console.WriteLine("\nYou decide to chase the sparkling butterfly.");
            Console.WriteLine("The butterfly flutters ahead, and Cutie Pants, being curious, follows behind.");
            Console.WriteLine("As you both leap through the fields, Cutie Pants pauses to bat at a dandelion puff and sneezes! Achoo!");
            Console.WriteLine("Cutie Pants then prances in circles, trying to catch its tail. How cute!");
        }

        static void YarnAdventure()
        {
            Console.WriteLine("\nYou investigate the suspicious pile of yarn.");
            Console.WriteLine("Cutie Pants has somehow managed to get completely tangled up in it!");
            Console.WriteLine("You untangle him carefully, but he immediately jumps back into the yarn and rolls around in joy.");
            Console.WriteLine("As a reward, he brings you a little yarn ball and stares up with big eyes. How could you resist? 🧶");
        }

        static void CatnapAdventure()
        {
            Console.WriteLine("\nFeeling tired? Cutie Pants decides it's time for a nap.");
            Console.WriteLine("You both lie down in the warm sun. Cutie Pants curls up on your chest and purrs softly.");
            Console.WriteLine("The sound of birds chirping in the background and Cutie Pants' soft purring makes you feel at peace.");
            Console.WriteLine("But Cutie Pants, being a cat, soon gets bored and nudges your face with his paw. Nap time over! 😸");
        }
    }
}
