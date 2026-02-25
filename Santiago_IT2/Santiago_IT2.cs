// Name: Giovanni Santiago
// Course: IT-230 C# Programming
// Date: 02/06/2026
// Instructor: Dr. Steve Satterfield

// Lastname_firstname_ consoleregisterstudent
//
// Directions: The ConsoleRegisterStudent Visual Studio project file contains
// source code for a console program that compiles and runs but does not produce
// the required results.
// The program enables students to register for courses in a term of study.
// Students select from a menu of courses for which they wish to register.
// To complete Part I of the final project, you must debug and fix the
// errors in the Console Register Student Visual Studio project so
// that the program runs and produces the required output for options
// selected by a student. Once fixed, the program output should work as
// shown in the ConsoleRegisterStudent fixed video in the Supporting
// Materials section below. Rather than showing a still image, the video
// demonstrates the interaction between the application and the user.
// Console Register Student Software Requirements List

// The program uses the following assumptions:
// The student enters only integers to select courses for registration.
// No validation of the type of user input (e.g., Is it a string?) is
// checked or required.
// Each course carries three credit hours.
// The program terminates only when the student requires it.
// The program must follow these registration business rules:
// No registration of other courses not displayed by the program
// No registration more than once for the same course
// No registration for more than nine credit hours (e.g., no more than three courses)
// The program validates the user integer menu selection. If the selection is valid, the
// program registers the student for the selected course. Otherwise, the program outputs
// an error message. The program then outputs the current list of registered classes and
// asks the user if they want to register for another course.
// To complete this activity, download the ConsoleRegisterStudent.zip file linked in
// Supporting Materials below. Then use the source code in the ConsoleRegisterStudent.zip
// file and the Console Register Student Software Requirements List to review and repair
// the existing source code so that the program runs and produces the required results.
// Once fixed, the program should produce output like that shown in the Console Register Student Fixed video. You must appropriately use the modifications below to repair the Console Register Student source code.
//
//
//Specifically, you must address the following rubric criteria:
//

// Modify Variables: Modify applicable variable declarations and data type references.
// Modify Math Operations: Modify applicable C# code containing math operations so there are no syntax or computation errors.
// Modify Control Structures: Modify applicable control structures to include branching and loops.
// Modify Boolean Code: Modify applicable C# code to ensure Boolean logic is accurately coded.
// Modify Classes and Methods: Modify applicable classes and methods to ensure they are free of syntax and logic errors.
//
// Error Handling:
// I was able to find the first error the Writepromt() had an uppercase P instead of a lowercase p.
// The second error was in the ReadChoice() method where I needed to convert the string input to an integer using int.Parse(s).
// The third error was in the WriteChoice() method where I needed to add an int parameter to accept the choice value and also
// lowercase the choice variable in the Console.WriteLine statement.
// the fourth error i found adding an int variable in front of choice to turn the int variable into a parameter. 
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santiago_IT2

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []"); // promt user to select a course
            Console.WriteLine(" [1]IT 145 \n [2]IT 200 \n [3]IT 201 \n [4]IT 270 \n [5]IT 315 \n [6]IT 328 \n [7]IT 330"); // Write promt to user 
            string input = Console.ReadLine();

            int choice = int.Parse(Console.ReadLine());


            string course = "";

            switch (choice)
            {
                case 1: course = "IT 145"; break; // 
                case 2: course = "IT 200"; break; //
                case 3: course = "IT 201"; break;
                case 4: course = "IT 270"; break;
                case 5: course = "IT 315"; break;
                case 6: course = "IT 328"; break;
                case 7: course = "IT 330"; break;

                default:
                    Console.WriteLine("invalid input.");
                    return;
            }

            Console.WriteLine("Your choice of " + choice + " is this course " + course);


        }


        int ReadChoice()
        {
            string s = ""; // initialize string variable s
            s = Console.ReadLine(); // read user input from console
            return int.Parse(s); // need to convert string to int using int.Parse(s)

        }

    }
}