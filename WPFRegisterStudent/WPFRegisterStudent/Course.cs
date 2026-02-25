// Name: Giovanni Santiago
// Course: IT-230 C# Programming
// Date: 02/13/2026
// Instructor: Dr. Steve Satterfield

// Santiago_Giovanni_createclassobjectives
//
// Directions: 
// This program  was suppose to enable students to register for courses in a term of study.
// The students select from a menu of courses for which they wish to register.
// the original code had bugs I was tasked to squash them the errors, so
// that the program runs and produces the required output for options
// selected by a student.
// 
// When selecting the program does not properly calculate the credits being used, it just showed the courses lets 
// the user select courses but does not stope at 3 and still adds coureses that where already selected. Debuggin while makeing a class and a .json
// file to help with storing the credits and courses makeing a choice method  
// 
//

using System;

namespace WPFRegisterStudent

{


    public class Course // changed from internal to public
    {

        private string name; // name of course
        private const Int16 credit_hours = 3; // credits for course
        private bool isRegisteredAlready = false; // checks for if course was already picked
       
        // perameterized constructor helps to create objects from data feeds
        public Course()
        {
            this.name = ""; //course names
        }


        // perameterized constructor helps to create objects from data feeds

        public Course(string name)
        {
            this.name = name; // name of course
        }


        // accessors and mutators\

        public string Name
        {
            get
            {
                // check users security role
                // to verify user has permission
                return this.name;
            }

            set
            {
                //validates the incoming
                // information to verify that it conforms to rules or does not
                this.name = value;


            }
        }

        public bool IsAlreadyRegistered
        {
            get { return this.isRegisteredAlready; }// getter 
            set { this.isRegisteredAlready = value; }//setter

        }

        public void SetToRegistered()// 
        {
            this.IsAlreadyRegistered = true;// is already registered for course

        }

        public Int16 Credit_hours
        {
            get { return credit_hours; } //returned credit hours from constant 
        }

        override public string ToString()
        {
            return this.name; // names of courses 


        }

    }
}
