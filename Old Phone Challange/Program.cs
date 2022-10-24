using System;

namespace Old_Phone_Challange
{
    class Program
    {
        /// <summary>
        /// This method will take Input Character and Number of time it pressed, and will return respective output
        /// </summary>
        /// <param name="input"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetAlphabet(char input, int count)
        {
            switch (input)
            {
                case '1':
                    if (count == 1)
                    {
                        return "&";
                    }
                    else if (count == 2)
                    {
                        return "'";
                    }
                    else if (count == 3)
                    {
                        return "(";
                    }
                    break;
                case '2':
                    if (count == 1)
                    {
                        return "A";
                    }
                    else if (count == 2)
                    {
                        return "B";
                    }
                    else if (count == 3)
                    {
                        return "C";
                    }
                    break;
                case '3':
                    if (count == 1)
                    {
                        return "D";
                    }
                    else if (count == 2)
                    {
                        return "E";
                    }
                    else if (count == 3)
                    {
                        return "F";
                    }
                    break;
                case '4':
                    if (count == 1)
                    {
                        return "G";
                    }
                    else if (count == 2)
                    {
                        return "H";
                    }
                    else if (count == 3)
                    {
                        return "I";
                    }
                    break;
                case '5':
                    if (count == 1)
                    {
                        return "J";
                    }
                    else if (count == 2)
                    {
                        return "K";
                    }
                    else if (count == 3)
                    {
                        return "L";
                    }
                    break;
                case '6':
                    if (count == 1)
                    {
                        return "M";
                    }
                    else if (count == 2)
                    {
                        return "N";
                    }
                    else if (count == 3)
                    {
                        return "O";
                    }
                    break;
                case '7':
                    if (count == 1)
                    {
                        return "P";
                    }
                    else if (count == 2)
                    {
                        return "Q";
                    }
                    else if (count == 3)
                    {
                        return "R";
                    }
                    else if (count == 4)
                    {
                        return "S";
                    }
                    break;
                case '8':
                    if (count == 1)
                    {
                        return "T";
                    }
                    else if (count == 2)
                    {
                        return "U";
                    }
                    else if (count == 3)
                    {
                        return "V";
                    }
                    break;
                case '9':
                    if (count == 1)
                    {
                        return "W";
                    }
                    else if (count == 2)
                    {
                        return "X";
                    }
                    else if (count == 3)
                    {
                        return "Y";
                    }
                    else if (count == 3)
                    {
                        return "Z";
                    }
                    break;
            }
            return "";
        }

        /// <summary>
        ///This will turn any input to OldPhonePad into the correct output
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string OldPhonePad(string input)
        {
            if (input.Length == 0)
            {
                return "";
            }
            string output = "";
            char previousLetter = input[0];
            int pressedCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];
                if (currentLetter == previousLetter)
                {
                    pressedCount++;
                    continue;
                }
                else if(currentLetter == '*')
                {
                    if (i + 1 < input.Length) // Just in case * is a last letter, and there is no '#', This condition is just for safe side to avoid exception
                    {
                        previousLetter = input[i + 1];
                        pressedCount = 0;
                    }
                    continue;
                }
                else 
                {
                    if (previousLetter == '7' || previousLetter == '9') // Letter 7 and 9 has 4 Alphabets
                    {
                        if (pressedCount > 4) // This will check if user has pressed Letter more than 4 time, It will cycle through each letter again
                            pressedCount -= 4;
                    }
                    else if (pressedCount > 3)
                    {
                        pressedCount -= 3; // This will check if user has Letter more than 3 time, It will cycle through each letter again
                    }
                    // This method will get respective Alphabet based on input character and number of time it pressed
                    output += GetAlphabet(previousLetter, pressedCount);
                    if (currentLetter == '#')
                        return output;
                    previousLetter = currentLetter;
                    pressedCount = 1;
                }

            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(OldPhonePad("#"));
            Console.WriteLine(OldPhonePad(""));
            Console.WriteLine(OldPhonePad("*"));
            Console.WriteLine(OldPhonePad("*7*"));
            Console.WriteLine(OldPhonePad("7#"));
            Console.WriteLine(OldPhonePad("7*#"));
            Console.WriteLine(OldPhonePad("*#"));
            Console.WriteLine(OldPhonePad("33#"));
            Console.WriteLine(OldPhonePad("227*#"));
            Console.WriteLine(OldPhonePad("4433555 555666#"));
            Console.WriteLine(OldPhonePad("8 88777444666*664#"));
        }
    }
}
