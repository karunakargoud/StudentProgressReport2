using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentProgressReport2.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId {  get; set; }

        [Required(ErrorMessage ="Empty Student Name is not Allowed")]
        [MaxLength(50,ErrorMessage ="Student Name should be less than 50")]
        [MinLength(4,ErrorMessage ="Student Name should be atleast 4 letters")]
        public string StudentName {  get; set; }

        [Required(ErrorMessage ="Empty class is not allowed")]
        [MinLength(3,ErrorMessage ="class should be atlest 3 letters")]
        [MaxLength(5,ErrorMessage ="class should be less than 5")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Empty NameOfTheExam is not allowed")]
        [MaxLength(50, ErrorMessage = "Name of the Exam should be less than 50")]
        [MinLength(4, ErrorMessage = "Name of the Exam should be atleast 4 letters")]
        public string NameOfTheExam { get; set; }

        [Range(0,100,ErrorMessage ="Marks should be in between 1 and 100")]
        public int Telugu {  get; set; }
        [Range(0, 100, ErrorMessage = "Marks should be in between 1 and 100")]
        public int Hindi{ get; set; }
        [Range(0, 100, ErrorMessage = "Marks should be in between 1 and 100")]
        public int English { get; set; }
        [Range(0, 100, ErrorMessage = "Marks should be in between 1 and 100")]
        public int Maths { get; set; }
        [Range(0, 100, ErrorMessage = "Marks should be in between 1 and 100")]
        public int Science { get; set; }
        [Range(0, 100, ErrorMessage = "Marks should be in between 1 and 100")]
        public int Social { get; set; }


    }
}