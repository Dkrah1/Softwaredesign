using System;

namespace TraceTable_Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please enter a number.");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("From which system do you want to convert?");
        int fromSystem = Int32.Parse(Console.ReadLine());
        Console.WriteLine("To which system to you want to convert?");
        int toSystem = Int32.Parse(Console.ReadLine());

        Console.WriteLine("The result is: " + ConvertNumberFromSystemToSystem(number, fromSystem,toSystem));
        }
        static int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
            {
                int result = 0;
                result = OtherToDecimal(number, fromSystem);
                result = DecimalToOther(result, toSystem);
                return result;
            }

          static  int DecimalToOther(int dec, int system)
            {
                int result = 0;
                int factor = 1;
                while (dec != 0)
                {
                    int digit = dec % system;
                    dec /= system;
                    result += factor * digit;
                    factor *= 10;
                }
                return result;
            }

           static int OtherToDecimal(int other, int system)
            {
                int result = 0;
                int factor = 1;
    while (other != 0)
                {
                    int digit = other % 10;
                    other /= 10;
                    result += factor * digit;
                    factor *= system;
                }
                return result;
            }
    }
}
