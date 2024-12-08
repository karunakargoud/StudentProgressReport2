using StudentProgressReport2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProgressReport2.VM
{
    public class StudentVM
    {
        public Student student;
        public List<Student> students;
        public int Total;
        public string Result;
        public string Grade;
        public int Average;
        public string ColorName;
        public StudentVM(Student s)
        {
            student = s;
            Total = student.Telugu + student.Hindi + student.English + student.Maths + student.Science + student.Social;
            Result = "Fail";
            if (student.Telugu >= 35 && student.Hindi >= 35 && student.English >= 35 && student.Maths >= 35 && student.Science >= 35 && student.Social >= 35)
            {
                Result = "Pass";
            }
            Grade = "F";
            if(Result== "Pass")
            {

                int p = Total / 6;
                if (p >= 90)
                {
                    Grade = "A+";
                    ColorName = "SkyBlue";
                }
                else if (p >= 80)
                {
                    Grade = "A";
                    ColorName = "LightGreen";
                }
                else if (p >= 70)
                {
                    Grade = "B";
                    ColorName = "LightCoral";
                }
                else if (p >= 60)
                {
                    Grade = "C";
                    ColorName = "Purple";
                }
                else if (p >= 50)
                {
                    Grade = "D";
                    ColorName = "LightYellow";
                }
                else if (p >= 35)
                {
                    Grade = "E";
                    ColorName = "LightCyan";
                }


            }
            else
            {
                ColorName = "red";
            }
            Average = Total / 6;
            if (Result == "Pass")
            {
                ColorName = "green";
            }
            else
            {
                ColorName = "red";
            }
        }
    }
}