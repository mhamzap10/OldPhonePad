using System;

namespace Old_Phone_Challange
{
    class Program
    {

        static void Main(string[] args)
        {
            OldPhoneKeyPad phone = new OldPhoneKeyPad();
            phone.inputDigits = "8 88777444666*664#";
            Console.WriteLine(phone.GetOldPhoneKeys() );
        }
    }
}
