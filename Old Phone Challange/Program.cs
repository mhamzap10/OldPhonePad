using System;

namespace Old_Phone_Challange
{
    class Program
    {
        
       

        static void Main(string[] args)
        {

            IOldPhoneKeyPad phone = new OldPhoneKeyPad();
            Console.WriteLine(phone.GetOldPhoneKeys("#"));
            Console.WriteLine(phone.GetOldPhoneKeys(""));
            Console.WriteLine(phone.GetOldPhoneKeys("*"));
            Console.WriteLine(phone.GetOldPhoneKeys("*7*"));
            Console.WriteLine(phone.GetOldPhoneKeys("7#"));
            Console.WriteLine(phone.GetOldPhoneKeys("7*#"));
            Console.WriteLine(phone.GetOldPhoneKeys("*#"));
            Console.WriteLine(phone.GetOldPhoneKeys("33#"));
            Console.WriteLine(phone.GetOldPhoneKeys("227*#"));
            Console.WriteLine(phone.GetOldPhoneKeys("4433555 555666#"));
            Console.WriteLine(phone.GetOldPhoneKeys("8 88777444666*664#"));
            Console.WriteLine(phone.GetOldPhoneKeys("8 887774446667**664#"));


        }
    }
}
