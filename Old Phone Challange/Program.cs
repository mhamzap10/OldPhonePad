using System;

namespace Old_Phone_Challange
{
    class Program
    {

        static void Main(string[] args)
        {
            OldPhoneKeyPad phone = new OldPhoneKeyPad();
            phone.inputDigits = "7*#";
            Console.WriteLine(phone.GetOldPhoneKeys() );
        }
    }
}
