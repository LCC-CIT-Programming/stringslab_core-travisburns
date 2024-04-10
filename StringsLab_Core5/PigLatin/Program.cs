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

            string pig3 = PigLatin3(words[0]);
            Console.WriteLine("Lab Problem 1:The word {0} in pig latin is: {1}", words[0], pig3);

            string pig4 = PigLatin4(words[0]);
            Console.WriteLine("Lab Problem 2:The word {0} in pig latin is: {1}", words[0], pig4);

            string pig5 = PigLatin5(words[0]);
            Console.WriteLine("Lab Problem 3:The word {0} in pig latin is: {1}", words[0], pig5);


            string pig6 = pigLatin6(input);
            Console.WriteLine("Lab Problem 4:The phrase/sentence in pig latin is: {0}", pig6);

            // I'll do this with you in a screen cast
            static bool IsVowel(char c)
            {
                c = Char.ToLower(c);
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        return true;
                    default:
                        return false;
                }




            }




            // I'll do this with you in a screen cast - updated by looking at the SelfEvalution form as it helped me better understand how to write the code. This needed to be changed 
            //from the first version of this code - this is called within the pigLatin method's below for the labs.  
            static int IndexOfFirstVowel(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (IsVowel(s[i]))
                    {
                        return i;
                    }
                }

                return -1;
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



            

            //Using the Visual Studio Solution containing the example program from class (and the screen casts) as a starting point,
            //improve the pig latin method so that words that begin with multiple consonants move all of the consonants to the end of the word and add ay.  three -> eethray for example.

            static string PigLatin3(string s)
            {
                //a int vowelIndex is used to draw from IndexOfFirstVowel at the s character 
                int vowelIndex = IndexOfFirstVowel(s);

                //a If then statement can properly check/set up consition for whether the word begins with vowels and or consonants

                //if index of vowelIndex is greater than 0,
                     //the string consonants equals the char s between 0 and the vowelIndex(the subString) 
                    //string remaining equals the char s at VowelIndex(the substring)
                    //return the remaining pluys the consonants + "ay"
                //else if the vowelIndex is equal to zero(meaning there are no vowels), then return the char s + "way"
                //finnaly else,
                    //the consonants will equal s's substring between, 0 and 2.(a index of three)/relative to multiple consonants
                    //the remaining will be equal to s's substring at index of 2 
                    //and return the remaining plus the consonants + "ay"
                        
                if (vowelIndex > 0)
                {
                    string consonants = s.Substring(0, vowelIndex);
                    string remaining = s.Substring(vowelIndex);
                    return remaining + consonants + "ay";
                }
                else if (vowelIndex == 0)
                {
                    return s + "way";
                }
                else
                {
                    string consonants = s.Substring(0, 2);
                    string remaining = s.Substring(2);
                    return remaining + consonants + "ay";
                }


            }

            //Using the Visual Studio Solution containing the example program from class (and the screen casts) as a starting point, improve the pig latin method so that words that
            //begin with a capital letter are converted to pig latin words that capitalize the first letter.  Cooper -> Oopercay for example.

            static string PigLatin4(string s)
            {

                //Need to define a check for if the first letter is a capital. - isCapital represents a bool equal to char.IsUpper(s[0])
                bool isCapital = char.IsUpper(s[0]); 
                //Need to define VowelIndex equal to IndexOfFirstVowel(s) - this ensures IndexOfFirstVowel defined above can be used within the method. 
                int vowelIndex = IndexOfFirstVowel(s);

                //if the vowelIndex within the word is greater than zero, then similiar methodology as the last problem. 
                if (vowelIndex > 0)
                {
                    string consonants = s.Substring(0, vowelIndex);
                    string remaining = s.Substring(vowelIndex);
                    string pigLatin = remaining + consonants + "ay";
                    //However, in this case, if isCapital is true then define pigLatin equal to a uppercase character at the firstIndex of piglatin and add the remaning in loweCase
                    if (isCapital)
                    {
                        // Retain the original capitalization for the first letter
                        pigLatin = char.ToUpper(pigLatin[0]) + pigLatin.Substring(1).ToLower();
                    }

                    return pigLatin;
                }
                //if there are no vowels found, vowelIndex equal to zero then the string pigLatin = the word + way and if isCapital is true, then do the exact same thing as above but just in the case of no vowels found, adding way instead of ay
                else if (vowelIndex == 0)
                {
                    string pigLatin = s + "way";
                    if (isCapital)
                    {
                        // Retain the original capitalization for the first letter
                        pigLatin = char.ToUpper(pigLatin[0]) + pigLatin.Substring(1).ToLower();
                    }
                    return pigLatin;
                }

                //extra check to ensure that if capitalization is added to the word when vowels are found, all other index's after the first([0]) are in lowecase
                else
                {
                    string pigLatin = s + "ay";
                    if (isCapital)
                    {
                        // Retain the original capitalization for the first letter
                        pigLatin = char.ToUpper(pigLatin[0]) + pigLatin.Substring(1).ToLower();
                    }
                    return pigLatin;
                }
            }


            static string PigLatin5(string s)
            {
                // needs to have a variable that is able to represent the last character to draw from
                char lastChar = s[s.Length - 1];
                //needs to have a way to determine the puncuation. 
                bool isPunctuation = false;
                //by setting up a switch statement, with the lastChar set as the parameter, we can determine either . ? ! , ; or : and if lastChar is of these, isPuncuation = true, 
                // by default it will be set up as false. 
                switch (lastChar)
                {
                    case '.':
                    case '?':
                    case '!':
                    case ',':
                    case ';':
                    case ':':
                        isPunctuation = true;
                        break;
                    default:
                        isPunctuation = false;
                        break;
                }

                // Remove punctuation from the end of the string
                if (isPunctuation)
                {
                    s = s.Substring(0, s.Length - 1); // Remove the last character if isPuncuation is true
                }

                // create a int called vowelIndex that can allow us to draw from the logic of the IndexOfFirstVowel(s)
                int vowelIndex = IndexOfFirstVowel(s);
                //like before, if the vowelIndex is greater than 0
                    //then we can set up the logic, consonants equals a substring of s between 0 and the voweIndex
                    // a string remaining is equal to the substring of s at vowelIndex
                    // and string pigLatin is equal to remaining plus the consonants + 'ay'
                if (vowelIndex > 0)
                {
                    string consonants = s.Substring(0, vowelIndex);
                    string remaining = s.Substring(vowelIndex);

                    string pigLatin = remaining + consonants + "ay";

                    // if isPuncuation is true, meaning the lastChar is one of the cases above in the switch statement, then the word stored in pigLatin will then add the lastChar to it, which is the punctuation mark. 
                    if (isPunctuation)
                    {
                        // Append the punctuation mark to the end of pigLatin
                        pigLatin += lastChar;
                    }

                    return pigLatin;
                }

                // If no vowels found, return the original string
                return s;
            }




            //improve the program to allow the user to enter more than one word from the keyboard.
            //The program should translate the phrase or sentence, complete with capitalization and punctuation, to pig latin.


            static string pigLatin6(string s)
            {
                // Needs to have a way to store the result 
                string result = "";

                // Needs to have a way to be able to split apart multiple words. As in this specific problem, multiple words will be used to create a phrase/sentence.
                string[] words = s.Split(' ');

                // In order to implement the logic for a complete phrase, setting up a for each loop would acheive this. Where the string word in words will be defined parameters for the loop. 
                foreach (string word in words)
                {
                    // Needs to have a variable that is able to represent the last character to draw from
                    char lastChar = word[word.Length - 1];

                    // Needs to have a way to determine the punctuation. - similiar to above, will set up a switch statement for puncution. 
                    bool isPunctuation = false;

                    // By setting up a switch statement, with the lastChar set as the parameter,
                    // we can determine if lastChar is punctuation.
                    switch (lastChar)
                    {
                        case '.':
                        case '?':
                        case '!':
                        case ',':
                        case ';':
                        case ':':
                            isPunctuation = true;
                            break;
                        default:
                            isPunctuation = false;
                            break;
                    }

                    // In order to later be able to place the puncucation mark back on the word. It needs to first be removed for now. This will be stored in clearWord
                    string clearWord = word;
                    //if the puncuation is true, then clearWord will equal the words substring between the first index and the last index. 
                    if (isPunctuation)
                    {
                        clearWord = word.Substring(0, word.Length - 1);
                    }

                    // translatedWord will equal a empty string 
                    //where vowelIndex will equal the IndexOfFirstVowel (defined above) but in this case will use the clearWord as the parameter
                    string translatedWord = "";
                    int vowelIndex = IndexOfFirstVowel(clearWord);
                    //similiar logic to other problems, if the vowelIndex is greater then 0 then consonants will equal clearWord.Substring(0, vowelIndex) - note not the s character's substring like the problms above. As the words need to be cleared first.
                    // remaining equals clearWord.Substring(vowelIndex)
                    //and translatedWord equal to remaining plus Consonants + "ay"
                    if (vowelIndex > 0)
                    {
                        string consonants = clearWord.Substring(0, vowelIndex);
                        string remaining = clearWord.Substring(vowelIndex);
                        translatedWord = remaining + consonants + "ay";
                    }
                    // if no vowels (vowelIndex equal to zero)
                    //translatedWord is equal to clearWord + "Yay"
                    else if (vowelIndex == 0)
                    {
                        translatedWord = clearWord + "yay"; 
                    }
                    //in any other case, translatedWord will equal clearWord + "ay"
                    else
                    {
                        translatedWord = clearWord + "ay";
                    }

                    // if there was a cpatial found in the first index of the original word. Capitalize the first letter of the translated word
                    if (char.IsUpper(clearWord[0]))
                    {
                        translatedWord = char.ToUpper(translatedWord[0]) + translatedWord.Substring(1).ToLower(); // Capitalize only the first letter
                    }

                    // Restore punctuation to the translated word if it was present in the original word
                    if (isPunctuation)
                    {
                        translatedWord += lastChar;
                    }

                    // Append the translated word to the result string
                    result += translatedWord + " ";
                }

                // Remove trailing space and return the result
                return result.Trim();
            }

        }
    }
}