using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool isEqual = (age == 41); // is false bc 25 != 41

            bool userIsJay = userName == "Jay";

            //Console.WriteLine(userIsJay);
            //Console.WriteLine(isEqual);

            bool isNotEqual = age != 23;
            //Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList);
            //Console.WriteLine(listsAreEqual);

            bool isGreatThan = age > 36;
            Console.WriteLine(isGreatThan); // false

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan); // true

            bool isGreaterOrEqual = age >= 41;
            Console.WriteLine(isGreaterOrEqual); // false

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = (isTrue == true && isFalse == true); // Value would be false bc isFalse != true

            bool anotherAndValue = (age == 25 && userName == "Jacob"); // true
            bool orValue = (age == 25 || userName == "Jay"); // true
        }
    }
}
