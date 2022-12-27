using System;

namespace DnD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to D&D! What is your name, adventurer?");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Are you ready to rest or fight?");
            string? action = Console.ReadLine();

            if (action != null && action.ToLower() == "fight")
            {
                Console.WriteLine("You have encountered a dragon! Prepare to battle!");

                // simulate the battle
                Random rng = new Random();
                int playerHealth = 100;
                int dragonHealth = 100;

                while (playerHealth > 0 && dragonHealth > 0)
                {
                    // player attacks
                    Console.WriteLine("Press Enter to attack the dragon.");
                    Console.ReadLine();
                    int playerDamage = rng.Next(30, 36);
                    dragonHealth -= playerDamage;
                    Console.WriteLine($"You attack the dragon and deal {playerDamage} damage! The dragon's health is now {dragonHealth}.");

                    // dragon attacks
                    if (dragonHealth > 0)
                    {
                        int dragonDamage = rng.Next(30, 36);
                        playerHealth -= dragonDamage;
                        Console.WriteLine($"The dragon attacks you and deals {dragonDamage} damage! Your health is now {playerHealth}.");
                    }
                }

                if (playerHealth > 0)
                {
                    string thanks = @"
  _______ _                 _           __             _____  _             _                  __  
 |__   __| |               | |         / _|           |  __ \| |           (_)              _  \ \ 
    | |  | |__   __ _ _ __ | | _____  | |_ ___  _ __  | |__) | | __ _ _   _ _ _ __   __ _  (_)  | |
    | |  | '_ \ / _` | '_ \| |/ / __| |  _/ _ \| '__| |  ___/| |/ _` | | | | | '_ \ / _` |      | |
    | |  | | | | (_| | | | |   <\__ \ | || (_) | |    | |    | | (_| | |_| | | | | | (_| |  _   | |
    |_|  |_| |_|\__,_|_| |_|_|\_\___/ |_| \___/|_|    |_|    |_|\__,_|\__, |_|_| |_|\__, | (_)  | |
                                                                       __/ |         __/ |     /_/ 
                                                                      |___/         |___/          
";
                    Console.WriteLine("Congratulations, you have defeated the dragon!");
                    Console.Write(thanks);
                }
                else
                {
                    string gameOver = @"
                   *              )               (     
 (        (      (  `          ( /(               )\ )  
 )\ )     )\     )\))(   (     )\()) (   (   (   (()/(  
(()/(  ((((_)(  ((_)()\  )\   ((_)\  )\  )\  )\   /(_)) 
 /(_))_ )\ _ )\ (_()((_)((_)    ((_)((_)((_)((_) (_))   
(_)) __|(_)_\(_)|  \/  || __|  / _ \\ \ / / | __|| _ \  
  | (_ | / _ \  | |\/| || _|  | (_) |\ V /  | _| |   /  
   \___|/_/ \_\ |_|  |_||___|  \___/  \_/   |___||_|_\  
                                                        
";
                    Console.WriteLine("Unfortunately, you have been defeated by the dragon.");
                    Console.Write(gameOver);
                }
            }
        }
    }
}
