using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class StudentOrInstructor
    {
        [TestMethod]
        public void StudentOrInstructorTests()
        {
            Student studentOne = new Student();
            Instructor instructorOne = new Instructor(1);
        }
    }
}
