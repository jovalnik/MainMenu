using System;

namespace MainMenu
{
    internal static class Program
    {
        private static void Main()
        {

            CarteDuJour carte = new CarteDuJour();

            carte.AddOption("Filet Mignon");
            carte.AddOption("Homard a la Amoricaine");
            carte.AddOption("Just a tiny mint wafer, Monsieur");
            carte.Title = "Welcome to RoboGarcon (Use arrow keys to select, <ENTER> to choose)  ";

            int choice = carte.ALaCarte();

            Console.WriteLine(" ");
            Console.WriteLine("You chose " + carte.GetOption(choice));
           
            Console.ReadLine();          
        }
    }
    

}
