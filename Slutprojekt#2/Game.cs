using System;
using System.Runtime.CompilerServices;

namespace PrincessGame{
    public static class GameMethods{

        private static string princessName;
        private static int princessHP = 100;
        private static int dragonHP = 100;
        private static bool hasdagger = false;
        private static bool hasapples = false;

        //array för attacks
        private static (string, int)[] dragonatks = new (string, int)[]
        {
            ("Slash", 20),
            ("Breathe fire", 25),
            ("Flap Wings", 10),
            ("Stomp", 15),
        };

        //genererar en random attack
        private static (string, int) randragonatks()
        {
            Random atk = new Random();
            var attack = dragonatks[atk.Next(dragonatks.Length)];
            return attack;

        }

        public static void Intro(){
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
            princessHP -= 15;
            Console.WriteLine("You first notice the big metal door blocking your way down into the staircase of the tower.  Its large and imposing, making you feel like an ant compared to its great height and width.");
            Console.WriteLine("You run towards it at full speed, hoping it'll fall over from your mighty shove. Instead, you injure yourself.");
            Console.WriteLine($"{princessName} takes 15 damage! HP: {princessHP}");

            if (princessHP <= 0){
                Console.WriteLine($"Your frail body collapses to the floor after injuring yourself to the farthest degree. This is your last chapter, Princess {princessName}");
                Console.ReadLine();
                Environment.Exit(0);
            }

            EscapeTower();    
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
                    Console.WriteLine("Instead of taking the safe way down for whatever reason, you leap down and land on your feet, injuring your ankles.");
                    Console.WriteLine($"{princessName} takes 30 damage! HP: {princessHP}");
                

                    if (princessHP <= 0){
                        Console.WriteLine($"Your frail body collapses to the floor after injuring yoruself to the farthest degree. This is your last chapter, Princess {princessName}");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }  
                } 
                     
                else if (jumpchance > 60 && jumpchance <= 100){
                    Console.WriteLine("You jump down safely depsite all odds.. hm, lucky you!");
                }
            }
            
            else {
                Console.WriteLine("Whatever, don't take this seriously then. I'll choose for you. You take the rope!");
            }
        }

        public static void PreFight() {
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

        public static void Dragonfight(){

            Console.WriteLine("While walking in the forest, you notice a large shadow covering the moon sickly blue glow, followed by a roar.");
            Console.WriteLine("You look up to see a terrifying beast of a dragon, descending down to where you stood and blocking your path to what looked like civilization.");
            Console.WriteLine("The Dragon prepares itself to fight you, flapping its gorgeous wings with all its might. It seems to be waiting for you to strike first.");

            bool dragonStunned = false;

            while (princessHP > 0 && dragonHP > 0)
            {
                
                Console.WriteLine($"Your HP: {princessHP}, Dragon's HP: {dragonHP}");
                Console.WriteLine("1. Throw your crown");
                Console.WriteLine("2. Kick");
                Console.WriteLine("3. Punch");

                if (hasapples){
                    Console.WriteLine("4. Heal");
                }
                
                if (hasdagger){
                    Console.WriteLine("5. Stab");
                }
                
                Console.WriteLine($"What will you do?: ");
                string input = Console.ReadLine().ToLower();

                int princessdmg = 0;

                switch (input)
                {
                    case "1":
                        princessdmg = 0;
                        Console.WriteLine("You throw your crown at the dragon's eyes, making it roar in pain. It's stunned!");
                        dragonStunned = true;
                        break;
                        
                    case "2":
                        Random kickdmg = new Random();
                        princessdmg = kickdmg.Next(5, 15);
                        dragonHP -= princessdmg;
                        Console.WriteLine("You run at full speed towards the beast, kicking it as hard as you could in any sensitive area you could reach.");
                        Console.WriteLine($"Princess {princessName} did {princessdmg} damage!");
                        break;

                    case "3":
                        Random punchdmg = new Random();
                        princessdmg = punchdmg.Next(5, 15);
                        dragonHP -= princessdmg;
                        Console.WriteLine("You run at the beast, raising your fist in the air and preparing for impact before unleashing an unmerciful punch.");
                        Console.WriteLine($"Princess {princessName} did {princessdmg} damage!");
                        break;

                    case "4":
                        Random heal = new Random();
                        int princessheal = heal.Next(10, 20);
                        princessHP += princessheal;
                        Console.WriteLine("You grab one of the fresh red apples you picked earlier, chewing through it lack a mad man to restore your energy.");
                        Console.WriteLine($"Princess {princessName} ate an apple and healed herself!");
                        break;
                        
                    case "5":
                        Random stabdmg = new Random();
                        princessdmg = stabdmg.Next(10, 25);
                        Console.WriteLine("You run at the beast, raising your blade wherever you could reach, slicing and stabbing.");
                        Console.WriteLine($"Princess {princessName} did {princessdmg}!");
                        break;

                    default:
                        Console.WriteLine("Idiot. You missed your chance to attack..! Whatever, you deal with the aftermath.");
                        break;
                }

                dragonHP -= princessdmg;

                if (dragonStunned){
                    dragonHP -= princessdmg;
                    dragonStunned = false;
                }
                //små ändringar här för arrayen
                else{
                    var (atkname, atkdmg) = randragonatks();
                    princessHP -= atkdmg;
                    Console.WriteLine($"The dragon uses {atkname} and doesnt hold back. The hit lingers and aches as you prepare for your next attack.");
                    Console.WriteLine($"The dragon did {atkdmg}!");
                }

                if (princessHP <= 0){
                    Console.WriteLine($"Princess {princessName}.. has righteously fallen. This is your last chapter, I'm afraid.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                else if (dragonHP <= 0){
                    Pleas();
                }

                static void Pleas(){

                    Console.WriteLine("The dragon is critically injured, its roars quieting to pitiful whimpers. You can see in its eyes.. its pleading for mercy.");
                    Console.WriteLine("1. Spare the dragon");
                    Console.WriteLine("2. Kill the dragon");
                    Console.WriteLine("What will you do?: ");
                    string choice = Console.ReadLine();

                    if (choice == "1"){

                        if (princessHP <= 20){
                            Console.WriteLine("The dragon, noticing your weak state, goes for one finishing blow as you lower your guard.");
                            Console.WriteLine("It looks sorry for taking advantage of your kindness.. or, you hope it does.");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                        else {
                            Console.WriteLine("The dragons, eyes glimmer with gratitude, rising slowly to its feet but lowering its neck to your level.");
                            Console.WriteLine("It seems to want to help you on your journey, and you happily accept! The two of your ride into the sunrise.");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }

                    else if (choice == "2"){
                        Console.WriteLine("You mercilessly kill the dragon, walking off limping into the sunrise with your victory heavily on your shoulders.");
                        Console.WriteLine("You hope whatever lays beyond is far easier than what you've been through.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else{
                        Console.WriteLine("Oh ho ho, no. You're not avoiding this one!");

                        Pleas();
                    }

                }

                static void GameOver(){

                    Console.WriteLine("Game Over! Would you like to play again? (y/n)");
                    string choice = Console.ReadLine();

                    if  (choice == "y"){

                        Console.Clear();
                    }

                    else{

                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}