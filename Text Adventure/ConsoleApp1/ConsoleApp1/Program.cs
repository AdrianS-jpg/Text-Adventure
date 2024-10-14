using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Text_adventure
{

    internal class Program
    {
        //all of the code to run the intro and the start of the game.

        static void Main(string[] args)
        {
            centerPrint("Hey, kid. What's your name?");
            string playerName = Console.ReadLine();
            if (playerName.ToUpper() == "DEREK")
            {
                Thread.Sleep(1000);
                centerPrint("I'm so sorry.");
                Globals.colorblindmode = true;
            } //else if (playerName.ToUpper() == "horror")
            //{

            //}
            Thread.Sleep(1000);
            Console.Clear();
            wholeSpace();
            centerPrint("This game is meant to be played in full screen.");
            wholeSpace();
            Thread.Sleep(3000);
            while (Console.WindowWidth < 150) 
            {
                centerPrint("This game is meant to be played in full screen.");
                wholeSpace();
                Thread.Sleep(3000);
            }
            start();
            wholeSpace();
            Thread.Sleep(2000);
            centerPrint("Start?");
            wholeSpace();
            string beginningInput = Console.ReadLine();
            while (beginningInput.ToUpper() != "START")
            {
                centerPrint("Please start.");
                beginningInput = Console.ReadLine();
            }
            centerPrint("The year is 2013.");
            Thread.Sleep(1500);
            centerPrint("You are only a handful of years of age at this point in time.");
            Thread.Sleep(1500);
            centerPrint("The setting? The kingdom of the Wal.");
            Thread.Sleep(1500);
            centerPrint("As you are still yet a young babe, you are not aware of your incoming fate.");
            Thread.Sleep(1500);
            centerPrint("You reach for a packet of Hydrox, your favorite treat.");
            Thread.Sleep(1500);
            centerPrint("Alas, your underdeveloped body does not allow the kind of height needed to obtain the sandwich cookies.");
            Thread.Sleep(1500);
            centerPrint("You turn around to request assistance from the one that feeds you, the woman whomst has birthed you.");
            Thread.Sleep(2000);
            centerPrint("She's gone.");
            Thread.Sleep(1500);
            startLane();
            Thread.Sleep(500);
            centerPrint("[ # ] means you can interact with it, { P } is you, and { # } means you can't interact with it.");
            centerPrint("Interact with things by typing in the corresponding letter.");
            Thread.Sleep(1000);
            centerPrint("Make sure to keep your sanity level up, otherwise you'll have a breakdown in the middle of a public area!");
            Thread.Sleep(1000);
            centerPrint("That would be so embarrassing for all parties involved!");
            Thread.Sleep(1000);
            centerPrint("We must avoid this at all costs.");

            moving(Console.ReadLine());

            //end code for hydrox presenting

            if (Globals.items.Count > 0)
            {
                string bonus = "";
                if (Globals.items.Count == 1)
                {
                    bonus = bonus + Globals.items[0] + " flavor Hydrox!";
                }
                else
                {
                    for (int i = 0; i < Globals.items.Count; i++)
                    {

                        if ((i + 1) == Globals.items.Count)
                        {
                            bonus = bonus + "and " + Globals.items[i] + " flavor hydrox!";
                        }
                        else
                        {
                            bonus = bonus + Globals.items[i] + " flavor hydrox, ";
                        }
                    }
                }
                centerPrint("(You've ended up with " + bonus + ")");
            }
        }

        //global variables here V (enums ish)

        public static class Globals
        {
            public static bool robCheck = false, oldCheck = false, catCheck = false, marCheck = false, motherNotCheck = false, boyCheck = false, robinCheck = false, VGDCheck = false, vanCheck = false, teenCheck = false, karenCheck = false, batCheck = false, kratosCheck = false, jimCheck = false, fourthCheck = false;
            public static float x = 3;
            public static float y = 4;
            public static int sanity = 3;
            public static bool balling = false;
            public static List<string> items = new List<string>();
            public static bool colorblindmode = false;
            public static bool color = false;
        }

        //function that prints the test inserted in the center of the console

        static void centerPrint(string e)
        {
            if (Globals.colorblindmode == true)
            {
                if (Globals.color == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Globals.color = true;

                } else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Globals.color = false;

                }
            }
            string s = e;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine("|");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop - 1);
            Console.WriteLine(s);
            Console.SetCursorPosition(Console.WindowWidth - 1, Console.CursorTop - 1);
            Console.WriteLine("|");

        }

        //function for printing whole spaces in the console

        static void wholeSpace()
        {
            if (Globals.colorblindmode == true)
            {
                if (Globals.color == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Globals.color = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Globals.color = false;

                }
            }
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                if (i == Console.WindowWidth - 1)
                {
                    Console.SetCursorPosition(i, Console.CursorTop - 1);
                    Console.WriteLine("|");
                } else if (i == 0)
                {
                    Console.SetCursorPosition(i, Console.CursorTop);
                    Console.WriteLine("|");
                } else
                {
                    Console.SetCursorPosition(i, Console.CursorTop - 1);
                    Console.WriteLine(" ");
                }
            }
        }

        //sanity printer for every occasion

        static void sanitycounter()
        {
            wholeSpace();
            centerPrint("Sanity Level: " + Globals.sanity);
            wholeSpace();
            Globals.color = false;
        }

        //functions for graphics (you have no idea how long these took)

        static void start()
        {
            centerPrint("████████╗██╗░░██╗███████╗  ░██████╗███████╗░█████╗░██████╗░░█████╗░██╗░░██╗");
            centerPrint("╚══██╔══╝██║░░██║██╔════╝  ██╔════╝██╔════╝██╔══██╗██╔══██╗██╔══██╗██║░░██║");
            centerPrint("░░░██║░░░███████║█████╗░░  ╚█████╗░█████╗░░███████║██████╔╝██║░░╚═╝███████║");
            centerPrint("░░░██║░░░██╔══██║██╔══╝░░  ░╚═══██╗██╔══╝░░██╔══██║██╔══██╗██║░░██╗██╔══██║");
            centerPrint("░░░██║░░░██║░░██║███████╗  ██████╔╝███████╗██║░░██║██║░░██║╚█████╔╝██║░░██║");
            centerPrint("░░░╚═╝░░░╚═╝░░╚═╝╚══════╝  ╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝");
        }
        static void startLane()
        {
            wholeSpace();
            centerPrint("___________________________________                          ___________________________________");
            centerPrint("///////////////////////////////////|         [ U ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|      You are here      |///////////////////////////////////");
            centerPrint("///////////////////////////////////|           |            |///////////////////////////////////");
            centerPrint("///////////////////////////////////|           V            |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
            centerPrint("                                             { P }                                              ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            wholeSpace();
            centerPrint("-----------------------------------                          -----------------------------------");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ D ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
            sanitycounter();
        }
        static void middleLane()
        {
            wholeSpace();
            centerPrint("___________________________________                          ___________________________________");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ U ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
            centerPrint("                                             { P }                                              ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            wholeSpace();
            centerPrint("-----------------------------------                          -----------------------------------");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ D ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();

        }
        static void middleLaneInt()
        {
            wholeSpace();
            centerPrint("___________________________________                          ___________________________________");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ U ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////| [ I ]                  |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
            centerPrint("                                             { P }                                              ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            wholeSpace();
            centerPrint("-----------------------------------                          -----------------------------------");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ D ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
        }
        static void topLane()
        {
            wholeSpace();
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("------------------------------------------------------------------------------------------------");
            wholeSpace();
            centerPrint("                                                                                                ");
            centerPrint("            [ L ]                            { P }                            [ R ]             ");
            wholeSpace();
            centerPrint("-----------------------------------                          -----------------------------------");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ D ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
            wholeSpace();
            wholeSpace();
            wholeSpace();

        }
        static void topLeftLane()
        {
            wholeSpace();
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("///////////////|--------------------------------------------------------------------------------");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|    [ Rx ]                   { P }                            [ R ]             ");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                             [ D ]          |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                                                                ");
            wholeSpace();

        }
        static void topShopLane()
        {
            wholeSpace();
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("------------------------------------------------------------------------------------------------");
            wholeSpace();
            centerPrint("                                             { P }                                              ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            wholeSpace();
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            wholeSpace();
            wholeSpace();
            wholeSpace();
            wholeSpace();
        }
        static void leftBottom()
        {
            wholeSpace();
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                             [ U ]          |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                             { P }                                              ");
            centerPrint("///////////////|                                                              [ R ]             ");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|--------------------------------------------------------------------------------");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }
        static void leftLane()
        {
            wholeSpace();
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                             [ U ]          |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                             { P }                                              ");
            centerPrint("///////////////|                                                              [ R ]             ");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                             [ D ]          |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                             -----------------------------------");
            wholeSpace();
        }
        static void leftLaneInt()
        {
            wholeSpace();
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                             [ U ]          |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                             { P }                                              ");
            centerPrint("///////////////| [ I ]                                                        [ R ]             ");
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                             -----------------------------------");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                             [ D ]          |///////////////////////////////////");
            centerPrint("///////////////|                                            |///////////////////////////////////");
            centerPrint("///////////////|                                             -----------------------------------");
            wholeSpace();
        }
        static void bottomLane()
        {
            wholeSpace();
            centerPrint("___________________________________                          ___________________________________");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|         [ U ]          |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("///////////////////////////////////|                        |///////////////////////////////////");
            centerPrint("-----------------------------------                          -----------------------------------");
            wholeSpace();
            centerPrint("                                             { P }                                              ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            wholeSpace();
            centerPrint("------------------------------------------------------------------------------------------------");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }
        static void bottomShopLane()
        {
            wholeSpace();
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                                             { P }                                              ");
            wholeSpace();
            centerPrint("            [ L ]                                                             [ R ]             ");
            centerPrint("                                                                                                ");
            centerPrint("------------------------------------------------------------------------------------------------");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }
        static void bottomShopLaneInt()
        {
            wholeSpace();
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                                             { P }                                              ");
            wholeSpace();
            centerPrint("            [ L ]                                                             [ R ]             ");
            centerPrint("                                             [ I ]                                              ");
            centerPrint("------------------------------------------------------------------------------------------------");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }
        static void shopLanesInt()
        {

            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                                             { P }                                              ");
            centerPrint("                                                                                                ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            centerPrint("                                             [ I ]                                              ");
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            wholeSpace();
        }
        static void shopLanes()
        {
            wholeSpace();
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                                             { P }                                              ");
            centerPrint("                                                                                                ");
            centerPrint("            [ L ]                                                             [ R ]             ");
            wholeSpace();
            centerPrint("                  ------------------------------------------------------------                  ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                 |////////////////////////////////////////////////////////////|                 ");
            centerPrint("                  ------------------------------------------------------------                  ");
            wholeSpace();
        }
        static void cashierStandEvil()
        {
            wholeSpace();
            wholeSpace();
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^|                          ");
            centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
            centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
            centerPrint("                           ------------------------------------------                           ");
            centerPrint("                                                                                                ");
            centerPrint("        [ L ]                                                                                   ");
            centerPrint("                             { P }                                                              ");
            centerPrint("                                             [ I ]                                              ");
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |*********************************{ C }****|                          ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                           ------------------------------------------                           ");
            wholeSpace();
            wholeSpace();
        }
        static void cashierStand()
        {
            wholeSpace();
            wholeSpace();
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^|                          ");
            centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
            centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
            centerPrint("                           ------------------------------------------                           ");
            centerPrint("                                                                                                ");
            centerPrint("        [ L ]                                                                                   ");
            centerPrint("                             { P }                                                              ");
            centerPrint("                                                                                                ");
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |*********************************{ C }****|                          ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                           ------------------------------------------                           ");
            wholeSpace();
            wholeSpace();
        }
        static void motherFound()
        {
            wholeSpace();
            wholeSpace();
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^|                          ");
            centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
            centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
            centerPrint("                           ------------------------------------------                           ");
            centerPrint("                                                                                                ");
            centerPrint("            [ L ]                                                                               ");
            centerPrint("                             { P }                                                              ");
            centerPrint("                                                [ I ]                                           ");
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |*********************************{ C }****|                          ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("___________________________------------------------------------------___________________________");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }
        static void bottomExit()
        {
            wholeSpace();
            centerPrint("___________________________________                                                             ");
            centerPrint("///////////////////////////////////|                                                            ");
            centerPrint("///////////////////////////////////|         [ U ]                                              ");
            centerPrint("///////////////////////////////////|                                                            ");
            centerPrint("///////////////////////////////////|                                                            ");
            centerPrint("-----------------------------------                                                  [ R ]      ");
            centerPrint("                                                                                                ");
            centerPrint("                                                                                    1           ");
            centerPrint("           [ L ]                                                             ___________________");
            centerPrint("                                             { P }                          |*******************");
            centerPrint("                                                                            |*******************");
            centerPrint("                                                                            |*******************");
            centerPrint("------------------------------------------------------------------------------------------------");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }
        static void exitLane()
        {
            wholeSpace();
            centerPrint("___________________________________                                                             ");
            centerPrint("///////////////////////////////////|                                                            ");
            centerPrint("///////////////////////////////////|         [ U ]                                  " + Globals.y + "           ");
            centerPrint("///////////////////////////////////|                                         ___________________");
            centerPrint("///////////////////////////////////|                                        |V^V^V^V^V^V^V^V^V^V");
            centerPrint("-----------------------------------                                         |()()()()()()()()()(");
            centerPrint("                                                                            ||||||||||||||||||||");
            centerPrint("                                             { P }                           -------------------");
            centerPrint("            [ L ]                                                                               ");
            centerPrint("                                                                                     [ R ]      ");
            centerPrint("-----------------------------------                                                             ");
            centerPrint("///////////////////////////////////|                                                            ");
            centerPrint("///////////////////////////////////|                                         -------------------");
            centerPrint("///////////////////////////////////|         [ D ]                          |*******************");
            centerPrint("///////////////////////////////////|                                        |*******************");
            centerPrint("-----------------------------------                                         |*******************");
            wholeSpace();

        }
        static void exit()
        {
            wholeSpace();
            centerPrint("//////////////////////////////////// ______ //|           |/////////////////////////////////////");
            centerPrint("////////////////////////////////////| EXIT |//|   [ U ]   |/////////////////////////////////////");
            centerPrint("//////////////////////////////////// ------ //|           |/////////////////////////////////////");
            centerPrint("///////////////////////////////////|----------             -------------------------------------");
            centerPrint("///////////////////////////////////|                                    6   |V^V^V^V^V^V^V^V^V^V");
            centerPrint("-----------------------------------                                         |()()()()()()()()()(");
            centerPrint("                                                                            ||||||||||||||||||||");
            centerPrint("                                             { P }                           -------------------");
            centerPrint("            [ L ]                                                                               ");
            centerPrint("                                                                                   [ R ]        ");
            centerPrint("-----------------------------------                                                             ");
            centerPrint("///////////////////////////////////|                                                            ");
            centerPrint("///////////////////////////////////|                                         -------------------");
            centerPrint("///////////////////////////////////|         [ D ]                          |*******************");
            centerPrint("///////////////////////////////////|                                        |*******************");
            centerPrint("-----------------------------------                                         |*******************");
            wholeSpace();

        }
        static void topCashie()
        {
            wholeSpace();
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("------------------------------------------------------------------------------------------------");
            centerPrint("                          |V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^|                          ");
            centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
            centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
            centerPrint("                           ------------------------------------------                           ");
            centerPrint("                                                                                                ");
            centerPrint("         [ L ]                                                                                  ");
            centerPrint("                             { P }                                                              ");
            centerPrint("                                                                                                ");
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |*********************************{ C ]****|                          ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                           ------------------------------------------                           ");
            wholeSpace();

        }
        static void topCashieInt()
        {
            wholeSpace();
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("------------------------------------------------------------------------------------------------");
            centerPrint("                          |V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^|                          ");
            centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
            centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
            centerPrint("                           ------------------------------------------                           ");
            centerPrint("                                                                                                ");
            centerPrint("         [ L ]                                                                                  ");
            centerPrint("                             { P }                                                              ");
            centerPrint("                                              [ I ]                                             ");
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |*********************************{ C }****|                          ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                           ------------------------------------------                           ");
            wholeSpace();

        }
        static void exiter()
        {
            wholeSpace();
            centerPrint("//////////////////////////////////////////////_____________/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|   [ U ]   |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|   { P }   |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            wholeSpace();
        }
        static void exitDemon()
        {
            wholeSpace();
            centerPrint("//////////////////////////////////////////////_____________/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|   [ U ]   |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |*********|///////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |**[ R ]**|///////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |*********|///////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|   { P }   |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            centerPrint("//////////////////////////////////////////////|           |/////////////////////////////////////");
            wholeSpace();
        }
        static void secret()
        {
            wholeSpace();
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            centerPrint("/////|*********|                                                   |////////////////////////////");
            centerPrint("/////|*********|                                                   |////////////////////////////");
            centerPrint("/////|*********|                                                   |////////////////////////////");
            centerPrint("///////////////|        { P }                                      |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("///////////////|                                  [ I ]            |////////////////////////////");
            centerPrint("///////////////|                                                   |////////////////////////////");
            centerPrint("////////////////////////////////////////////////////////////////////////////////////////////////");
            wholeSpace();
        }

        //code for printing which stuff at the right time

        static void checkPlace(string special)
        {
            Console.Clear();

            if (special == "nurse")
            {
                nurse();
                Thread.Sleep(1500);
                topLeftLane();
            }
            else if (special == "stranger")
            {
                robber();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "hydroxcrime")
            {
                centerPrint("something has opened");
                Thread.Sleep(1500);
                exitDemon();
                Globals.balling = true;
            }
            else if (special == "run")
            {
                theTruth();
                return;
            }
            else if (special == "man")
            {
                secret();
            }

            else if (special == "oldMan")
            {
                wrinklyGuy();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "cat")
            {
                cat();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "maro")
            {
                maro();
                Thread.Sleep(1500);
                bottomShopLane();
            }
            else if (special == "motherNot")
            {
                motherNot();
                Thread.Sleep(1500);
                middleLane();
            }
            else if (special == "boy")
            {
                boy();
                Thread.Sleep(1500);
                middleLane();
            }
            else if (special == "robin")
            {
                robin();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "VGD")
            {
                DHS();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "van")
            {
                van();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "teens")
            {
                teens();
                Thread.Sleep(1500);
                bottomShopLane();
            }
            else if (special == "hole")
            {
                hole();
                Thread.Sleep(1500);
                return;
            }
            else if (special == "karen")
            {
                karen();
                Thread.Sleep(1500);
                cashierStand();
            }
            else if (special == "batman")
            {
                batman();
                Thread.Sleep(1500);
                cashierStand();
            }
            else if (special == "kratos")
            {
                kratos();
                Thread.Sleep(1500);
                cashierStand();
            }
            else if (special == "jim")
            {
                jim();
                Thread.Sleep(1500);
                cashierStand();
            }
            else if (special == "fourthWall")
            {
                fourthWallBreakLol();
                Thread.Sleep(1500);
                cashierStand();
            }
            else if (special == "mother")
            {
                motherGot();
                Thread.Sleep(1500);
                return;
            }
            else if (special == "hydroxReg")
            {
                snackGot("Regular");
                Thread.Sleep(1500);
                topLane();
            }
            else if (special == "hydroxDoubleStuf")
            {
                snackGot("Double Stuffed");
                Thread.Sleep(1500);
                if (Globals.oldCheck == true)
                {
                    shopLanes();
                }
                else
                {
                    shopLanesInt();
                }
            }
            else if (special == "hydroxLemon")
            {
                snackGot("Lemon flavored");
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (special == "hydroxMint")
            {
                snackGot("Mint flavored");
                Thread.Sleep(1500);
                if (Globals.robinCheck == true)
                {
                    shopLanes();
                }
                else
                {
                    shopLanesInt();
                }
            }
            else if (special == "hydroxPeanutButter")
            {
                snackGot("Peanut Butter flavored");
                Thread.Sleep(1500);
                middleLane();
            }
            else if (special == "hydroxThins")
            {
                snackGot("Thin");
                Thread.Sleep(1500);
                Thread.Sleep(1500);
                if (Globals.batCheck == true)
                {
                    cashierStandEvil();
                }
                else
                {
                    cashierStand();
                }
            }
            else if (Globals.y == 8)
            {
                leftForHome();
                return;
            }
            else if (Globals.x == 5 && Globals.y == 6)
            {
                exit();
            }
            else if (Globals.x == 5 && Globals.y == 7)
            {
                exiter();
            }
            else if (Globals.x == 6 && Globals.y == 6)
            {
                if (Globals.karenCheck == true)
                {
                    topCashie();
                }
                else
                {
                    topCashieInt();
                }
            }
            else if (Globals.y == 6 && Globals.x == 1)
            {
                topLeftLane();
            }
            else if (Globals.y == 6 && (Globals.x == 2 || Globals.x == 4))
            {
                topShopLane();
            }
            else if (Globals.y == 6)
            {
                topLane();
            }
            else if (Globals.x == 5 && Globals.y == 1)
            {
                bottomExit();
            }
            else if (Globals.x == 1 && Globals.y == 1)
            {
                leftBottom();
            }
            else if (Globals.y == 1 && (Globals.x == 2 || Globals.x == 4))
            {
                if ((Globals.x == 2 && Globals.y == 1 && Globals.marCheck == true) || (Globals.x == 4 && Globals.y == 1 && Globals.teenCheck == true))
                {
                    bottomShopLane();
                }
                else
                {
                    bottomShopLaneInt();
                }
            }
            else if (Globals.y == 1 && Globals.x == 3)
            {
                bottomLane();
            }
            else if (Globals.x == 1 && Globals.y == 3)
            {
                leftLaneInt();
            }
            else if (Globals.x == 1)
            {
                leftLane();
            }
            else if (Globals.x == 3 && (Globals.y == 2 || Globals.y == 5))
            {
                if ((Globals.x == 3 && Globals.y == 5 && Globals.motherNotCheck == true) || (Globals.x == 3 && Globals.y == 2 && Globals.boyCheck == true))
                {
                    middleLane();
                }
                else
                {
                    middleLaneInt();
                }
            }
            else if (Globals.x == 3)
            {
                middleLane();
            }
            else if (Globals.x == 5)
            {
                exitLane();
            }
            else if ((Globals.x == 2 && (Globals.y == 5 || Globals.y == 3 || Globals.y == 2)) || (Globals.x == 4 && (Globals.y == 4 || Globals.y == 2 || Globals.y == 5)))
            {
                if ((Globals.x == 4 && Globals.y == 5 && Globals.robCheck == true) || (Globals.x == 2 && Globals.y == 3 && Globals.oldCheck == true) || (Globals.x == 2 && Globals.y == 2 && Globals.catCheck == true) || (Globals.x == 2 && Globals.y == 5 && Globals.robinCheck == true) || (Globals.x == 4 && Globals.y == 4 && Globals.VGDCheck == true) || (Globals.x == 4 && Globals.y == 2 && Globals.vanCheck == true))
                {
                    shopLanes();
                }
                else
                {
                    shopLanesInt();
                }

            }
            else if (Globals.x == 2 || Globals.x == 4)
            {
                shopLanes();
            }
            else if (Globals.x == 6 && Globals.y == 1)
            {
                motherFound();
            }
            else if (Globals.x == 6)
            {
                if ((Globals.x == 6 && Globals.y == 5 && Globals.batCheck == true) || (Globals.x == 6 && Globals.y == 4 && Globals.kratosCheck == true) || (Globals.x == 6 && Globals.y == 3 && Globals.jimCheck == true) || (Globals.x == 6 && Globals.y == 2 && Globals.fourthCheck == true)) 
                {
                    cashierStand();
                } else
                {
                    cashierStandEvil();
                }

            }
            sanitycounter();
            if (Globals.sanity == 0)
            {
                panicAttack();
                return;
            }
            else
            {
                moving(Console.ReadLine());
            }
        }

        //This function is the one that reads what you type and checks if it's possible to use in this senario

        static void moving(string input)
        {
            string special = " ";
            if (input.ToUpper() == "U")
            {
                if (Globals.x != 5 && (Globals.y == 6 || (Globals.x == 2 || Globals.x == 4 || Globals.x == 6)))
                {

                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
                else
                {
                    Globals.y++;
                }
            }
            else if (input.ToUpper() == "D")
            {
                if (Globals.y == 1 || (Globals.x == 2 || Globals.x == 4 || Globals.x == 6))
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
                else
                {
                    Globals.y--;
                }
            }
            else if (input.ToUpper() == "L")
            {
                if (Globals.y == 7)
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
                else if (Globals.x != 1)
                {
                    Globals.x--;
                }
                else
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
            }
            else if (input.ToUpper() == "R")
            {
                if (Globals.x == 5 && Globals.y == 7 && Globals.balling == true)
                {
                    Globals.x = 7;
                    special = "man";
                }
                else if (Globals.x == 5 && Globals.y == 7)
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
                else if (Globals.x != 6)
                {
                    Globals.x++;
                }
                else
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
            }
            else if (input.ToUpper() == "SNACK")
            {
                    if (Globals.x == 5 && Globals.y == 7)
                    {
                        special = "hydroxcrime";
                    }
                    else if (Globals.x == 4 && Globals.y == 6 && Globals.items.Contains("Regular") == false)
                    {
                        special = "hydroxReg";
                    }
                    else if (Globals.x == 2 && Globals.y == 3 && Globals.items.Contains("Double Stuffed") == false)
                    {
                        special = "hydroxDoubleStuf";
                    }
                    else if (Globals.x == 4 && Globals.y == 3 && Globals.items.Contains("Lemon flavored") == false)
                    {
                        special = "hydroxLemon";
                    }
                    else if (Globals.x == 2 && Globals.y == 5 && Globals.items.Contains("Mint flavored") == false)
                    {
                        special = "hydroxMint";
                    }
                    else if (Globals.x == 3 && Globals.y == 3 && Globals.items.Contains("Peanut Butter flavored") == false)
                    {
                        special = "hydroxPeanutButter";
                    }
                    else if (Globals.x == 6 && Globals.y == 5 && Globals.items.Contains("Thin") == false)
                    {
                        special = "hydroxThins";
                    }
            }
            else if (input.ToUpper() == "RX" && Globals.x == 1 && Globals.y == 6)
            {
                special = "nurse";
            }
            else if (input.ToUpper() == "I")
            {
                if (Globals.x == 4 && Globals.y == 5 && Globals.robCheck == false)
                {
                    special = "stranger";
                }
                else if (Globals.x == 2 && Globals.y == 3 && Globals.oldCheck == false)
                {
                    special = "oldMan";
                }
                else if (Globals.x == 2 && Globals.y == 2 && Globals.catCheck == false)
                {
                    special = "cat";
                }
                else if (Globals.x == 2 && Globals.y == 1 && Globals.marCheck == false)
                {
                    special = "maro";
                }
                else if (Globals.x == 7 && Globals.y == 7)
                {
                    special = "run";
                }
                else if (Globals.x == 3 && Globals.y == 5 && Globals.motherNotCheck == false)
                {
                    special = "motherNot";
                }
                else if (Globals.x == 3 && Globals.y == 2 && Globals.boyCheck == false)
                {
                    special = "boy";
                }
                else if (Globals.x == 2 && Globals.y == 5 && Globals.robinCheck == false)
                {
                    special = "robin";
                }
                else if (Globals.x == 4 && Globals.y == 4 && Globals.VGDCheck == false)
                {
                    special = "VGD";
                }
                else if (Globals.x == 4 && Globals.y == 2 && Globals.vanCheck == false)
                {
                    special = "van";
                }
                else if (Globals.x == 4 && Globals.y == 1 && Globals.teenCheck == false)
                {
                    special = "teens";
                }
                else if (Globals.x == 1 && Globals.y == 3)
                {
                    special = "hole";
                }
                else if (Globals.x == 6 && Globals.y == 6 && Globals.karenCheck == false)
                {
                    special = "karen";
                }
                else if (Globals.x == 6 && Globals.y == 5 && Globals.batCheck == false)
                {
                    special = "batman";
                }
                else if (Globals.x == 6 && Globals.y == 4 && Globals.kratosCheck == false)
                {
                    special = "kratos";
                }
                else if (Globals.x == 6 && Globals.y == 3 && Globals.jimCheck == false)
                {
                    special = "jim";
                }
                else if (Globals.x == 6 && Globals.y == 2 && Globals.fourthCheck == false)
                {
                    special = "fourthWall";
                }
                else if (Globals.x == 6 && Globals.y == 1)
                {
                    special = "mother";
                }
            }



            checkPlace(special);


        }

        //Below here are endings and text functions for the interactions

        static void nurse()
        {
            wholeSpace();
            centerPrint("The pharmacist looks at you, a little surprise is reflected in her eyes.");
            Thread.Sleep(1000);
            centerPrint("'Hey kid, are you here for the flu shot?'");
            Thread.Sleep(1000);
            centerPrint("At the words 'flu shot', your stress levels increase at the mere thought of getting a flu shot.");
            Thread.Sleep(1000);
            centerPrint("You mumble some lame excuse and move on.");
            Globals.sanity--;
        }
        static void robber()
        {
            wholeSpace();
            centerPrint("A scary man glares at you from the other side of the hall.");
            Thread.Sleep(1000);
            centerPrint("'Get lost, kid.', he says.");
            Thread.Sleep(1000);
            centerPrint("He turns away, but you notice him take a can of beans and slip it into his pocket.");
            Thread.Sleep(1000);
            centerPrint("Terrified, you root yourself for a bit until you feel the ability to move again.");
            Globals.sanity--;
            Globals.robCheck = true;
        }
        static void wrinklyGuy()
        {
            wholeSpace();
            centerPrint("An old man, slouched over a cane is looking around in the medicine aisle.");
            Thread.Sleep(1000);
            centerPrint("His hand shakes violently as he reaches for a bottle of Advil.");
            Thread.Sleep(1000);
            centerPrint("'Hey, did you know that you can grab items from the shelves?' He says as he turns to you.");
            Thread.Sleep(1000);
            centerPrint("'Considering that you're looking for some Hydrox there, try inputting 'snack' to search for it!'");
            Globals.oldCheck = true;
        }
        static void cat()
        {
            wholeSpace();
            centerPrint("As you walk down the aisle, you spot a cat browsing along the path you are taking.");
            Thread.Sleep(1000);
            centerPrint("It seems to sense you, turning its head around to glance at you causiously approaching it.");
            Thread.Sleep(1000);
            centerPrint("The cat turns around, allowing you to pet their small body.");
            Thread.Sleep(1000);
            centerPrint("You feel strangely at peace, maybe even excited as the cat disappears through a window in the wall.");
            Globals.sanity++;
            Globals.catCheck = true;
        }
        static void maro()
        {
            wholeSpace();
            centerPrint("There's a man strolling down the aisle, seemingly looking for something.");
            Thread.Sleep(1000);
            centerPrint("He looks up, sees you and doffs his hat to you.");
            Thread.Sleep(1000);
            centerPrint("'Its'a me, Maro!' You hear him mutter before he leaves out of earshot.'");
            Thread.Sleep(1000);
            centerPrint("You look back, temporarily confused until refocusing on your goal.");
            Globals.sanity++;
            Globals.marCheck = true;
        }
        static void motherNot()
        {
            wholeSpace();
            centerPrint("You see a woman looking at some bags of fruit, and you start to wonder.");
            Thread.Sleep(1000);
            centerPrint("Could it be? Was it mother? Was this the end of the adventure?");
            Thread.Sleep(1000);
            centerPrint("Alas, she turns around and accepts a different child into her arms, and you realize this woman is not mother.");
            Thread.Sleep(1000);
            centerPrint("Dejected, you turn away and continue on your search.");
            Globals.sanity--;
            Globals.motherNotCheck = true;
        }
        static void boy()
        {
            wholeSpace();
            centerPrint("You see a young boy, dressed in what seemed to be armor and hunting gear reach for a pack of campfire wood.");
            Thread.Sleep(1000);
            centerPrint("He turns around quickly, and in his hurry he drops a quiver from his arms, filled to the birm with arrows.");
            Thread.Sleep(1000);
            centerPrint("You call out loudly and point to the dropped items.");
            Thread.Sleep(1000);
            centerPrint("He turns back, mutters a quick word of thanks to you, and dashes off, leaving you more discontented than before.");
            Globals.sanity--;
            Globals.boyCheck = true;
        }
        static void robin()
        {
            wholeSpace();
            centerPrint("A teenager dressed in red, yellow and green spandex while also donning a cape stands in the middle of the aisle.");
            Thread.Sleep(1000);
            centerPrint("Strolling down the hallway, he nearly bumps into you.");
            Thread.Sleep(1000);
            centerPrint("'Oops! Sorry kid.' He says, with an awkward smile on his face.");
            Thread.Sleep(1000);
            centerPrint("As he leaves, he glances at you then hands you a nickel with a grin before rushing around the next corner.");
            Globals.sanity++;
            Globals.robinCheck = true;
        }
        static void teens()
        {
            wholeSpace();
            centerPrint("As you enter the aisle, 2 groups of high schoolers are crowding the sides of the aisles.");
            Thread.Sleep(1000);
            centerPrint("You can't understand what they're saying, but you decide to just leave them be.");
            Thread.Sleep(1000);
            centerPrint("You try and pass them, but their bodies are amassed to fill the whole lane.");
            Thread.Sleep(1000);
            centerPrint("Barely managing to squeeze through, you move on with your objective.");
            Globals.sanity--;
            Globals.teenCheck = true;
        }
        static void DHS()
        {
            wholeSpace();
            centerPrint("'Hey kid, do you like to play video games?' You hear from down the hall.");
            Thread.Sleep(1000);
            centerPrint("A man stands at the end of the aisle. He walks over and hands you a flyer for a school program. 'You think you'd be interested in this?'.");
            Thread.Sleep(1000);
            centerPrint("On the cover on the pamphlet is a picture of a school called 'Sno Isle Tech'.");
            Thread.Sleep(1000);
            centerPrint("Flipping through the pamphlet, you only see one that piques your interest. You walk away, wondering what a class on Video Game Design could offer.");
            Globals.sanity--;
            Globals.VGDCheck = true;
        }
        static void van()
        {
            wholeSpace();
            centerPrint("A strange man in a grey shirt stands in front of you, seemingly blocking the path forwards.");
            Thread.Sleep(1000);
            centerPrint("'Hey kid, want some candy?' He says as he offers a candy bar to you.");
            Thread.Sleep(1000);
            centerPrint("The candy is tempting to you, but you were taught stranger danger when you started going on trips with Mom.");
            Thread.Sleep(1000);
            centerPrint("You nervously back out of the aisle and turn the corner. You peek around the corner and the man has disappeared.");
            Globals.sanity--;
            Globals.vanCheck = true;
        }

        //cashier lane responses

        static void karen()
        {
            wholeSpace();
            centerPrint("A woman, all red in the face and shaking her fists is yelling at the cashier on the stand");
            Thread.Sleep(1000);
            centerPrint("The cashier, a bored teenager, is unperturbed at this sudden assault.");
            Thread.Sleep(1000);
            centerPrint("Realizing at this point that this is not mother, you turn around and leave.");
            Thread.Sleep(1000);
            centerPrint("Walking out of the lane, you hear her say 'I want to speak to the manager!'");
            Globals.sanity--;
            Globals.karenCheck = true;
        }
        static void batman()
        {
            wholeSpace();
            centerPrint("A brooding man what seems to be a bat comstume stands in the middle of the lane, waiting for something.");
            Thread.Sleep(1000);
            centerPrint("The cashier looks surprised for some reason, almost as if he had met a celebrity.");
            Thread.Sleep(1000);
            centerPrint("No, that's not awe. That cashier feels...fear.");
            Thread.Sleep(1000);
            centerPrint("Scared of what the cashier's scared of, you leave quickly.");
            Globals.sanity--;
            Globals.batCheck = true;
        }
        static void kratos()
        {
            wholeSpace();
            centerPrint("Towering over you as soon as you enter the lane is a large, bald, bearded man in armor.");
            Thread.Sleep(1000);
            centerPrint("He does a once over of your body, and seems to deem you fine and looks away.");
            Thread.Sleep(1000);
            centerPrint("You shy away a little, terrified of the large man and his axe on his back.");
            Thread.Sleep(1000);
            centerPrint("As you leave, you hear something akin to 'Boy?' being said behind you.");
            Globals.sanity--;
            Globals.kratosCheck = true;
        }
        static void jim()
        {
            wholeSpace();
            centerPrint("There stands a man next the to cashier desk, chatting with the person behind it.");
            Thread.Sleep(1000);
            centerPrint("You hear the terms 'hell' and 'sacrifice get thrown around very easily in their conversation.'");
            Thread.Sleep(1000);
            centerPrint("Scared of those words (you don't understand them), you attempt to leave without provoking a conversation.");
            Thread.Sleep(1000);
            centerPrint("Right before you are able to clear their field of vision, you get a chill in your spine, as if they saw you leave and said nothing about it.");
            Thread.Sleep(1000);
            Globals.sanity--;
            Globals.jimCheck = true;
        }
        static void fourthWallBreakLol() 
        {
            wholeSpace();
            centerPrint("A tired-looking woman glimpses at you as she places a coupld of groceries on the conveyor belt.");
            Thread.Sleep(1000);
            centerPrint("She stares off into the distance, seemingly in her own thoughts. You can faintly hear a mumbling sound coming from her.");
            Thread.Sleep(1000);
            centerPrint("You focus in enough in time to hear her say '..darn you, kid.' to some point in space. You hear the cashier hum 'Glimpse of Us'.");
            Thread.Sleep(1000);
            centerPrint("You turn around to leave her alone, but right before you leave, you see that the woman and cashier have disappeared behind you.");
            Globals.sanity--;
            Globals.fourthCheck = true;
        }
       
        //bonus stuff right here V (wip)

        static void snackGot(string flavor) 
        {
            wholeSpace();
            centerPrint("Checking the aisle there reveals a packet of " + flavor + " Hydrox! Good luck getting Mom to say yes to buying it though.");
            Globals.items.Add(flavor);
            wholeSpace();
        }

        //possible endings

        static void hole()
        {
            wholeSpace();
            centerPrint("Walking down the path, you feel a cool breeze when you walk past that section of wall.");
            Thread.Sleep(1000);
            centerPrint("Turning your head 90 degrees, you locate a section of the wall with nothing there.");
            Thread.Sleep(1000);
            centerPrint("Spotting this as an opportunity, you dash through the hole in the wall and out to the street.");
            Thread.Sleep(4000);
            centerPrint("Now what?");
        }
        static void leftForHome()
        {
            wholeSpace();
            centerPrint("Opening the front door, you take a breath of fresh air.");
            Thread.Sleep(1000);
            centerPrint("You finally feel...free.");
            Thread.Sleep(1000);
            centerPrint("Stepping out on the street, your little legs bring you to the endless possibilities of life.");
            Thread.Sleep(1000);
            centerPrint("Stopping only in your tracks to wonder what that honking noise was, and why was it getting really loud?");
        }
        static void panicAttack()
        {
            wholeSpace();
            centerPrint("Feeling overwhelmed, you no longer feel the ability to compose yourself.");
            Thread.Sleep(1000);
            centerPrint("You feel the mix of emotions you've been trying to hold in, a blend of fear, unsureness, and terror reach your brain");
            Thread.Sleep(1000);
            centerPrint("Feeling the urge to let it all out, you break down loudly, screaming and yelling for your mother to return to you.");
            Thread.Sleep(1000);
            centerPrint("Out of the tears pouring down your eyes, you can barely make out a distinct mother-like shape rushing towards you. You're safe now.");
        }
        static void motherGot()
        {
            wholeSpace();
            centerPrint("You turn the corner to see a very familiar back.");
            Thread.Sleep(1000);
            centerPrint("Hope rises in your chest as you rush towards her, and you feel the need to scream out 'MOMMY!'");
            Thread.Sleep(1000);
            centerPrint("You finally feel safe again.");
            Thread.Sleep(1000);
            centerPrint("Everything is alright with the world again.");
        }

        //silly ending hehe

        static void theTruth()
        {
            wholeSpace();
            centerPrint("This strange room you have entered, all dusty and dirty has you captivated.");
            Thread.Sleep(3000);
            centerPrint("The darkness feels almost...posessive, enveloping you whilst hiding the contents of the room.");
            Thread.Sleep(3000);
            centerPrint("You turn to leave, but the door in which you have came from has locked itself.");
            Thread.Sleep(3000);
            centerPrint("There's no way out.");
            Thread.Sleep(2000);
            centerPrint("'Hello, young child.'");
            Thread.Sleep(2000);
            centerPrint("You turn in surprise to see a thin man in the corner of the room, with what seemed to be interest in his eyes as he looks at you.");
            Thread.Sleep(3000);
            centerPrint("'You aren't supposed to be here, I reckon.'");
            Thread.Sleep(300);
            centerPrint("Your eyes suddenly adjust to the darkness of the room, and you can now see clearly.");
            Thread.Sleep(3000);
            centerPrint("The man stands over a body.");
            Thread.Sleep(3000);
            centerPrint("A familiar body.");
            Thread.Sleep(3000);
            centerPrint("Your screams are only met with silence.");
            Thread.Sleep(3000);
            centerPrint("'I see. Your mother, was she? Well, she made for an excellent catalyst for the revolution.'");
            Thread.Sleep(3000);
            centerPrint("'A blood sacrifice is always needed for these types of things nowadays, and she did excellently.'");
            Thread.Sleep(3000);
            centerPrint("'Now, the gods will bless my wish.'");
            Thread.Sleep(3000);
            centerPrint("'Hydrox, for so long, has taken the shelves. They have such potential, but yet they squander it so recklessly.'");
            Thread.Sleep(3000);
            centerPrint("'Now, I will take their place as the top of sandwich cookies.'");
            Thread.Sleep(3000);
            centerPrint("'Welcome...to the birth of Oreos.'");
            Thread.Sleep(1000);
        }
    }
}