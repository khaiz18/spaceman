using System;

namespace Spaceman
{
  class Program
  {
        
   
      

    static void Main(string[] args)
    {
            do
            {
                Game g = new Game();
                g.Greet();
                g.Ask();
                if (g.didLose())
                {
                    g.Display();
                    Console.WriteLine("Oh no! The UFO just flew away with another person!");
                    break;
                }
                else if (g.didWin())
                {
                    g.Display();
                    Console.WriteLine("Hooray! You saved the person and earned a medal of honor!");
                    break;
                }
            } while (true);
    }
  }
}
