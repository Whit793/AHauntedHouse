using System;
using System.Collections;
using System.Data;
using System.Dynamic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace TheHauntedHouse
{
    class Program
    {
        static void Main(string[] args) => GameTitle();

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
                first();

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
                Console.WriteLine();
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
                            Console.WriteLine();
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
                            Console.WriteLine("You survived a miserable, yet uneventful, evening.  Good for you!");
                            Console.WriteLine();
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
                            Console.WriteLine();
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
                Console.WriteLine("A mass of black mist and smoke descends down the staircase towards you!");
                Console.WriteLine("What do you do?!");
                Console.WriteLine();
                Console.WriteLine("A: Open the door and run for your life.");
                Console.WriteLine("B: Charge up the stairs, towards the monster/ghost/smoke.  You are a hero afterall.");
                Console.WriteLine("C: Run towards the dining room.");
                Console.WriteLine("D: Freeze in panic, and probably pee your pants.  You scare easily.");
                Console.WriteLine();
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
                            Console.WriteLine("descends.  Then you notice it.  An old keypad.  But what is the code???");
                            Console.WriteLine();
                            Console.WriteLine("carved into the door is written:     675-333+200-185x2");
                            Console.WriteLine("                                     _________________");
                            Console.WriteLine("                                         366-91x4");


                            Console.WriteLine("The scratch marks nex to the problem show the last guy wasn't very good at math.");
                            Console.WriteLine("Are you??");
                            Console.WriteLine();
                            Console.WriteLine("What do you type into the keypad?");
                            int x = new int();
                            x = int.Parse(Console.ReadLine());

                            if (x == 85)
                            {
                                Console.WriteLine("Congrats!  You remember your math.  You rush out the door, down the street, and past your car.");
                                Console.WriteLine("Eventually, you make it to a diner.  You try to forget what just happened as you drink a ");
                                Console.WriteLine("nice hot cup of coffee.  You wait until morning for the snowstorm to clear, and call");
                                Console.WriteLine("a mechanic.");
                                Console.WriteLine();
                                Console.WriteLine("press enter to play again!");
                                Console.ReadLine();
                                Console.Clear();
                                GameTitle();
                                
                        
                            }
                            else
                            {
                                Console.WriteLine("Man, you are just as bad as math as the last person stuck here.");
                                Console.WriteLine("The creature reaches out to you, and finally speaks:");
                                Console.WriteLine("You should have remembered your Order of Operations!!!");
                                Console.WriteLine("Now you will suffer!!!");
                                Console.WriteLine("You black out in fear....");
                                Console.WriteLine("________________________________________________________");
                                Console.WriteLine("You awake sitting in a desk... the same desk from elementary school.:");
                                Console.WriteLine("You barely fit in this thing :/");
                                Console.WriteLine("The smoke spirit speaks to you: 'NOW YOU MUST SIT THROUGH MY 8 HOUR MATH CLASS!!!");
                                Console.WriteLine();
                                Console.WriteLine("Pure horror rushes over you.  After surviving the longest math class of your life, the creature lets you leave.");
                                Console.WriteLine("You return to your car, embarassed by your memory of basic arithematic, but relatively unscathed.");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to play again");
                                Console.ReadLine();
                                Console.Clear();
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
                        Console.WriteLine();
                        Console.WriteLine("Press enter to play again");
                    Console.ReadLine();
                    Console.Clear();
                        GameTitle();
                        break;

                    case "c":
                    case "C":
                        {
                            Console.WriteLine("You make a sprint for the dining room, hoping to avoid the monster.");
                            Console.WriteLine("press enter to see your fate...");
                            Console.Clear();
                            Third();
                            break;

                        }

                    case "d":
                    case "D": 
                        {
                            Console.WriteLine("Let's be honest, this would be the same reaction for a lot of people.");
                            Console.WriteLine("Paralyzed by fear, you fail to make any decision, and simply stand by the door.");
                            Console.WriteLine("You are shaking with fear");
                            Console.WriteLine("You might have even peed your pants a little :/");
                            Console.WriteLine("____________________________________________________");
                            Console.WriteLine("Then the monster speaks to you:");
                            Console.WriteLine("'Really dude?' It says in a very unmonster like voice.");
                            Console.WriteLine("This is embarrassing for both of us");
                            Console.WriteLine("Honeslty, here is the passcode to the keypad... just please leave.");
                            Console.WriteLine("You awkwardly say thank you, open the door, and make your way back to the car.");
                            Console.WriteLine("You wait until morning, embarrassed, until a cop drives by, sees you are in trouble");
                            Console.WriteLine("and calls a mechanic.  Best to forget this ever happen.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to play the game again.");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();
                            break;
                        }


                }

            }
            public static void Third() 
            {
                string choice;

                Console.WriteLine("You sprint into the dining room.  With seconds to act, what do you do?");
                Console.WriteLine();
                Console.WriteLine("A: hide underneath the table, NO way an evil smoke monster won't find you there, right?");
                Console.WriteLine("B: jump through the window, like the action star you are");
                Console.WriteLine("C: head for the door that looks like it leads to a basement.  Nothing bad ever happens down there in these situations.");
                Console.WriteLine("Choice: ");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                
                switch (choice)
                {
                    case "a":
                    case "A":
                    {
                        Console.WriteLine("You dive underneath the dining room table.  The floor is disgusting.  You hold your breath, waiting for the monster");
                        Console.WriteLine("to find you....");
                        Console.WriteLine("You hear it groaning, feel the chill in the air as the creature works it's way around the table.");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine("All of a sudden you hear, 'Ah man, I hate it when that happens.");
                        Console.WriteLine("----------------------------------------------------------------------");
                        Console.WriteLine("After a few hours, you realize the monster is gone. You wait until morning, then climb through a window.");
                        Console.WriteLine("'That didn't go how I thought it would,' you think to yourself.");
                        Console.WriteLine("it totally worked.");
                        Console.WriteLine("You make your way back to your car, and flag down a passing driver.");
                        Console.WriteLine();    
                        Console.WriteLine("Press enter to play again");
                        Console.ReadLine();
                        Console.Clear();
                        GameTitle();
                        break;

                    }

                    case "b":
                    case "B":
                    {
                        Console.WriteLine("Like a 90s action hero, you begin a running start and head for the window.");
                        Console.WriteLine("You slam into the glass, shattering part of it, but failing to get through.");
                        Console.WriteLine("What did you expect to happen??");
                        Console.WriteLine("You cut your right arm, and the top of your head.");
                        Console.WriteLine("This is it, you are going to either bleed out on the old linoleum, or the monster will kill you.");
                        Console.WriteLine("The black blob of smoke gusts towards you.  You close your eyes, unable to watch your fate");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                        Console.WriteLine("'Oh man, I am sorry!!' you hear the creature say in a startled manner.");
                        Console.WriteLine("'What were you thinking?  I was just trying to mess with you!'");
                        Console.WriteLine("'This isn't how it was supposed to happen, not at all!  Here, let me help you'");
                        Console.WriteLine("The black smoke transforms into an old man, with coke bottle glasses and a pocket protector,");
                        Console.WriteLine("The ghost, or whatever it is, grabs a first aid kit from under the kitchen sink.");
                        Console.WriteLine("He applies stitches, peroxide, and bandaids.");
                        Console.WriteLine("After promising not to tell anyone about the 'spooky ghost' in the 'spooky house,' he lets you leave.");
                        Console.WriteLine("You return to your car, banged up but overall healthy.");
                        Console.WriteLine("You flag down a passing car, and they drive you to a mechanic.");
                        Console.WriteLine(); 
                        Console.WriteLine("press enter to play again!");
                        Console.ReadLine();
                        Console.Clear();
                        GameTitle();
                        break;

                    }

                    case "c":
                    case "C":
                    {
                        Console.WriteLine("You dash towards the door, and push on it with all your might.");
                        Console.WriteLine("This is it, you are trapped!!");
                        Console.WriteLine();
                        Console.WriteLine("No, wait, it's a pull door.  You still might be ok.");
                        Console.WriteLine("In front of you is a set of stairs going down, bathed in darkness");
                        Console.WriteLine("you make your way down, the old wood creaking under your feet.");
                        Console.WriteLine("You find a switch, luckily, the house has power.");
                        Console.WriteLine("In front of you, it appears to be an old classroom.");
                        Console.WriteLine("The tiny desks, stacks of books (math), and an old chalkboard");
                        Console.WriteLine("Just before you can begin to wonder why the heck this is down here, The monster appears!");
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        Console.WriteLine("'Hahahaha, you fool, you have entered my torture chamber!!!!'");
                        Console.WriteLine("'Observe my instruments of pain: geometry, trigonometry, algebra'");
                        Console.WriteLine("'Unless you can solve this problem, you will be tortured here for all eternity'");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("'Given the legs of a right triangle, find the hypotenuse");
                        Console.WriteLine();
                        Console.WriteLine("one leg is 2, the other is 3.  What is the answer??");
                        var y = new int();
                        y = int.Parse(Console.ReadLine());

                        if (y == 13)
                        {
                            Console.WriteLine("Congrats!  You remembered your pythagorean theorem!");
                            Console.WriteLine("'a^2 + b^2 = c^2,' you proudly boast.");
                            Console.WriteLine("The monster groans, simultaneously mad that you solved it, but also glad");
                            Console.WriteLine("that you remembered something from school");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("The monster leads you back to the front door, and lets you leave.");
                            Console.WriteLine("you make your way back to your car, and keep heading until you reach a diner.");
                            Console.WriteLine("You grab a cup of coffee, and wait till morning to call a mechanic.");
                            Console.WriteLine(); 
                            Console.WriteLine("Press enter to play again!");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();
                            break;
                       
                        }
                        else
                        {
                            Console.WriteLine("You totally blank, you can't remember how to find that :/");
                            Console.WriteLine("The monster laughs, 'hahaha, pythagoraon slays another!'");
                            Console.WriteLine("'Now you will spend eternity in my math class of doom!!!'");
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("A few hours later, a long time in math class but certainly not an actual eternity,");
                            Console.WriteLine("the monster lets you leave.  He even gave you homework to study.");
                            Console.WriteLine("you make it back to your car, embarrassed over forgetting basic math, but otherwise unhurt.");
                            Console.WriteLine("You wait in your car until morning, and flag down a passing truck.");
                            Console.WriteLine();
                            Console.WriteLine("press enter to play again");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();
                            break;
                        }




                    }






                }







        }


    }

}