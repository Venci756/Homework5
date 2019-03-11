using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number of students.");
            string numberOfStudents = Console.ReadLine();
            bool numbersInput = int.TryParse(numberOfStudents, out int number);

            Student[] myArray = new Student[2];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter the name of the student");
                string nameOfStudent1 = Console.ReadLine();

                Console.WriteLine("Enter the last name of the student");
                string lastNameOfStudent1 = Console.ReadLine();

                Console.WriteLine("Enter year of birth.");
                bool howManyYears1 = int.TryParse(Console.ReadLine(), out var year1);
                Console.WriteLine("Enter month of birth.");
                bool howManyMonths1 = int.TryParse(Console.ReadLine(), out var month1);
                Console.WriteLine("Enter day of birth.");
                bool howManyDays1 = int.TryParse(Console.ReadLine(), out var day1);
                DateTime date1 = new DateTime(year1, month1, day1);

                //Student student = new Student(nameOfStudent1, lastNameOfStudent1, date1);
                myArray[i] = new Student(nameOfStudent1, lastNameOfStudent1, date1);
               


            }
            foreach (var item in myArray)
            {
                Console.WriteLine(item.FirstName + item.LastName+item.DateOfBirth);
                
            }
           
            
            StudentsArray.GetLongestLastName(myArray);
            StudentsArray.GetLongestName(myArray);
            StudentsArray.getAverageLengthOfNamesAndLastNames(myArray);
            StudentsArray.GetShortestName(myArray);
            StudentsArray.GetShortestName(myArray);
            StudentsArray.getOldest(myArray);
            StudentsArray.getYoungest(myArray);
            

        }

    }
}
    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime DateOfBirth { get; set; }

    //    public Student(string firstName,string lastName,DateTime dateOfBirth)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        DateOfBirth = dateOfBirth;
    //        dateOfBirth = new DateTime();
    //    }
       
    //}
    //public class ArrayOfStudents
    //{
    //    Student[] arrayOfStudents = new Student[5] ;
        

    //   void GetLongestName()
    //    {
    //        string longestName = "";
    //        for (int i = 0; i < arrayOfStudents.Length; i++)
    //        {
    //            if (arrayOfStudents[i].FirstName.Length > longestName.Length)
    //            {
    //                longestName = arrayOfStudents[i].FirstName;

    //            }
    //        }
    //        Console.WriteLine($"The student with the longest name is ${longestName}");
    //    }
    //    void GetLongestLastName()
    //    {
    //        string longestLastName = "";
    //        for (int i = 0; i < arrayOfStudents.Length; i++)
    //        {
    //            if (arrayOfStudents[i].FirstName.Length > longestLastName.Length)
    //            {
    //                longestLastName = arrayOfStudents[i].FirstName;

    //            }
    //        }
    //        Console.WriteLine($"The student with the longest last name is ${longestLastName}");
    //    }

    //    void GetShortestName()
    //    {
    //        string shortestName = arrayOfStudents[0].FirstName;
    //        for (int i = 0; i < arrayOfStudents.Length; i++)
    //        {
    //            if (arrayOfStudents[i].FirstName.Length < shortestName.Length)
    //            {
    //                shortestName = arrayOfStudents[i].FirstName;

    //            }
    //        }
    //        Console.WriteLine($"The student with the shortest name is ${shortestName}");
    //    }

    //    void GetShortestLastName()
    //    {
    //        string shortestLastName = arrayOfStudents[0].LastName;
    //        for (int i = 0; i < arrayOfStudents.Length; i++)
    //        {
    //            if (arrayOfStudents[i].LastName.Length < shortestLastName.Length)
    //            {
    //                shortestLastName = arrayOfStudents[i].LastName;

    //            }
    //        }
    //        Console.WriteLine($"The student with the shortest last name is ${shortestLastName}");
    //    }

    //    void getAverageLengthOfNamesAndLastNames()
    //    {
    //        int sumOfAverageNames = 0;
    //        int sumOfAverageLastNames = 0;
    //        int averageName = 0;
    //        int averageLastName = 0;
    //        for (int i = 1; i < arrayOfStudents.Length; i++)
            
    //        {
    //            sumOfAverageNames = averageName + arrayOfStudents[i].FirstName.Length;
    //            sumOfAverageLastNames=averageLastName+ arrayOfStudents[i].LastName.Length;
    //        }
    //        float calculatedAverageOfNames = sumOfAverageNames / 5;
    //        float calculatedAverageOfLastNames = sumOfAverageNames / 5;
    //        Console.WriteLine($"The average length of names is {calculatedAverageOfNames}");
    //        Console.WriteLine($"The average length of  last names is {calculatedAverageOfLastNames}");
    //    }

    //}

//}