using System;

class FancyCatAdventure
{
    static void Main(string[] args)
    {
        // Set initial color
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        // Game Introduction
        Console.WriteLine("Welcome, little furball, to the grand Fancy Pants Adventure!");
        Console.WriteLine("In this tale, you are the graceful feline sidekick—silent, swift, a shadow in the grass.");
        Console.WriteLine("You follow the ever-rushing Fancy Pants Man, but today, it's you who takes the lead.");
        Console.WriteLine("The world is wide, full of whisker-twitching delights and dangers, but your paws are light, and your heart is pure.");
        Console.WriteLine();

        // Set a lighter yellow color for emphasis
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Press Enter to begin your adventure.");
        Console.ReadLine();

        // Start the Adventure
        StartAdventure();
    }

    static void StartAdventure()
    {
        string choice;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("You open your eyes to the golden light of dawn, filtering through tall grasses.");
        Console.WriteLine("The Fancy Pants Man is nowhere to be seen—must have rushed ahead, as always.");
        Console.WriteLine("But there’s something in the air today, a scent of magic, mischief, and mystery.");
        Console.WriteLine();

        // Prompt user for a choice
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Do you want to:");
        Console.WriteLine("1. Follow the familiar trail to Squiggleville.");
        Console.WriteLine("2. Chase a butterfly that flutters just out of reach.");
        Console.WriteLine("3. Investigate a glowing, secret path hidden by the trees.");
        Console.WriteLine("4. Skip to the next part.");
        Console.WriteLine("5. Go back to the previous section (Start the adventure).");
        Console.Write("Choose (1, 2, 3, 4, or 5): ");

        Console.ForegroundColor = ConsoleColor.White;
        choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Invalid choice. Please select 1, 2, 3, 4, or 5.");
            Console.Write("Choose (1, 2, 3, 4, or 5): ");

            Console.ForegroundColor = ConsoleColor.White;
            choice = Console.ReadLine();
        }

        if (choice == "1")
        {
            SquigglevillePath();
        }
        else if (choice == "2")
        {
            ChaseButterfly();
        }
        else if (choice == "3")
        {
            SecretPath();
        }
        else if (choice == "4")
        {
            Console.WriteLine("\nYou choose to skip ahead, but feel free to explore the adventure later.");
            ContinueAdventure();
        }
        else if (choice == "5")
        {
            Console.WriteLine("\nYou decide to retrace your steps...");
            StartAdventure();
        }
    }

    static void SquigglevillePath()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nWith quiet pawsteps, you trot towards Squiggleville, where the world is full of squiggles—");
        Console.WriteLine("playful, wriggling shapes that bounce and giggle. You've seen Fancy Pants Man play here before,");
        Console.WriteLine("but today, it's your turn to pounce and play.");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("As you reach the village, you see a Squiggle in distress, its color fading and shrinking.");
        Console.WriteLine("It speaks to you in a tiny, trembling voice:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("'Oh noble feline! We are losing our color and bounce! Something evil lurks beyond the hills.'");

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Do you:");
        Console.WriteLine("1. Comfort the Squiggle and offer your help.");
        Console.WriteLine("2. Ignore the Squiggle and explore the hills yourself.");
        Console.WriteLine("3. Go back to the previous section (Main Adventure).");
        Console.WriteLine("4. Skip this part.");
        Console.Write("Choose (1, 2, 3, or 4): ");

        Console.ForegroundColor = ConsoleColor.White;
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Invalid choice. Please select 1, 2, 3, or 4.");
            Console.Write("Choose (1, 2, 3, or 4): ");

            Console.ForegroundColor = ConsoleColor.White;
            choice = Console.ReadLine();
        }

        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou purr softly and nuzzle the Squiggle. Its little face brightens with hope.");
            Console.WriteLine("'Thank you, kind one! Please, save our village!' it cries.");
            Console.WriteLine("You leap towards the hills, ready to face whatever strange force is stealing the joy from Squiggleville.");
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWith a flick of your tail, you decide to leave the Squiggle behind.");
            Console.WriteLine("Your curiosity drives you towards the hills, where you sense something lurking, waiting for you.");
        }
        else if (choice == "3")
        {
            Console.WriteLine("\nYou decide to go back.");
            StartAdventure();
        }
        else if (choice == "4")
        {
            Console.WriteLine("\nYou skip this part and move on.");
        }

        // Continue the adventure
        ContinueAdventure();
    }

    static void ChaseButterfly()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nThe butterfly, with wings like pastel petals, flits through the air,");
        Console.WriteLine("daring you to chase it. Your paws dart through the grass, soft as whispers,");
        Console.WriteLine("as you leap after it, twirling in the sunlight.");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Do you want to:");
        Console.WriteLine("1. Continue chasing the butterfly.");
        Console.WriteLine("2. Go back to the previous section (Main Adventure).");
        Console.WriteLine("3. Skip this part.");
        Console.Write("Choose (1, 2, or 3): ");

        Console.ForegroundColor = ConsoleColor.White;
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Invalid choice. Please select 1, 2, or 3.");
            Console.Write("Choose (1, 2, or 3): ");

            Console.ForegroundColor = ConsoleColor.White;
            choice = Console.ReadLine();
        }

        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou leap after the butterfly, twirling and laughing (yes, you can laugh!).");
            Console.WriteLine("It leads you to a secret meadow, full of flowers you've never seen before.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nYou decide to go back.");
            StartAdventure();
        }
        else if (choice == "3")
        {
            Console.WriteLine("\nYou skip this part and move on.");
        }

        // Continue the adventure
        ContinueAdventure();
    }

    static void SecretPath()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nThe secret path beckons with the glow of mystery, and you can’t resist.");
        Console.WriteLine("Your paws step softly over moss-covered stones, as the trees whisper ancient secrets to you.");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Do you want to:");
        Console.WriteLine("1. Explore the path further.");
        Console.WriteLine("2. Go back to the previous section (Main Adventure).");
        Console.WriteLine("3. Skip this part.");
        Console.Write("Choose (1, 2, or 3): ");

        Console.ForegroundColor = ConsoleColor.White;
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Invalid choice. Please select 1, 2, or 3.");
            Console.Write("Choose (1, 2, or 3): ");

            Console.ForegroundColor = ConsoleColor.White;
            choice = Console.ReadLine();
        }

        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou continue down the path, and the trees begin to glow softly.");
            Console.WriteLine("Ahead, you find an ancient tree with a glowing symbol.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nYou decide to go back.");
            StartAdventure();
        }
        else if (choice == "3")
        {
            Console.WriteLine("\nYou skip this part and move on.");
        }

        // Continue the adventure
        ContinueAdventure();
    }

    static void ContinueAdventure()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nYou have completed another part of your Fancy Pants Adventure!");
        Console.WriteLine("Do you want to:");
        Console.WriteLine("1. Continue the adventure.");
        Console.WriteLine("2. End your journey.");
        Console.Write("Choose (1 or 2): ");

        Console.ForegroundColor = ConsoleColor.White;
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Invalid choice. Please select 1 or 2.");
            Console.Write("Choose (1 or 2): ");

            Console.ForegroundColor = ConsoleColor.White;
            choice = Console.ReadLine();
        }

        if (choice == "1")
        {
            StartAdventure();
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nThank you for playing, brave feline! Your Fancy Pants Adventure has come to an end.");
        }
    }
}
