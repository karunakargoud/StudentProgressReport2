using StudentProgressReport2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentProgressReport2.DAL
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Student");

        }
        public DbSet<Student> Students { get; set; }
    }
}