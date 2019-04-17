using System;
using System.Collections.Generic;

namespace AbstractAndInterfaceClassExample
{
    class Student : Person, IGrades
    {

        private List<double> grades;

        private string gpa;

        private string major;

        public string Major
        {
            get { return major; }
            set { major = value; }
        }


        public Student(
            string firstName,
            string lastName,
            string streetAddress,
            string city,
            string state,
            string zipCode,
            string phone,
            string major
            ) : base(
                firstName,
                lastName,
                streetAddress,
                city,
                state,
                zipCode,
                phone
                )
        {
            Major = major;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public String CalculateGPA()
        {
            gpa = "No grades have been entered yet, so there is no GPA available.";
            if (grades.Count > 0)
            {
                double sum = 0.0;
                double avg = 0.0;
                for (int i = 0; i < grades.Count; i++)
                {
                    sum += grades[i];
                }
                //https://pages.collegeboard.org/how-to-convert-gpa-4.0-scale
                avg = sum / grades.Count;
                if (avg > 92)
                    gpa = "4.0";
                else if (avg > 89)
                    gpa = "3.7";
                else if (avg > 86)
                    gpa = "3.3";
                else if (avg > 82)
                    gpa = "3.0";
                else if (avg > 79)
                    gpa = "2.7";
                else if (avg > 76)
                    gpa = "2.3";
                else if (avg > 72)
                    gpa = "2.0";
                else if (avg > 69)
                    gpa = "1.7";
                else if (avg > 66)
                    gpa = "1.3";
                else if (avg > 64)
                    gpa = "1.0";
                else
                    gpa = "0.0";
            }
            return gpa;
        }

        public String GetStudentInfo()
        {
            CalculateGPA();
            String student = "Student ID: " + PID + "\n" +
                "Name: " + FirstName + " " + LastName + "\n" +
                "Address: " + StreetAddress + ", " + City + ", " + State + ", " + ZipCode + "\n" +
                "Phone: " + Phone + "\n" +
                "GPA: " + gpa + "\n\n";
            return student;
        }

    }
}
