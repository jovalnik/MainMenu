using System;

namespace MainMenu
{
    public class CarteDuJour : Menu
    {
        public int ALaCarte()
        {
            Console.CursorVisible = false;
            int choice = 0;
                        
            while (true)
            {
            
                int max = MenuOptions.Count;
               
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(Title);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(" ");

                for (int i = 0; i < max; i++)
                {

                    if (i == choice)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("[" + (i + 1) + "] " + MenuOptions[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("[" + (i + 1) + "] " + MenuOptions[i]);
                    }
                }

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Black;
                
                ConsoleKey readKey = Console.ReadKey().Key;
                if (readKey == ConsoleKey.DownArrow)
                {
                    choice++;
                    choice = choice % max;

                }

                else if (readKey == ConsoleKey.UpArrow)
                {
                    if (choice == 0)
                    {
                        choice = max - 1;
                    }
                    else
                    {
                        choice--;
                    }
                }
                else

                if (readKey == ConsoleKey.Enter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return choice;                     
                }
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;              
            }
        }
        public override string GetOption(int choice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            string returnMe = MenuOptions[choice];
            returnMe = returnMe.ToUpper();
            return returnMe;
        }
    }
    

}
