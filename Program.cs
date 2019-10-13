using System;

namespace Spaceman
{
  class Program
  {
        string Codeword= "";
        string word = "";
        int maxNum = 0;
        int wrongNum = 0;
        string[] codeword;

        public  Program()
        {
        

            maxNum = 5;
            wrongNum = 0;

            for( int i =0; i < Codeword.Length; i++)
            {
                word += "_";
            }

            Console.WriteLine(word);
        }

        public static void Greet() {

            Console.WriteLine("=============UFO: The Game =============");
            Console.WriteLine("Instructions: save your friend from alien abduction by guessing the letters in the codeword.");

        }

    static void Main(string[] args)
    {
            Greet();
            Ufo ufo = new Ufo();

            Program p = new Program();
            p.Codeword = "Happy";
            Console.WriteLine(ufo);
    }
  }
}
