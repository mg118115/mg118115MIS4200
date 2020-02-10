using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mg118115MIS4200.Models
{
    public class Student
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; } 
    }

    public class Enrollment
    {
     [Key]
       public int EnrollmentId { get; set; }

        public DateTime enrolledSince { get; set; }

        public string description { get; set; }

        public int studentId { get; set; }
        public virtual Student Student { get; set; }

        public int classId { get; set; }

        public virtual Class Class { get; set; }

    }

    public class Class
    {
        public int classId { get; set; }

        public string classTitle { get; set; }

        public string description { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }
    }
}