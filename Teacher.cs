using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_teacher_application
{
    internal class Teacher : Student
    {
        string Subject;

        /*
          Constructor for creating a Teacher object
          This constructor initializes a new Teacher instance by passing parameters to the base Student class constructor, also sets the Teacher's specific 'Subject' field
        */
        public Teacher(int studenntId, string firstName, string lastName, double grade, string subject)
            : base(studenntId, firstName, lastName, grade) // Calls the constructor of the base class (Student) with provided parameters.
        {
            Subject = subject;
        }

        // Method to display teaching activity
        public void Teach()
        {
            Console.WriteLine($"Mr./Ms. {LastName} is teaching {Subject}");
        }
    }
}
