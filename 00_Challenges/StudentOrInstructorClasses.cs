using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseType { CyberSecurity, SoftwareDevelopment, WebDevelopment }
    public enum BadgeType { Student, Instructor }


    public class Student
    {
        public Student() { }

        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, decimal balanceOwed, BadgeType typeOfBadge, bool hasGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            ClassType = classTaking;
            BalancedOwed = balanceOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public CourseType ClassType { get; set; }
        public decimal BalancedOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }
    }

    public enum CourseTaught { CyberSecurity, SoftwareDevelopment, WebDevelopment }
    public class Instructor
    {
        public Instructor(int employeeNumber) 
        {
            EmployeeNumber = employeeNumber;
        }
        public Instructor(string firstName, string lastName, DateTime dateOfBirth, int employeeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            EmployeeNumber = employeeNumber;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int EmployeeNumber { get; set; }
    }
}
