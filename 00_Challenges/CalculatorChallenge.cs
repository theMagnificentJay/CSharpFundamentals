using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class CalculatorChallenge
    {
        /*
         Create a Calculator class that has the ability to complete all of the following processes, each taking in two number inputs:
            DONE - Add
            DONE - Subtract
            DONE - Multiply
            DONE - Divide
            DONE - Write Unit Tests for all of your calculator's functionalities.

 

         Bonus Challenges:

           DONE - Allow use of whole numbers and numbers with decimals
            - Have the ability to return fractions or percentages instead of decimals
            - Allow the calculator to take in as many numbers as the user provides
         */

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            Console.WriteLine("Get Sum:");
            double sum = calculatorInstance.GetSum(4.3, 6.2);
            Console.WriteLine(sum);

            Console.WriteLine("Get Diff:");
            double diff = calculatorInstance.GetDiff(7.6, 3.1);
            Console.WriteLine(diff);

            Console.WriteLine("Get Mult:");
            double mult = calculatorInstance.GetMult(5.3, 3.2);
            Console.WriteLine(mult);

            Console.WriteLine("Get Div:");
            double div = calculatorInstance.GetDiv(10.6, 2.2);
            Console.WriteLine(div);
        }
    }
}
