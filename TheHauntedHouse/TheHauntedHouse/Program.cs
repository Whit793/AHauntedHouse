using System;
using System.Data;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace TheHauntedHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTitle();
            first();
        }

            public static void GameTitle()
            {

                Console.WriteLine("______A Haunted House______");
                Console.WriteLine("Created by: Bryan Whitman");
                Console.WriteLine("Welcome to my Game!");

                Console.WriteLine("Note: as you move through the game, you will be presented with a series of options.");
                Console.WriteLine("When prompted, simply type the letter you want, and hit enter/return");
                Console.WriteLine("Don't get to scared!");
                Console.WriteLine("Press Enter to Continue.");
                Console.ReadLine();
                Console.Clear();

            }

            public static void first()
            {
                Console.WriteLine("First off, what is your name?");
                string playerName = Console.ReadLine();
                Console.WriteLine($"Well, {playerName}, you are in a bit of trouble.  Especially because you let your cell phone die without having a car charger.");

                string choice;


                Console.WriteLine("On a dark, dreary night, you find yourself driving on a dark, deserted backroad.");
                Console.WriteLine("It is snowing out.  So hard, you can barely see the road in front of you.");
                Console.WriteLine("your headlights do what they can, but anything more than a few yards in front of you is lost in the darkness and snow.");
                Console.WriteLine("It is so dark, you miss the bits of metal lying on the road.  You swerve to avoid, but it is to late.");
                Console.WriteLine("You barely manage to keep control of the vehicle, and after a few moments of cursing your luck, you get out to inspect the damage.");
                Console.WriteLine("Your front right and back right tire are torn to bits.  You could maybe change one of them for the spare, but not both.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("A: Stay in your car, and hope someone comes along.");
                Console.WriteLine("B: Turn to your right, and begin walking down the road.");
                Console.WriteLine("C: Turn to your left, and head towards the distant light of what you believe to be is a house.");
                Console.WriteLine("choice:");
                choice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (choice)
                {
                    case "A":
                    case "a":
                        {
                            Console.WriteLine($"You decide to stay the night in your car. {playerName}, you think to yourself, nothing more dangerous");
                            Console.WriteLine("than walking on a road when no one can see");
                            Console.WriteLine("you bundle up in the back seat, and sleep rather peacefully.");
                            Console.WriteLine("In the morning, the snow has stopped.  A passing police officer sees you, and kindly takes you to a mechanic.");
                            Console.WriteLine("Everything is going to be just fine!");
                            Console.WriteLine("Press enter to go back to the beginning and play again.");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();
                            break;

                        }

                    case "B":
                    case "b":
                    {
                        Console.WriteLine("You pull your coat in tight, and head to your right.");
                        Console.WriteLine("After an hour of walking, just before you think your toes might fall off from frost bite, you find a 24/7 diner.");
                        Console.WriteLine("you grab some food, a nice hot cup of coffee, and wait out the storm.");
                        Console.WriteLine("In the morning, you use the diner phone to call a mechanic.");
                        Console.WriteLine("You surviced a miserable, yet uneventfull, evening {player name}  good for you!");
                        Console.WriteLine("Press enter to go back to the beginning and play again.");
                        Console.ReadLine();
                        Console.Clear();
                        GameTitle();
                        break;

                    }
                    case "C":
                    case "c":
                    {
                        Console.WriteLine("You grab your coat, lock your car, and head towards the light.");
                        Console.WriteLine("Light means electricity, which should mean warmth!  You think to yourself.");
                        Console.WriteLine("After a few moments, you come to the front of the house.");
                        Console.WriteLine("It towers over you at 3 stories tall, and the dark, dirty exterior sends a chill up your spine.");
                        Console.WriteLine("As you pass through the wrought iron fence gate, you notice a light in the 3rd story window.");
                        Console.WriteLine("While the rest of the house is bathed in darkness, at least it looks like someone is home");
                        Console.WriteLine("You muster your courage, and give 3 quick knocks on the door, adding in a pleasent 'hello' for good measure.");
                        Console.WriteLine($"To your surprise, the door creaks open, just barely.  You swear you hear a voice say: come on in {playerName} , but that would be crazy.");
                        Console.WriteLine("Press Enter to walk through the door");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                        

                    }

                     
                }

            }
            
            public static void second()
            {
            Console.WriteLine("Well, you are certainly committed.");

            }



        }

        

    }
