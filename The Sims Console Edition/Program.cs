using System;

namespace TheSimsConsoleEdition
{
    class Program
    {
        static Game curGame;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Sims Console Edition\n\n" +
                    "1 - New World\n" +
                    "2 - Load World\n" +
                    "3 - Options\n" +
                    "q - Quit\n\n");
            
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            curGame = new Game();
                            inGame();
                            break;
                        }
                    case "2":
                        {
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    case "q":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input.");
                            break;
                        }
                }
            } while (true);
        }

        public static void inGame()
        {
            do
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "resume":
                        {
                            curGame.resumeTimer();
                            break;
                        }
                    case "pause":
                        {
                            curGame.pauseTimer();
                            break;
                        }
                    case "add":
                        {
                            if (curGame.isPaused())
                            {
                                addingItems();
                            }
                            else
                                Console.WriteLine("Game must be paused to add more elements.");
                            break;
                        }
                    case "inspectroom":
                    case "inspect room":
                    case "inspect":
                        {
                            Console.WriteLine(curGame.getSurroundings());
                            break;
                        }
                    case "stats":
                        {
                            Console.WriteLine("You have £" + curGame.getPlayer().getMoney() + ".\nThere are " + curGame.getBuilding().getInhabitanceCount() + " people in this bulding.");
                            break;
                        }
                    case "moveto":
                    case "move to":
                        {

                            break;
                        }
                    case "save":
                        {
                            break;
                        }
                    case "return":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input.");
                            break;
                        }
                }
            } while (true);
        }

        static private void addingItems()
        {
            do
            {
                Console.WriteLine("Do you want to:\n1 - Add a new room connected to this one.\n2 - Add an item to this room.\n3 - Add a person to the house.\nreturn - return to previous menu.");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Input name of new room.");
                            curGame.newRoom(Console.ReadLine());
                            Console.WriteLine("New room created.");
                            return;
                        }
                    case "2":
                        {
                            Console.WriteLine("What item would you like to add?\n");
                            Utilities.populateObjList();
                            foreach (string s in Utilities.objList)
                                Console.WriteLine(s);
                            return;
                        }
                    case "3":
                        {
                            Console.WriteLine("Insert name of new character.");
                            Console.WriteLine("What is the gender?\n1 - Male\n2 - Female");

                            return;
                        }
                    case "return":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input.");
                            break;
                        }
                }
            } while (true);
        }
    }
}