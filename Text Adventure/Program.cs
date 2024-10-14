using System;

class FancyCatAdventure
{
    static void Main(string[] args)
    {
        // Game Introduction
        Console.WriteLine("Welcome, little furball, to the grand Fancy Pants Adventure!");
        Console.WriteLine("In this tale, you are the graceful feline sidekick—silent, swift, a shadow in the grass.");
        Console.WriteLine("You follow the ever-rushing Fancy Pants Man, but today, it's you who takes the lead.");
        Console.WriteLine("The world is wide, full of whisker-twitching delights and dangers, but your paws are light, and your heart is pure.");
        Console.WriteLine();
        Console.WriteLine("Press Enter to begin your adventure.");
        Console.ReadLine();

        // Start the Adventure
        StartAdventure();
    }

    static void StartAdventure()
    {
        string choice;
        Console.WriteLine("You open your eyes to the golden light of dawn, filtering through tall grasses.");
        Console.WriteLine("The Fancy Pants Man is nowhere to be seen—must have rushed ahead, as always.");
        Console.WriteLine("But there’s something in the air today, a scent of magic, mischief, and mystery.");
        Console.WriteLine();
        Console.WriteLine("Do you want to:");
        Console.WriteLine("1. Follow the familiar trail to Squiggleville.");
        Console.WriteLine("2. Chase a butterfly that flutters just out of reach.");
        Console.WriteLine("3. Investigate a glowing, secret path hidden by the trees.");
        Console.Write("Choose (1, 2, or 3): ");
        choice = Console.ReadLine();

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
        else
        {
            Console.WriteLine("Your indecision makes you yawn, but fate tugs at your paws. You must choose!");
            StartAdventure();
        }
    }

    static void SquigglevillePath()
    {
        Console.WriteLine("\nWith quiet pawsteps, you trot towards Squiggleville, where the world is full of squiggles—");
        Console.WriteLine("playful, wriggling shapes that bounce and giggle. You've seen Fancy Pants Man play here before,");
        Console.WriteLine("but today, it's your turn to pounce and play.");
        Console.WriteLine();
        Console.WriteLine("As you reach the village, you see a Squiggle in distress, its color fading and shrinking.");
        Console.WriteLine("It speaks to you in a tiny, trembling voice:");
        Console.WriteLine("'Oh noble feline! We are losing our color and bounce! Something evil lurks beyond the hills.'");
        Console.WriteLine("Do you:");
        Console.WriteLine("1. Comfort the Squiggle and offer your help.");
        Console.WriteLine("2. Ignore the Squiggle and explore the hills yourself.");
        Console.Write("Choose (1 or 2): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("\nYou purr softly and nuzzle the Squiggle. Its little face brightens with hope.");
            Console.WriteLine("'Thank you, kind one! Please, save our village!' it cries.");
            Console.WriteLine("You leap towards the hills, ready to face whatever strange force is stealing the joy from Squiggleville.");
            Console.WriteLine("Your journey continues, but the weight of your new mission makes your paws feel even lighter.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nWith a flick of your tail, you decide to leave the Squiggle behind.");
            Console.WriteLine("Your curiosity drives you towards the hills, where you sense something lurking, waiting for you.");
        }
        else
        {
            Console.WriteLine("The Squiggle looks at you expectantly, but you must make a choice...");
            SquigglevillePath();
        }

        // Continue the adventure here
    }

    static void ChaseButterfly()
    {
        Console.WriteLine("\nThe butterfly, with wings like pastel petals, flits through the air,");
        Console.WriteLine("daring you to chase it. Your paws dart through the grass, soft as whispers,");
        Console.WriteLine("as you leap after it, twirling in the sunlight.");
        Console.WriteLine();
        Console.WriteLine("Suddenly, it leads you to a meadow full of flowers you've never seen before.");
        Console.WriteLine("The butterfly hovers above a single, glowing flower, and you feel a strange pull in your heart.");
        Console.WriteLine();
        Console.WriteLine("Do you:");
        Console.WriteLine("1. Smell the flower.");
        Console.WriteLine("2. Bat playfully at the butterfly.");
        Console.Write("Choose (1 or 2): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("\nAs you breathe in the sweet, otherworldly scent, your vision blurs and swirls.");
            Console.WriteLine("The world around you melts into a dreamscape, and you find yourself in a land of floating squiggles and soft clouds.");
            Console.WriteLine("It’s beautiful and surreal, like a painting come to life.");
            // Continue the adventure here
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nYou bat at the butterfly, your paws gentle and playful.");
            Console.WriteLine("It dances in the air, giggling (yes, giggling!) as you chase it once more.");
            Console.WriteLine("The day feels long and lazy, a perfect afternoon of innocent delight.");
            // Continue the adventure here
        }
        else
        {
            Console.WriteLine("The butterfly pauses mid-air, waiting for you to choose...");
            ChaseButterfly();
        }
    }

    static void SecretPath()
    {
        Console.WriteLine("\nThe secret path beckons with the glow of mystery, and you can’t resist.");
        Console.WriteLine("Your paws step softly over moss-covered stones, as the trees whisper ancient secrets to you.");
        Console.WriteLine();
        Console.WriteLine("You walk until you find a hidden clearing with an ancient tree in the center.");
        Console.WriteLine("At the base of the tree is a glowing symbol—one that seems oddly familiar.");
        Console.WriteLine("Do you:");
        Console.WriteLine("1. Touch the symbol with your paw.");
        Console.WriteLine("2. Climb the tree to get a better look at the surroundings.");
        Console.Write("Choose (1 or 2): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("\nThe moment your paw touches the glowing symbol, a warm, golden light envelops you.");
            Console.WriteLine("You feel a deep connection to the forest and all its creatures, as if you’ve unlocked a hidden power.");
            // Continue the adventure here
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nYou climb the tree with grace and agility, reaching a high branch that overlooks the entire forest.");
            Console.WriteLine("From here, you can see the grand adventure awaiting you, stretching far beyond the horizon.");
            // Continue the adventure here
        }
        else
        {
            Console.WriteLine("The symbol hums quietly, urging you to make a decision...");
            SecretPath();
        }
    }
}