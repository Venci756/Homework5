using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class StudentsArray

    {
        Student[] ArrayOfStudents = new Student[5];

        
        

        
        public static void GetLongestName(Student [] value)
        {
            string longestName = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].FirstName.Length > longestName.Length)
                {
                    longestName = value[i].FirstName;

                }
            }
            Console.WriteLine($"The student with the longest name is {longestName}");
        }
        public  static void GetLongestLastName(Student[] value)
        {
            string longestLastName = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].FirstName.Length > longestLastName.Length)
                {
                    longestLastName = value[i].FirstName;

                }
            }
            Console.WriteLine($"The student with the longest last name is {longestLastName}");
        }

        public static void GetShortestName(Student[] value)
        {
            string shortestName = value[0].FirstName;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].FirstName.Length < shortestName.Length)
                {
                    shortestName = value[i].FirstName;

                }
            }
            Console.WriteLine($"The student with the shortest name is {shortestName}");
        }

        public static void GetShortestLastName(Student[] value)
        {
            string shortestLastName = value[0].LastName;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].LastName.Length < shortestLastName.Length)
                {
                    shortestLastName = value[i].LastName;

                }
            }
            Console.WriteLine($"The student with the shortest last name is ${shortestLastName}");
        }
        
        public static void getAverageLengthOfNamesAndLastNames(Student[] value)
        {

            int sumOfAverageNames=0;
            int sumOfAverageLastNames=0;
            //int averageName = 0;
            //int averageLastName = 0;
            for (int i = 1; i < value.Length; i++)

            {
               sumOfAverageNames =value[i-1].FirstName.Length+ value[i].LastName.Length;
               sumOfAverageLastNames =value[i-1].LastName.Length+ value[i].LastName.Length;
            }
            //Console.WriteLine(sumOfAverageLastNames);
            float calculatedAverageOfNames = sumOfAverageNames / 2;
            float calculatedAverageOfLastNames = sumOfAverageNames / 2;
            Console.WriteLine($"The average length of names is {calculatedAverageOfNames}");
            Console.WriteLine($"The average length of  last names is {calculatedAverageOfLastNames}");
        }

        public static void getOldest(Student[] value)
        {
            TimeSpan emptySpan = new TimeSpan();
            for (int i = 0; i < value.Length; i++)
            {
                if ((DateTime.Now - value[i].DateOfBirth) > emptySpan)
                {
                    emptySpan = DateTime.Now - value[i].DateOfBirth;
                }

                //if (DateTime.Now - value[i - 1].DateOfBirth) < (DateTime.Now - value[i].DateOfBirth)
                //{
                //    newEmptySpan = DateTime.Now - value[i].DateOfBirth;
                //}
            }
            Console.WriteLine($"The student with the timespan of {emptySpan} is the oldest one.");
        }
        public static void getYoungest(Student[] value)
        {
            TimeSpan emptySpan = new TimeSpan();
            emptySpan = DateTime.Now - value[0].DateOfBirth;
            for (int i = 0; i < value.Length; i++)
            {
                if ((DateTime.Now - value[i].DateOfBirth) < emptySpan)
                {
                    emptySpan = DateTime.Now - value[i].DateOfBirth;
                  
                }

                //if (DateTime.Now - value[i - 1].DateOfBirth) < (DateTime.Now - value[i].DateOfBirth)
                //{
                //    newEmptySpan = DateTime.Now - value[i].DateOfBirth;
                //}
            }
            Console.WriteLine($"The student with the timespan of {emptySpan} is the youngest one.");
        }
    }
}
