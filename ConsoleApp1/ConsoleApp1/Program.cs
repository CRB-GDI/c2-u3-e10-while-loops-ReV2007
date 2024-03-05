namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************");
            Console.WriteLine("Da Game (super real game menu)");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("************");

            Console.WriteLine("Pick one of the choices above");
            int numberpicked = int.Parse(Console.ReadLine());

            if (numberpicked == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Starting New Game ...");
            }

            if (numberpicked == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Loading game ...");
            }
            if (numberpicked == 3)
            {
                Console.WriteLine();
                Console.WriteLine("**************");
                Console.WriteLine("1 - Video");
                Console.WriteLine("2 - Graphics");
                Console.WriteLine("3 - Audio");
                Console.WriteLine("4 - Game");
                Console.WriteLine("**************");
                Console.WriteLine();
                Console.WriteLine("(THESE ARENT REAL SILLY");
            }
            if (numberpicked == 4)
            {
                Console.WriteLine();
                Console.WriteLine("oh ok! Thanks for playing :D");

            }
            //Invalid Options
            while (numberpicked < 1 || numberpicked > 4)
            {
                Console.WriteLine();
                Console.WriteLine("Whoops misimput! try again :D");

                //Restating they need to pick a valid option
                Console.WriteLine("************");
                Console.WriteLine("Da Game (super real game menu)");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("************");


                numberpicked = int.Parse(Console.ReadLine());


                //print choice
                if (numberpicked == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting New Game ...");
                }

                if (numberpicked == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loading game ...");
                }
                if (numberpicked == 3)
                {

                    Console.WriteLine();
                    Console.WriteLine("**************");
                    Console.WriteLine("1 - Video");
                    Console.WriteLine("2 - Graphics");
                    Console.WriteLine("3 - Audio");
                    Console.WriteLine("4 - Game");
                    Console.WriteLine("**************");
                    Console.WriteLine();
                    Console.WriteLine("(THESE ARENT REAL SILLY");
                }
                if (numberpicked == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("oh ok! Thanks for playing :D");



                }
            }
        }
    }
}