using System;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mailAddress;
            mailAddress = IsEmailAddress("dominik.krahwinkel@gmailc.com");
            mailAddress = IsEmailAddress("dominik.krahwinkel@jojocom");

            Console.WriteLine(IsEmailAddress("dominik.@gmail.com"));
            Console.WriteLine(IsEmailAddress("dominik.krahwinkel@gmail.com"));
            Console.WriteLine(mailAddress);
            Console.WriteLine(mailAddress);

            string emailAddress = "dominik.krahwinkel@gmail.com";
            if (IsEmailAddress(emailAddress))
                Console.WriteLine("TEST PASSED: " + mailAddress + " korrekt als Email-Adresse erkannt");
            else
                Console.WriteLine("TEST FAILED: " + mailAddress + " nicht als Email-Adresse erkannt, obwohl korrekt.");

        }
        public static bool IsEmailAddress(string emailAddress)
        {
            int iAt = emailAddress.IndexOf('@');
            int iDot = emailAddress.LastIndexOf('.');
            return (iAt > 0 && iDot > iAt);


        }
    }
}
