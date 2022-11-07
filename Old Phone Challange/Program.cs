using System;

namespace Old_Phone_Challange
{
    class Program
    {
        
       

        static void Main(string[] args)
        {
            IOldPhoneKeyPad phone = new OldPhoneKeyPad();
            Console.WriteLine(phone.GetOldPhoneKeys("8 887774446667**664#") );
        }
    }
}
