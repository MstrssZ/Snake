using System;

namespace Snake
{
    class Program
    {
        public static bool GameOver { get; set; }
        static char headChar = '%';

        static void Main()
        {
            GameOver = false;
            //initilize the screen
            //Console.SetBufferSize(16, 17);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("numer got:");
            Console.SetCursorPosition(7, 8);
            Console.WriteLine(headChar);

            Gameloop();
        }
        static void Gameloop()
        {
            int[] headPos = { 7, 8 };
            int bodyLength;
            string lastPressed = "e";

            Console.ReadKey(true);

            do
            {
                

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        lastPressed = "n";
                        break;

                    case ConsoleKey.DownArrow:
                        lastPressed = "s";
                        break;

                    case ConsoleKey.LeftArrow:
                        lastPressed = "w";
                        break;

                    case ConsoleKey.RightArrow:
                        lastPressed = "e";
                        break;

                    default:
                        break;
                }

                switch (lastPressed)
                {
                    case "n":
                        while (headPos[1] > 1)
                        {
                            headPos[1]--;
                            Console.SetCursorPosition(headPos[0], headPos[1]);
                            Console.WriteLine(headChar);
                        }
                        break;

                    case "s":
                        while (headPos[1] < 15)
                        {
                            headPos[1]++;
                            Console.SetCursorPosition(headPos[0], headPos[1]);
                            Console.WriteLine(headChar);
                        }
                        break;

                    case "e":
                        while (headPos[0] < 14)
                        {
                            headPos[0]++;
                            Console.SetCursorPosition(headPos[0], headPos[1]);
                            Console.WriteLine(headChar);
                        }
                        break;

                    case "w":
                        while (headPos[0] > 0)
                        {
                            headPos[0]--;
                            Console.SetCursorPosition(headPos[0], headPos[1]);
                            Console.WriteLine(headChar);
                        }
                        break;

                }








            } while (!GameOver);
        }
    }
}
