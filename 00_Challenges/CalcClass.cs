using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    class Calculator
    {
        public double GetSum(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            return sumSolution;
        }

        public double GetDiff(double numOne, double numTwo)
        {
            double diffSolution = numOne - numTwo;
            return diffSolution;
        }

        public double GetMult(double numOne, double numTwo)
        {
            double multSolution = numOne * numTwo;
            return multSolution;
        }

        public double GetDiv(double numOne, double numTwo)
        {
            double divSolution = numOne / numTwo;
            return divSolution;
        }
    }
}
