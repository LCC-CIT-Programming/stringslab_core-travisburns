using System;

namespace ShiftCypher
{
    class Program
    {
        static void Main(string[] args)
        { 
      Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

        Console.WriteLine("Enter a shift Value(A negative number is left, a positive is right):");
            int shift = int.Parse(Console.ReadLine());

        // Encrypt the input word using the provided shift
        string caesarCipher1 = CaesarCipher(word, shift);
        Console.WriteLine("Lab Problem 4: Encoded Word: " + caesarCipher1);

            // Generate a random shift between -10 and 10
            Random rand = new Random();
        int randomShift = rand.Next(-10, 11);

        // Encrypt the input word using the randomly generated shift
        string caesarCipher2 = CaesarCipher2(word, randomShift);
        Console.WriteLine("Lab problem 5: Encoded Word (Randomly Generated Shift): " + caesarCipher2);
        }




    //Implement a method that will encode a word using a shift or Ceasar cypher.  In cryptography, a Caesar cipher, also known as Caesar's cipher, the shift cipher,
    //Caesar's code or Caesar shift, is one of the simplest and most widely known encryption techniques. It is a type of substitution cipher in which each letter in
    //the plaintext is replaced by a letter some fixed number of positions down the alphabet. For example, with a right shift of 3, A would be replaced by D, B would become E, and so on.
    //The method is named after Julius Caesar, who used it in his private correspondence.  The method should take a string that represents the word to be encoded and an integer representing the number of characters to shift.
    //A positive shift is a right shift.  A negative shift is a left shift.  The method should return the encoded string.  


    //Input 
    //should take a string that represents the word to be encoded and a integer repreensting the number of characters to shift. 
    //Word - string
    //A specified shift. - int 


    //Proccessing
    //string manipulation - one method 

    //Iterate through each character in the input's word 
    //determine if each letter is a letter - a char 
    //if it is a letter then apply the shift 
    //replace it with a fixed number relative to the alphabet - for example a right shift of 3 would replace a A to a D, B to a E, Etc. 






    //Output
    //should return the encoded string
    public static string CaesarCipher(string word, int shift)
        {
            string encodedWord = "";

            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    char encodedChar = (char)(c + shift);
                    encodedWord += encodedChar;
                }
                else
                {
                    // If it's not a letter, just append it as is
                    encodedWord += c;
                }
            }

            return encodedWord;
        }




        //Design and implement a program that allows the user to enter a phrase or sentence from the keyboard and encrypt it using a shift or Ceasar cypher.  The program should generate a random number between -10 and 10 to use for the shift.  



        //Input 
        //should take a string that represents the word, phrase, or sentence to be encoded 
        //it should by itself generate a random integer between - 10 and 10 to determine the shift


        //Word/phrase/sentenace - string
        //A Random shift. - int 


        //Proccessing
        //string manipulation - one method 

        //Iterate through each character in the inputs full phrase
        //determine if each letter is a letter - a char 
        //if it is a letter then apply the shift (randomShift)
        //replace each letter with a new letter that is determined by the shift






        //Output
        //should return the encoded string


        //On learning from the Self Evalution, I learned I need to do this  (Added a call to String.Split and a loop to process a sentence that includes more than one word?)  - this means I needed to adjust the solution
        //Need to setup a call to the Split method in order to split the words up. 


        public static string CaesarCipher2(string sentence, int shift)
        {
            string[] words = sentence.Split(' '); // Split the sentence into individual words
            string encodedSentence = "";

            foreach (string word in words)
            {
                // Encrypt each word separately using the provided shift
                string encodedWord = CaesarCipher(word, shift);
                encodedSentence += encodedWord + " "; // Append the encoded word to the encoded sentence
            }

            return encodedSentence.Trim(); // Remove any trailing spaces and return the encoded sentence
        }








    }
}
