using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Challange
{
    class OldPhoneKeyPad : IOldPhoneKeyPad
    {
        /// <summary>
        /// This method will take Input Character and Number of time it pressed, and will return respective output
        /// </summary>
        /// <param name="input"></param>
        /// <param name="count"></param>
        /// <returns></returns> 
        public static string GetAlphabet(char input, int count)
        {
            string[,] Alphabet = { { "&", "'", "(", "" }, { "A", "B", "C", "" }, { "D", "E", "F", "" }, { "G", "H", "I", "" }, { "J", "K", "L", "" }, { "M", "N", "O", "" }, { "P", "Q", "R", "S" }, { "T", "U", "V", "" }, { "W", "X", "Y", "Z" } };
            int index = 0;
            try
            {
                index = int.Parse(input.ToString()) - 1;
            }
            catch (System.FormatException)
            {
                return "";
            }
            return Alphabet[index, count - 1];

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
            bool backSpaceFlag = false;
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];
                if (currentLetter == previousLetter && currentLetter != '*')
                {
                    if (backSpaceFlag)
                        backSpaceFlag = false;
                    pressedCount++;
                    continue;
                }
                else if (currentLetter == '*')
                {
                    if (backSpaceFlag)
                    {
                        if (output.Length > 0)
                            output = output.Remove(output.Length - 1);
                        backSpaceFlag = false;
                    }
                    if (i + 1 < input.Length)
                    {
                        previousLetter = input[i + 1];
                        pressedCount = 0;
                        backSpaceFlag = true;
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

        public string GetOldPhoneKeys(string inputKeys)
        {
            return OldPhonePad(inputKeys);
        }

    }
}
