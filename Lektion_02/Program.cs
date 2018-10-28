using System;

namespace Lektion_02
{
    class Program
    {
            //var i = 42;
            //var pi = 3.1415;
            //var salute = "Hello, World";
        static void Main(string[] args)
        {
            /*var i = 42D;
            var pi = 3.1415;
            var salute = "Hello, World";
            Console.WriteLine(i);
            //Console.WriteLine(pi);
            //Console.WriteLine(salute);

            //Literals für double --> var i = 42D ; für float var pi = 3.1415F; für short  */
        
        
            //Console.WriteLine(Array());
            //Console.WriteLine(String());
            //Console.WriteLine(Verzweigung());
            //Console.WriteLine(SWITCH_CASE());
            //Console.WriteLine(Schleifen());
            Console.WriteLine(FOR());

        }
        //ARRAY
        public static double Array()
        {

        
                /*int[] ia = new int[10];       -->Variablennamen:ia , ca , da | Grundtyp: ia = int [10] , ca = char [30] , da = double [12]
                char[] ca = new char[30];
                double[] da = new double[12];*/

                /*Das initiale Vorbelegen der einzelnen Array-Speicherplätze mit Werten 
                int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6};

                int ergebnis = ia[2] * ia[8] + ia[4]; // --> ergebnis = 13
                return ergebnis; */

                double [] da = {3.14, 2.5937424601, 'C', 34, 2, 5}; //Kempler Konstante angeben? Wie??
                double ergebnis = da[2];

                Console.WriteLine(da.Length);

                return ergebnis; 
                
        }          
        public static bool String() //Wenn ein String zurückgibt, dann static string, wenn bool dann static bool
        {
            //string meinString = "Dies ist ein String";

            /*string a = "Dies ist ";
            string b = "ein String";
            string c = a + b;
            */

            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);
            
            return a_eq_c;
            
        }

        public static string Verzweigung() //wie kann ich gewährleisten, das ich die Methode ausführen kann ohne einen Rückgabewert?
        {
         Console.WriteLine("Please enter a number");
         int a = int.Parse(Console.ReadLine());
         Console.WriteLine("Please enter a second number");
         int b = int.Parse(Console.ReadLine());
            if(a > 3 && b == 6)
            {
                Console.WriteLine("You're the Winner");
            }
            else
            {
                Console.WriteLine("Sorry Loser!!");
            }
            return "Again!! You can win 10.000 Euro";
        }

        public static int SWITCH_CASE()
        {
            /*int i = int.Parse(Console.ReadLine());
                switch (i)
                        {
                        case 1:
                            Console.WriteLine("Du hast EINS eingegeben");
                            break;
                        case 2:
                            Console.WriteLine("ZWEI war Deine Wahl");
                            break;
                        case 3:
                            Console.WriteLine("Du tipptest eine DREI");
                            break;
                        case 4:
                             Console.WriteLine("4 nimm dir ein Bier");
                            break;    
                        default:
                            Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                            break;
                        }
                return i;*/

                int z = int.Parse(Console.ReadLine());
                    if (z == 1)
                    {
                        Console.WriteLine("Du hast eine EINS eingegeben YEAH");
                    }
                    else
                    {
                        if(z == 2)
                        {
                            Console.WriteLine("ZWEI war Deine Wahl");
                        }
                        else
                        {
                            if(z == 3)
                            {
                                Console.WriteLine("Du tipptest eine DREI");
                            }
                            else
                            {
                                if(z > 3)
                                {
                                    Console.WriteLine("Die Zahl " + z + " kenne ich nicht" );
                                }
                            }
                        }
                    }
                return z;


            //Ich habe nicht ganz verstanden, wie man eine Switch/Case mit einem String

                     /*string i = Console.ReadLine();
                        switch (i)
                                {
                                case "1":
                                    Console.WriteLine("Du hast EINS eingegeben");
                                    break;
                                case "2":
                                    Console.WriteLine("ZWEI war Deine Wahl");
                                    break;
                                case "3":
                                    Console.WriteLine("Du tipptest eine DREI");
                                    break;
                                case "4":
                                    Console.WriteLine("4 nimm dir ein Bier");
                                    break;    
                                default:
                                    Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                                    break;
                                }
                        return i;*/
        }

        public static int Schleifen()
        {
            int i = 0;
            while (i <10)
            {
                Console.WriteLine(i);
                i++;
            }
            return i;
        }
        public static string FOR()
        {
              string[] someStrings = 
                    {
                        "Hier",
                        "sehen",
                        "wir",
                        "einen",
                        "Array",
                        "von",
                        "Strings",
                        "Junge Junge"
                    };
                    
                    /*for (int i = 0; i < someStrings.Length; i++) // i < 5
                    {
                        Console.WriteLine(someStrings[i]);
                    }
                    return "YEAH";*/

            /*int x = 0;
            while (x < someStrings.Length )
            {
                Console.WriteLine(someStrings[x]);
                x++;
            }
            return "...";*/


            //do while

             /* int p = 0;
                do                              //Waren die Klammern falsch? 
                {
                    Console.WriteLine(someStrings[p]);
                    p++;
                }
                while (p <someStrings.Length); //warum funktioniert es nicht wenn man "<=" schreibt?
                return "..."; */

        // Schleife mit Break 
          int y = 0;                    /* Wenn ich nicht die anderen Programmblöcke auskommentiere bekomme ich diese Meldung -->
                                        Program.cs(216,11): warning CS0162: Unreachable code detected [/Users/Dome/Documents/GitHub/Softwaredesign/Lektion_02/Lektion_02.csproj]*/
                while (true)
                {
                    Console.WriteLine(someStrings[y]);
                    if (y >= someStrings.Length)
                    break;
                    y++;
                }
            return "mach weiter gleich geschafft";

        }

            
    }
}
