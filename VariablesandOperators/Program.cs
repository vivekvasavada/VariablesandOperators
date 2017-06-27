using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mike";
            Console.WriteLine(firstName);
            //Printing the value of birthMonth to the console
            string birthMonth = "March";
            Console.WriteLine(birthMonth);





            


            int age = 65;
            string why = "because I said so";
            char firstInitial = 'V';

            float floatnumber = 2.16440330489729484938361032f;
            Console.WriteLine(floatnumber);

            double doublenumber = 2.16440330489729484938361032d;
            Console.WriteLine(doublenumber);

            decimal decimalNumber= 2.16440330489729484938361032m;
            Console.WriteLine(decimalNumber);

            int jessicaAge = 27;
            int samAge = 42;
            Console.WriteLine(jessicaAge < samAge);



            Console.WriteLine("what is the name on reservation");
            string reserveName = Console.ReadLine();
           
            Console.WriteLine("how many people in the party");
            int numberpeople = int.Parse(Console.ReadLine());

            


            
           
            
        }
    }
}
