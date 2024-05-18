using System;

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
        
        Console.WriteLine("1. Knock over the giant metal door.");
        Console.WriteLine("2. Try to reach the window on the ceiling.");
        Console.WriteLine("3. Find a weakness in the wall cracks.");

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
        Console.WriteLine("You first notice the big metal door blocking your way down into the staircase of the tower.  Its large and imposing, making you feel like an ant compared to its great height and width.");
        Console.WriteLine("You run towards it at full speed, hoping it'll fall over from your mighty shove. Instead, you injure yourself.");
        Console.WriteLine($"{princessName} takes 15 damage! HP: {princessHP}");

        EscapeTower();

        if (princessHP <= 0){
            Console.WriteLine($"Your frail body collapses to the floor after injuring yoruself to the farthest degree. This is your last chapter, Princess {princessName}");
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

        Console.WriteLine("What will you do?: ");
        string choice = Console.ReadLine();

        if (choice == "1"){
            Console.WriteLine($"");
        }
    }

    private static void Dragonfight(){

        while (princessHP > 0 && dragonHP > 0)
        {
            Console.WriteLine($"What will you do, Princess {princessName}?");
            Console.WriteLine("1. Throw your crown");
            Console.WriteLine("2. Kick");
            Console.WriteLine("3. Punch");
            Console.WriteLine("4. Heal");
            Console.WriteLine("5. Stab");


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