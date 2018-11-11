using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {


            var personOne = new Person
            {
                FirstName = "Nathan",
                LastName = "Drake",
                Age = 35
            };

            var personTwo = new Person
            {
                FirstName = "Sonic",
                LastName = "the Hedgehog",
                Age = 15
            };

            var personThree = new Person
            {
                FirstName = "Joel",
                LastName = "Millers",
                Age = 45
            };

            var personFour = new Person
            {
                FirstName = "Dominik",
                LastName = "Krahwinkel",
                Age = 24
            };

            var personFive = new Person
            {
                FirstName = "Sherlock",
                LastName = "Holmes Jr",
                Age = 14
            };

            Person[] personArray = new Person[]
            {
                personOne,
                personTwo,
                personThree,
                personFour,
                personFive
            };


            UnderTwenty(personArray);



        }
        public class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;

            public override string ToString()
            {
                return "Person: " + FirstName + ", " + LastName + ", " + Age;
            }
        }

        public static void UnderTwenty(Person[] personArray)
        {
            for(int i = 0; i<personArray.Length;i++)
            {
                if(personArray[i].Age >=20) //Ich greife auf die Stelle [i] zu mit den Eigenschaften von Age
                {
                    Console.WriteLine(personArray[i].ToString()); //Ich greife auf alle Personen zu die über 20 sind personArray[i] 
                }                                                 //und ich muss auf die Methode zugreifen die mir die Person ausgibt also ToString()
                
            }
        }
    }
}
