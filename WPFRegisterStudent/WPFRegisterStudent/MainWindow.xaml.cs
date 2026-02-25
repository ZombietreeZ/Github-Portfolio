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
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Course choice; // course choice when person clicks on choice
        private const int max_credit_hours = 9; // max hours that can be used
        private int registeredCreditHours = 0; // hours that are registered so far
        private string courseNames = "IT 145,IT 200,IT 201,IT 270,IT 315,IT 328,IT 330"; //course names in a string that get split into different choices
        private Dictionary<string, Course> available_courses = new Dictionary<string, Course>(); // storing the courses from the dictinary 




        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] arrCourseNames = courseNames.Split(','); // splitting up the strings in the course names 
            foreach (string courseName in arrCourseNames) // for each course name make it so they have theitr own box 
            {
                available_courses.Add(courseName, new Course(courseName)); // courses that are available
                this.comboBox.Items.Add(courseName); // add them to the combo box

            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = available_courses[this.comboBox.SelectedItem.ToString()]; // choice for button click 

            if (choice.IsAlreadyRegistered) // makes sure the amount of credits pick do not exceedthe alotted amouhnt 
            {
                //this course already registered
                this.lblRegistrationStatus.Foreground = Brushes.Red; // turning letters red
                //print out message
                this.lblRegistrationStatus.Content = String.Format("You have Already registered for course {0}.", choice.Name);

            }
            else
            {
                if (this.registeredCreditHours >= max_credit_hours) // makes sure the amount of credits pick do not exceedthe alotted amouhnt 
                {
                    // can not register for a 4th course 
                    this.lblRegistrationStatus.Foreground = Brushes.Red; // turning letters red
                    // print out message
                    this.lblRegistrationStatus.Content = String.Format("You can not register for more than {0} credit hours.", max_credit_hours);

                }
                else
                {
                    this.registeredCreditHours += choice.Credit_hours; // equation for credit hours
                    this.listBox.Items.Add(choice.Name); // list of items in course box
                    choice.SetToRegistered(); // setting the choices made into the course box then add them up
                    this.txtTotalHoursRegistered.Text = Convert.ToString(this.registeredCreditHours); // converting total hour to string txt 
                    this.lblRegistrationStatus.Foreground = Brushes.DarkBlue; // changeing color of message

                    this.lblRegistrationStatus.Content = String.Format("Registration Confirmed You have registered for {0} credit hours.", registeredCreditHours);

                }
            }
        }

    }
}
