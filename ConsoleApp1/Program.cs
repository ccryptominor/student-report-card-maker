using System;

namespace ConsoleApp1
{
    class Program
    {
   

        static void Main(string[] args)

        { 
            
            string sp = "\n";

            int grade = 11; // The student will enter their grade

            double result = 86.32;

            string name = "Bob";

            string lessons = sp + "Maths" + sp + "Physics" + sp + "Chemistry" + sp + "PE" + sp + "English" + sp + "Biology";

            Console.WriteLine("The school report of " + name + " will include the information below:\n\nTheir total GPA which is: " + result + " \n\nWhich grade they went to: " + grade + "\n\nFinal exam results from the lessons below: " + lessons);

            Console.ReadKey();
        }
    }
}