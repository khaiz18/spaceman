using System;

namespace Spaceman
{
    class Game
    {

        public string Codeword { get; set; }
        public string word { get; set; }
        public int maxNum { get; set; }
        public int wrongNum { get; set; }
        public string[] wordBank = new string[] {

      "galaxy",
      "gravity",
      "spacecraft",
      "secret",
      "aerial",
      "sighting"

        };

        private Ufo spaceShip = new Ufo();


        public Game()
        {
            Random r = new Random();
            Codeword = wordBank[r.Next(wordBank.Length)];
            maxNum = 5;
            wrongNum = 0;

            for (int i = 0; i < Codeword.Length; i++)
            {
                word += "_";
            }

        }


        public void Greet()
        {
            Console.WriteLine("=============");
            Console.WriteLine("UFO: The Game");
            Console.WriteLine("=============");
            Console.WriteLine("Instructions: save your friend from alien abduction by guessing the letters in the codeword.");
        }

        public bool didWin()
        {

            if (Codeword.Equals(word))
            {
                return true;
            }
            else
            {
                return false;
            }



        }




    }



}