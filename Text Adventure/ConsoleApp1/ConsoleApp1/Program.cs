using System.Security.Cryptography.X509Certificates;

namespace Text_adventure
{
    
    internal class Program
    { 
        static void Main(string[] args)
        {
            float x = 3;
            float y = 4;
            wholeSpace();
            centerPrint("This game is meant to be played in full screen.");
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
            centerPrint("You turn around to request assistance from the one that feeds you, the woman who has birthed you.");
            Thread.Sleep(2000);
            centerPrint("She's gone.");
            Thread.Sleep(1500);
            int sanity = 3;
            startLane();
            moving(Console.ReadLine(), x, y);


        }

        public static class Globals
        {
            public static bool robCheck = false;
        }

        static void centerPrint(string e)
        {
            string s = e;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine("|");
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop - 1);
            Console.WriteLine(s);
            Console.SetCursorPosition(Console.WindowWidth - 1, Console.CursorTop - 1);
            Console.WriteLine("|");
        }

        static void wholeSpace()
        {
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

        static void choiceMenu()
        {
            Console.WriteLine("______________________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("|______________________________________________________________________________________________________|_____________________________________________________________________________________________________|");
            Console.WriteLine("|                           ______   _______      _____               _______                          |                               ______                ______    ______                                |");
            Console.WriteLine("|                          |            |        /     |   |     |       |                             |                              |          |          |         |                                      |");
            Console.WriteLine("|                          |_____       |       /          |     |       |                             |                              |_____     |          |_____    |_____                                 |");
            Console.WriteLine("|                          |            |       |  ____    |_____|       |                             |                              |          |          |         |                                      |");
            Console.WriteLine("|                          |            |       |     /    |     |       |                             |                              |          |          |         |                                      |");
            Console.WriteLine("|                          |         ___|___    |____/     |     |       |                             |                              |          |______    |______   |______                                |");
            Console.WriteLine("|______________________________________________________________________________________________________|_____________________________________________________________________________________________________|");
            Console.WriteLine("|______________________________________________________________________________________________________|_____________________________________________________________________________________________________|");


        }

        static void sanitycounter()
        {
            Console.WriteLine("                                                                                                                                                                                                              ");
            Console.WriteLine("                                              Sanity = 3                                                                                                                                                      ");
            Console.WriteLine("                                                                                                                                                                                                              ");
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

        static void topLane()
        {
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
            wholeSpace();

        }

        static void topLeftLane()
        {
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
            centerPrint("///////////////|                                                                                ");
            centerPrint("///////////////|                                                                                ");

        }

        static void topShopLane() 
        {
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
                wholeSpace();
                centerPrint("                           __________________________________________                           ");
                centerPrint("                          |******************************************|                          ");
                centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
                centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
                centerPrint("                           ------------------------------------------                           ");
                centerPrint("                                                                                                ");
                centerPrint("                                                                                                ");
                centerPrint("                             { P }                                                              ");
                centerPrint("                                             [ I ]                                              ");
                centerPrint("                           __________________________________________                           ");
                centerPrint("                          |******************************************|                          ");
                centerPrint("                          |*********************************[ C ]****|                          ");
                centerPrint("                          |******************************************|                          ");
                centerPrint("                           ------------------------------------------                           ");
                wholeSpace();
        }
        static void motherFound()
        {
            wholeSpace();
            wholeSpace();
            wholeSpace();
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |()()()()()()()()()()()()()()()()()()()()()|                          ");
            centerPrint("                          ||||||||||||||||||||||||||||||||||||||||||||                          ");
            centerPrint("                           ------------------------------------------                           ");
            centerPrint("                                                                                                ");
            centerPrint("                                                                                                ");
            centerPrint("                             { P }                                                              ");
            centerPrint("                                                [ I ]                                           ");
            centerPrint("                           __________________________________________                           ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                          |*********************************[ C ]****|                          ");
            centerPrint("                          |******************************************|                          ");
            centerPrint("                           ------------------------------------------                           ");
            wholeSpace();
        }

        static void checkPlace(string special, float x, float y)
        {
            Console.Clear();
            if (y == 6 && x == 1 && special == "nurse")
            {
                nurse();
                Thread.Sleep(1500);
                topLeftLane();
            }
            else if (x == 2 && y == 5 && special == "stranger")
            {
                robber();
                Thread.Sleep(1500);
                shopLanes();
            }
            else if (y == 6 && x == 1)
            {
                topLeftLane();
            }
            else if (y == 6 && (x == 2 || x == 4))
            {
                topShopLane();
            }
            else if (y == 6)
            {
                topLane();
            }
            else if (x == 1 && y == 1)
            {
                leftBottom();
            }
            else if (x == 1)
            {
                leftLane();
            }
            else if (x == 3)
            {
                middleLane();
            }
            else if ((x == 2 && (y == 5 || y == 3 || y == 2)) || (x == 4 && (y == 4 || y == 2 || y == 5)))
            {
                if (x == 2 && y == 5 && Globals.robCheck == true)
                {
                    shopLanes();
                }
                else
                {
                    shopLanesInt();
                } 
                
            } 
            else if (x == 2 || x == 4)
            {
                shopLanes();
            }
            else if (x == 6 && y == 1)
            {
                motherFound();
            }
            else if (x == 6)
            {
                cashierStandEvil();
            }
            moving(Console.ReadLine(), x, y);
        }
       static void moving(string input, float x, float y)
       {
          string special = "";
          if (input.ToUpper() == "U")
          {
                if (y != 6)
                {
                    y++;
                } 
                else
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
          }
          else if (input.ToUpper() == "D")
          {
                if (y != 1)
                {
                    y--;
                }
                else
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
            }
          else if (input.ToUpper() == "L")
          {
                if (x != 1)
                {
                    x--;
                }
                else
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
            }
          else if (input.ToUpper() == "R")
          {
                if (x != 6)
                {
                    x++;
                }
                else
                {
                    centerPrint("You can't go there!");
                    Thread.Sleep(3000);
                }
            } 
          else if (input.ToUpper() == "CHECK FOR OREOS")
            {
            }
          else if (input.ToUpper() == "RX" && x == 1 && y == 6)
          {
                special = "nurse";
          }
          else if (input.ToUpper() == "I" && x == 2 && y == 5)
          {
                special = "stranger";
          }
          checkPlace(special, x, y);

       }
       
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
            Globals.robCheck = true;
        }
    }
}


