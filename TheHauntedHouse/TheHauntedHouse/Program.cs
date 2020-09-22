using System;
using System.Collections;
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

            string choice;

            Console.WriteLine("Well, you are certainly committed to this creepy place.");
            Console.WriteLine("The foyer floor is covered in dust.  A wet, damp, moldy smell fills the air");
            Console.WriteLine("In front of you is a wooden staircase, to your left you can see a small dining room.");
            Console.WriteLine("'Hello!?!' you nervously yell out, hoping for a response.");
            Console.WriteLine("At first, you hear nothing.  Just the muffled pounding of the snow upon the roof of the house, and the sound of");
            Console.WriteLine("your heart pumping in your chest.");
            Console.WriteLine("That's when you notice the writing, carved into the wall by the door:");
            Console.WriteLine("G E T");
            Console.WriteLine(" O U T!");
            Console.WriteLine("As you read the words aloud to yourself, you hear a loud scream from the top of the stairs!");
            Console.WriteLine("A mass of black mist and smoke decends down the staircase towards you!");
            Console.WriteLine("What do you do?!");
            Console.WriteLine("A: Open the door and run for your life.");
            Console.WriteLine("B: Charge up the stairs, towards the monster/ghost/smoke.  You are a hero afterall.");
            Console.WriteLine("C: Run towards the dining room");
            Console.WriteLine("D: Freeze im panic, and probably pee your pants.  You scare easily.");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "a":
                case "A":
                    {

                        Console.WriteLine("Quickest way out, is the way you came in.  You grab the doorknob and...");
                        Console.WriteLine("... it's locked.  You start to panic.  The black shape moves closer to you as it");
                        Console.WriteLine("descends.  Then you notice it.  An old keybad.  But what is the code???");
                        Console.WriteLine("carved into the door is written: 675-333+200-185x2");
                        Console.WriteLine("                                  _________________");
                        Console.WriteLine("                                      366-91x4");


                        Console.WriteLine("The scratch marks nexto the problem show the last guy wasn't very good at math.");
                        Console.WriteLine("Are you??");
                        Console.WriteLine("What do you tpe into the keypad?");
                        int x = new int();
                        x = int.Parse(Console.ReadLine());

                        if (x == 85)
                        {
                            Console.WriteLine("Congrats!  You remember your math.  You rush out the door, down the street, and past your car.");
                            Console.WriteLine("Eventually, you make it to a diner.  You try to forget what just happened as you drink a ");
                            Console.WriteLine("nice hot cup of coffee.  You wait until morning for the snowstorm to clear, and call");
                            Console.WriteLine("a mechanic.");
                            Console.WriteLine("press enter to play again!");
                        
                        }
                        else
                        {
                            Console.WriteLine("Man, you are just as bad as math as the last person stuck here.");
                            Console.WriteLine("THe creature reaches out to you, and finally speaks:");
                            Console.WriteLine("You should have remembered your Order of Operations!!!");
                            Console.WriteLine("Now you will suffer!!!");
                            Console.WriteLine("You black out in fear....");
                            Console.WriteLine("________________________________________________________");
                            Console.WriteLine("You awake in a desk... the same desk from elementary school.:");
                            Console.WriteLine("You barely fit in this thing :/");
                            Console.WriteLine("The smoke spirit speaks to you: 'NOW YOU MUST SIT THROUGH MY 8 HOUR MATH CLASS!!!");
                            Console.WriteLine("Press enter to play again");
                            GameTitle();
                        }

                        break;

                    }

                case "b":
                case "B":
                    Console.WriteLine("You charge at the creature, with all your might!");
                    Console.WriteLine("In a fury of rage, breathing in the black smoke, it becomes harder to breathe.");
                    Console.WriteLine("You lose vision, and pass out.");
                    Console.WriteLine("___________________________________");
                    Console.WriteLine("You wake up in a diner, with a warm cup of coffee in front of you.");
                    Console.WriteLine("It's morning, and the snowstorm is gone.  You call a mechanic to fix the car.");
                    Console.WriteLine("What happened?!");
                    Console.WriteLine(".....Honestly, the ghost didn't know what to do.  It had never been charged before.");
                    Console.WriteLine("after you blacked out, it felt bad, so it carried you to the diner.");
                    Console.WriteLine("It even paid for your coffee, impressed by your bravery.");
                    Console.WriteLine("Press enter to play again");
                    break;

                case "c":
                case "C":
                    {
                        Console.WriteLine("You make a sprint for the dining room, hoping to avaid the monster.");
                        Console.WriteLine("press enter to see your fate...");
                        Console.Clear();
                        Third();

                        break;

                    }

            }

        }
        public static void Third() 
        {
        }


    }

}