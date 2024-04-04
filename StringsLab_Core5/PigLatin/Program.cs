using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a word or phrase.  Press the ENTER key when you're done.");
            string input = Console.ReadLine();

            string[] words = input.Split();
            foreach (string word in words)
                Console.WriteLine(word);

            string pig1 = PigLatin1(words[0]);
            Console.WriteLine("The word {0} in pig latin is: {1}", words[0], pig1);

            string pig2 = PigLatin2(words[0]);
            Console.WriteLine("The word {0} in pig latin is: {1}", words[0], pig2);



            // I'll do this with you in a screen cast
            static bool IsVowel(char c)
            {
                c = Char.ToLower(c);
                	switch (c)
                    {
                        case 'a': case 'e': case 'i': case 'o': case 'u':
                            return true;
                        default: 
                            return false;
                    }
                
               


            }




            // I'll do this with you in a screen cast
            static int IndexOfFirstVowel(string s)
            {
                int vIndex = -1;
                return vIndex;
            }



            // I'll do this in the screen cast
            // pig -> igpay
            static string PigLatin1(string s)
            {

                string pig = s.Substring(1) + s[0] + "ay";
                return pig;
            }



            // I'll do this with you in a screen cast
            //eat -> eatway
            static string PigLatin2(string s)
            {
                string pig;
                if (IsVowel(s[0]))
                    pig = s + "way";
                else
                    pig = s.Substring(1) + s[0] + "ay";
                return pig;
            }



            //Write a method called IndexOfFirstVowel that takes a string parameter and returns an interger that represents a 0 based index. The example code in .net fiddle should help you write this method. 
            //the string method Substring is overloaded. Assuming s is the word three 
            //s.Substring(3) will return ee 
            //s.Substring(0,3) will return the 

            //indexOfFirstVowel 
            //index of 3 so likely s[3] + "ay"

            static string IndexOfFirstVowel(string int)


        }
    }
}
