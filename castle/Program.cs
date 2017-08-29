using System;

namespace castle
{
    class Program
    {
        static void Main(string[] args)
        {
            Splash.Title();
            Console.WriteLine("Are you ready to play Castle?");
            Console.WriteLine("[i] Instructions\n[p] Play");
            string response = Console.ReadLine();
            if (response == "i") {
                //display instructions
            }
            else if (response == "p") {
                bool keepPlaying = false;
                while(keepPlaying){
                    Game game = new Game();
                    System.Console.WriteLine("Would you like to play again?");
                    Console.Write("yes or no? >>");
                    string keepPlayingResponse = Console.ReadLine();
                    if(keepPlayingResponse == "yes"){
                        keepPlaying = true;
                    }
                }
                System.Console.WriteLine("Thank you for playing Castle. Goodbye.");
              
            }
         
        }
    }
}
