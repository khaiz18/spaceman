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

        public void Display()
        {
            Console.WriteLine(spaceShip.Stringify());
            Console.WriteLine($"Current word: {word}");
            Console.WriteLine($"Wrong Guesses: {wrongNum}");
            

        }

        public void Ask()
        {
            Console.WriteLine("Enter a letter.");
          string stringGuess =   Console.ReadLine();
            if (stringGuess.Trim().Length != 1)
            {
                Console.WriteLine("One letter at a time!");
                return;
            }
            char guess = stringGuess.Trim().ToCharArray()[0];
            if (Codeword.Contains(guess))
            {
                Console.WriteLine($"'{guess}' is in the word!");
                for (int i = 0; i < Codeword.Length; i++)
                {
                    if (guess == Codeword[i])
                    {
                        word = word.Remove(i, 1).Insert(i, guess.ToString());
                    }
                }
            }


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
            public bool didLose()
            {

                if (wrongNum >= maxNum)
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