namespace Old_Phone_Challange
{
    public class OldPhoneKeyPad 
    {
        public string inputDigits { get; set; }
        private string outputResult ;
        private char _previousLetter;
        private int _pressedCount;

        public OldPhoneKeyPad()
        {
            this.inputDigits = "";
            this._pressedCount = 0;
            this.outputResult = "";
        }

        public OldPhoneKeyPad(string _inputDigits)
        {
            this.inputDigits = _inputDigits;
            this._pressedCount = 0;
            this.outputResult = "";
        }





        /// <summary>
        /// This method will take Input Character and Number of time it pressed, and will return respective output
        /// </summary>
        /// <returns></returns> 
        public void AppendOutput()
        {
            string[,] Alphabet = { { "&", "'", "(", "" }, { "A", "B", "C", "" }, { "D", "E", "F", "" }, { "G", "H", "I", "" }, { "J", "K", "L", "" }, { "M", "N", "O", "" }, { "P", "Q", "R", "S" }, { "T", "U", "V", "" }, { "W", "X", "Y", "Z" } };
            int index = 0;
            try
            {
                if (this._previousLetter == '7' || this._previousLetter == '9') // Letter 7 and 9 has 4 Alphabets
                {
                    if (this._pressedCount > 4) // This will check if user has pressed Letter more than 4 time, It will cycle through each letter again
                        this._pressedCount -= 4;
                }
                else if (this._pressedCount > 3)
                {
                    this._pressedCount -= 3; // This will check if user has Letter more than 3 time, It will cycle through each letter again
                }
                if (this._previousLetter == '*')
                    this.RemoveAlphabet(this._pressedCount);
                if (this._previousLetter == '#')
                    return;
                index = int.Parse(this._previousLetter.ToString()) - 1;
                this.outputResult += Alphabet[index, this._pressedCount - 1];
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Only Numbers are allowed...");
            }
        }

        public void RemoveAlphabet(int pressedCount = 1)
        {
            int startIndex = this.outputResult.Length - pressedCount;
            if (startIndex >= 0)
                this.outputResult = this.outputResult.Remove(startIndex);
        }

        /// <summary>
        ///This will turn any input to OldPhonePad into the correct output
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void OldPhonePad()
        {
            if (string.IsNullOrEmpty(this.inputDigits))
                return;
            this._previousLetter = this.inputDigits[0];
            int lastIndex = this.inputDigits.Length - 1;
            for (int i = 0; i <= lastIndex; i++)
            {
                char currentLetter = this.inputDigits[i];
                if (currentLetter == this._previousLetter)
                {
                    this._pressedCount++;
                    continue;
                }
                    this.AppendOutput();
                if (currentLetter == '*')
                    this.RemoveAlphabet();
                if (i + 1 <= lastIndex)
                {
                    this._previousLetter = currentLetter == ' ' || currentLetter == '*' ? inputDigits[i + 1] : currentLetter;
                    this._pressedCount = currentLetter == ' ' || currentLetter == '*' ? 0 : 1;
                }
                else
                    return;
            }
        }

        public string GetOldPhoneKeys()
        {
            this.OldPhonePad();
            return this.outputResult;
        }

    }
}
