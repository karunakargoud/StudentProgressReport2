using StudentProgressReport2.DAL;
using StudentProgressReport2.Models;
using StudentProgressReport2.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProgressReport2.Controllers
{
    public class StudentController : Controller
    {
        public StudentContext context = null;

        public StudentController() : base()
        {
            context = new StudentContext();
        }
        public ActionResult EnterNewStudent()
        {
            Student st=new Student();
            StudentVM svm = new StudentVM(st);
            svm.students = context.Students.ToList();
            return View(svm);
        }
        [HttpPost]
        public ActionResult SaveStudentDetails(Student student)
        {
            
            StudentVM svm = new StudentVM(student);
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                List<Student> slist = context.Students.ToList();
                svm.students = slist;
                return View("EnterNewStudent", svm);
            }
            else
            {
                svm.student = student;
                svm.students = context.Students.ToList();
                return View("EnterNewStudent", svm);
            }
        }
        
    }
}

