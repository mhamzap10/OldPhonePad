namespace Old_Phone_Challange
{
    public class OldPhoneKeyPad : IOldPhoneKeyPad
    {
        public string inputDigits { get; set; }
        string outputResult { get; set; }
        char _previousLetter { get; set; }
        int _pressedCount { get; set; }
        bool _backSpaceFlag { get; set; }

        public OldPhoneKeyPad()
        {
            this.inputDigits = "";
            this._pressedCount = 0;
            this._backSpaceFlag = false;
            this.outputResult = "";
        }

        public OldPhoneKeyPad(string _inputDigits)
        {
            this.inputDigits = _inputDigits;
            this._previousLetter = inputDigits[0];
            this._pressedCount = 0;
            this._backSpaceFlag = false;
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

                index = int.Parse(this._previousLetter.ToString()) - 1;
                this.outputResult += Alphabet[index, this._pressedCount - 1];
            }
            catch (System.FormatException)
            {
              
            }  
        }

        public void RemoveAlphabet()
        {
            int count = this.outputResult.Length - this._pressedCount;
                if (count > 0)
                    this.outputResult = this.outputResult.Remove(count);
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
                else if (currentLetter == '*')
                {
                    this.RemoveAlphabet();
                }
                else
                {
                    // This method will Append Alphabet based on input character and number of time it pressed
                    this.AppendOutput();
                }

                this._previousLetter = currentLetter;
                this._pressedCount = 1;

            }
        }

        public string GetOldPhoneKeys()
        {
            this.OldPhonePad();
            return this.outputResult;
        }

    }
}
