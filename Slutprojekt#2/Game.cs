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


    }

    public static void EscapeTower(){
        Console.WriteLine($"Ah, yes. Pardon me, Princess {princessName}. Now, where was I? Right.");
        Console.WriteLine("All you have to your name is the long floor length dress you're currently wearing, and the aforementioned crown atop your head.");
        Console.WriteLine("Despite your unfamiliar situation you've been put in, you decide to take the initiative to break yourself out.");
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
            Climbdown();
        }

    }

    private static void Breakdoor(){

    }

    private static void Window(){

    }

    private static void Climbdown(){

    }



}