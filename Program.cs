using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store instances of the Student class
            List<Student> studentList = new List<Student>();



            // Create and add several instances of the Student class to the list
            studentList.Add(new Student("Elene", "Rtveladze", new DateTime(2002, 5, 9), 'F', "Caucasus University", "Information Technology", "Programmer", 4));
            studentList.Add(new Student("Mariam", "Vadachkoria",new DateTime(2002, 7, 22), 'F', "Caucasus University", "Information Technology", "Programmer", 4));
            studentList.Add(new Student("Rati", "Kunchulia", new DateTime(2002, 5, 9), 'M', "Free University", "Computer Science", "Programmer", 2));


            // Print information for each student in the list
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(); // Add a newline for better readability
            }
            Console.ReadLine();
        }
    }
}
