using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_teacher_application
{
    internal class Student
    {
        // Private fields are not directly accessible outside this class.
        // Use public properties to get or set their values.
        int studentId;
        string firstName;
        string lastName;
        double grade;

        // Public properties provide controlled access to the private fields.
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double Grade
        {
            get { return grade; }
            set
            {
                // Validation within the property ensures the grade is within a valid range.
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    // Throws an ArgumentOutOfRangeException with a specified error message if the grade value is not between 0 and 100.
                    throw new ArgumentOutOfRangeException(nameof(Grade), "Grade must be between 0 and 100.");
                }
            }
        }

        // Default constructor initializes fields with default values.
        public Student()
        {
            studentId = -1;
            firstName = "Not Assigned";
            lastName = "Not Assigned";
            grade = 0.0;
        }

        // Parameterized constructor
        public Student(int studentId, string firstName, string lastName, double grade)
        {
            StudentId = studentId; // Using properties ensures validation and encapsulation
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        // Method to display student details, demonstrating the use of properties to access private fields.
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"ID: {StudentId}, Name: {FirstName} {LastName}, Grade: {Grade}");
        }
    }
}
