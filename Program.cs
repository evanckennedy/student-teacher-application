namespace student_teacher_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! In this application, you will create a student and a teacher.");

            Student student = CreateStudent();
            student.DisplayStudentDetails();

            Teacher teacher = CreateTeacher();
            teacher.DisplayStudentDetails();
            teacher.Teach();
        }

        static Student CreateStudent()
        {
            Console.WriteLine("Let's create a student.");
            int id = ReadIntegerFromConsole("Enter student ID: ");
            string firstName = ReadNameFromConsole("Enter first name: ");
            string lastName = ReadNameFromConsole("Enter last name: ");
            double grade = ReadDoubleFromConsole("Enter grade (0 to 100): ");

            // Create and return the Student object
            return new Student(id, firstName, lastName, grade);
        }

        static Teacher CreateTeacher()
        {
            Console.WriteLine("Now, let's create a teacher.");
            int id = ReadIntegerFromConsole("Enter teacher ID: ");
            string firstName = ReadNameFromConsole("Enter first name: ");
            string lastName = ReadNameFromConsole("Enter last name: ");
            string subject = ReadNameFromConsole("Enter subject: ");

            return new Teacher(id, firstName, lastName, 0.0, subject);
        }

        static int ReadIntegerFromConsole(string promptMessage)
        {
            int result;
            Console.Write(promptMessage);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("The input must be an integer. Please try again.");
                Console.Write(promptMessage);
            }
            return result;
        }

        static string ReadNameFromConsole(string promptMessage)
        { 
            Console.Write(promptMessage);
            string result = Console.ReadLine();
            while (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("The input cannot be empty. Please try again.");
                Console.Write(promptMessage);
                result = Console.ReadLine();
            }
            return result;
        }

        static double ReadDoubleFromConsole(string promptMessage)
        {
            double result = 0.0; // Initialize result to ensure it's always assigned
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(promptMessage);
                if (double.TryParse(Console.ReadLine(), out result) && result >= 0 && result <= 100)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The input must be a valid number. Please try again.");
                }          
            }
            return result;
        }
    }
}
