
using System;

namespace Lab2Console
{//Brendan Hannon CPS 3330-01 SPRING 2023 Lab #2
    class Program
    {
        static int checkVals(string question)
        {
            Console.WriteLine(question);
            while (true)
            {
                String a = Console.ReadLine();
                int value;
                if (int.TryParse(a, out value))
                    return value;
                else
                    Console.WriteLine("invalid input");
            }
        }
        static void Main(string[] args)
        {
            int inputVal = checkVals("Will you enter two or three integers?");
            if ((inputVal < 2) || (inputVal > 3))
            {
                Random rnd = new Random();
                inputVal = rnd.Next(2, 4);
                Console.WriteLine("Okay I'll choose for you " + inputVal);
            }

            int valueA = checkVals("Enter value for 'a' and press enter: ");
            int valueB = checkVals("Enter value for 'b' and press enter: ");
            int minVal = Lab2Lib.Class1.min(valueA, valueB);

            if (inputVal == 3)
            {
                int valueC = checkVals("Enter value for 'c' and press enter: ");
                minVal = Lab2Lib.Class1.min(valueA, valueB, valueC);
                Console.WriteLine("Min value is: " + minVal);
            }
            else
            {
                Console.WriteLine("Min value is: " + minVal);
            }
            //Brendan Hannon CPS 3330-01, Spring 2023, Lab #2
        }
    }
}
