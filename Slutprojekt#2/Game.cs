using System;
using System.Runtime.CompilerServices;

public static class GameMethods{

    private static string princessName;
    private static int princessHP = 100;
    private static int dragonHP = 100;



    private static void Intro(){
        Console.WriteLine("In a cold and desolate stone tower, you reside, alone and shivering.");
        Console.WriteLine("You have no idea who brought you here, for what purpose, or even if you'll ever get out. All you known is that you're a princess.");
        Console.WriteLine(" Well, you assume so. Not many common folk proudly display a pure golden crown adorned with jewels atop their head. Not like you would know regardless.");
        Console.WriteLine(" All you've ever known is the inside of this tower, inside this bedroom, and all you have to your name is.. ");
        Console.WriteLine("Actually, do you even have a name?: ");
        princessName = Console.ReadLine();

        Console.WriteLine($"Ah, yes. Pardon me, Princess {princessName}. Now, where was I? Right.");
        Console.WriteLine("All you have to your name is the long floor length dress you're currently wearing, and the aforementioned crown atop your head.");
        Console.WriteLine("Despite your unfamiliar situation you've been put in, you decide to take the initiative to break yourself out.");
    }

    public static void EscapeTower(){
        Console.WriteLine("Looking around, you spot three ways to get out.");  
        
        Console.WriteLine("1. Knock over the giant metal door");
        Console.WriteLine("2. Try to reach the window on the ceiling");
        Console.WriteLine("3. Find a weakness in the wall cracks");

        Console.WriteLine("What will you do?: ");
        string choice = Console.ReadLine();

        if (choice == "1"){
            Breakdoor();
        }

        else if (choice == "2"){
            Window();
        }

        else if(choice == "3"){
            Wallcrack();
        }

    }

    private static void Breakdoor(){
        princessHP -= 5;
        Console.WriteLine("You first notice the big metal door blocking your way down into the staircase of the tower.  Its large and imposing, making you feel like an ant compared to its great height and width.");
        Console.WriteLine("You run towards it at full speed, hoping it'll fall over from your mighty shove. Instead, you injure yourself.");
        Console.WriteLine($"{princessName} takes 5 damage! HP: {princessHP}");

        EscapeTower();

        if (princessHP <= 0){
            Console.WriteLine($"Your frail body collapses to the floor after injuring yoruself to the farthest degree. This is your last chapter, Princess {princessName}");
            Console.ReadLine();
            return;
        }
        
    }

    private static void Window(){
        Console.WriteLine("You try to reach for the window by climbing on the surrounding furniture, but nothing manages to reach it. Tough luck.");
        EscapeTower();
    }

    private static void Wallcrack(){
        Console.WriteLine("You put your hands up to the wall, feeling a small gust of wind peed through the stones keeping the wall together.");
        Console.WriteLine("You use your elbow to hit the wall in its weak spot, making the rest of the stones crumble with it, exposing the outside.");
        Console.WriteLine("You finally have a use for the rope you were tied up with! or you could simply risk it, and jump down?");

        Console.WriteLine("1. Use a rope");
        Console.WriteLine("2. Jump");
        Console.WriteLine("What will you do?: ");
        string choice = Console.ReadLine();

        if (choice == "1"){
            Console.WriteLine("Sensibly, you use the rope and get down safely to continue on your journey.");
        }

        else if (choice == "2"){
            Random jump = new Random();
            int jumpchance = jump.Next(1, 101);

            if (jumpchance <= 60){
                int dmg = 30;
                princessHP -= dmg;
                Console.WriteLine("Instead of taking the safe way down for whatever reeason, you leap down and land on your feet, injuring your ankles.");
                Console.WriteLine($"{princessName} takes 30 damage! HP: {princessHP}");
            }

            if (princessHP <= 0){
                Console.WriteLine($"Your frail body collapses to the floor after injuring yoruself to the farthest degree. This is your last chapter, Princess {princessName}");
                Console.ReadLine();
                return;
            }

            else{
                Console.WriteLine("You jump down safely depsite all odds.. hm, lucky you!");
            }
        }

        else {
            Console.WriteLine("Whatever, don't take this seriously then. I'll choose for you. You take the rope!");
        }
    }


    private static void PreFight() {
        Console.WriteLine("you reluctantly walk into the dark forest surrounding the tower. On your way, you find various apples hanging from tree, fresh, unplucked and glistening with magic.");
        Console.WriteLine("Inside a rock, you also notice a pristine dagger dug deep inside a tree, it also looks practically untouched.");
        Console.WriteLine("1. Take the dagger");
        Console.WriteLine("2. Take the apples");
        Console.WriteLine("3. Take both");
        Console.WriteLine("4. Leave both");
        Console.WriteLine("What will you do?: ");
        string choice = Console.ReadLine();

        switch (choice){
            case "1":
                hasdagger = true;
                Console.WriteLine($"{princessName} picks up the pristine dagger, leaving the magic apples alone.");
                break;

            case "2":
                hasapples = true;
                Console.WriteLine($"{princessName} picks up the magic apples, leaving the pristine dagger alone.");
                break;
            
            case "3":
                hasdagger = true;
                hasapples = true;
                Console.WriteLine($"{princessName} picks up both items, stuffing her pockets full.");
                break;
            case "4":
                Console.WriteLine($"{princessName} leaves both items, too focused on her way out to take up a good offer, apparently.");
                break;
            default:
                Console.WriteLine("I'm starting to get tired of this.. The princess stood still pondering for so long she no longer had the time to pick anything.");
                break;   
        }
    
    }

    private static void Dragonfight(){

        while (princessHP > 0 && dragonHP > 0)
        {
            
            Console.WriteLine("1. Throw your crown");
            Console.WriteLine("2. Kick");
            Console.WriteLine("3. Punch");
            Console.WriteLine("4. Heal");
            Console.WriteLine("5. Stab");
            Console.WriteLine($"What will you do?: ");
            string input = Console.ReadLine().ToLower();

            int princessdmg = 0;
            int dragondmg = 0;

            switch (input)
            {
                case "1":

                    break;
                    // i want this to stun the dragon but im not sure how yet
                case "2":
                    Random kickdmg = new Random();
                    princessdmg = kickdmg.Next(5, 20);
                    dragonHP -= princessdmg;
                    Console.WriteLine("You ran at full speed towards the beast, kicking it as hard as you could in any sensitive area you could reach.");
                    Console.WriteLine($"Princess {princessName} did {princessdmg} damage!");
                    break;
                case "3":
                    Random punchdmg = new Random();
                    princessdmg = punchdmg.Next(10, 30);
                    dragonHP -= princessdmg;
                    Console.WriteLine("You ran at the beast, raising your fist in the air and preparing for impact before unleashing an unmerciful punch.");
                    Console.WriteLine($"Princess {princessName} did {princessdmg} damage!");
                    break;
                case "4":
                    Random heal = new Random();
                    int princessheal = heal.Next(5, 10);
                    princessHP += princessheal;
                    availableapples--;
                    Console.WriteLine("You grab one of the fresh red apples you picked earlier, chewing through it lack a mad man to restore your energy.");
                    Console.WriteLine($"Princess {princessName} ate an apple and healed herself!");
                    break;
                    // the player is meant to heal, havent replaced the placeholders yet


            }
        }
    }
}