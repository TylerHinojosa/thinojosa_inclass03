using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinojosa_inclass03
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tyler";
            string lastName = "Hinojosa";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            string fullName = firstName + " " + lastName;

            Console.WriteLine("My name is " + fullName + ".");

            string output1 = "My name is " + firstName + " " + lastName + ".";
            string output2 = String.Format("My name is {0} {1}. ", firstName, lastName);
            string output3 = String.Format($"My name is {firstName} {lastName}.");

            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);

            string profName = "Prof. M.";

            int myAge = 29;
            int profAge = 40;

            Console.WriteLine("{0, 30} | {1 , 5}.", fullName, myAge);
            Console.WriteLine("{0, 30} | {1 , 5}.", profName, profAge);
            Console.WriteLine("{0, -30} | {1 , -5}.", fullName, myAge);
            Console.WriteLine("{0, -30} | {1 , -5}.", profName, profAge);

            double number = 321.654;

            Console.WriteLine("The number is {0, 10}.", number.ToString("C"));

            Console.WriteLine("My name is {0} characters long.", fullName.Length);
            Console.WriteLine("The second and third characters of my name are {0}.", fullName.Substring(1, 2));

            Console.Write("Enter some string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Your input was \"{0}\".", input);

            Console.Write("Enter some numberic data: ");
            string strNumber1 = Console.ReadLine();
            int intNumber1 = Int32.Parse(strNumber1);

            Console.Write("Enter some more numeric data: ");
            int intNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", intNumber1, intNumber2, intNumber1 + intNumber2);
            Console.WriteLine("{0} - {1} = {2}", intNumber1, intNumber2, intNumber1 + intNumber2);
            Console.WriteLine("{0} * {1} = {2}", intNumber1, intNumber2, intNumber1 + intNumber2);
            Console.WriteLine("{0} / {1} = {2}", intNumber1, intNumber2, intNumber1 + intNumber2);
            Console.WriteLine("{0} % {1} = {2}", intNumber1, intNumber2, intNumber1 + intNumber2);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } 
    }
}
