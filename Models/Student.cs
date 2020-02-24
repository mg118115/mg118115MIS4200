using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mg118115MIS4200.Models
{
    public class Student
    {
        [Display(Name = "Student Name")]

        public int studentId { get; set; }
        [Display (Name ="First Name")]
        [Required(ErrorMessage ="Student first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display (Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display (Name = "Email Address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most used email address")]
        public string email { get; set; }
        [Display (Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }

        public string fullName { get { return lastName + ", " + firstName; } }
        public ICollection<Enrollment> Enrollment { get; set; } 
    }

    public class Enrollment
    {
     [Key]
       public int EnrollmentId { get; set; }

        [Display(Name = "Enrolled Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        [Required(ErrorMessage = "Enrollment date is required")]
        public DateTime enrolledSince { get; set; }

        [Display(Name = "Enrollment Description")]
        [Required(ErrorMessage = "Enrollment description is required")]
        [StringLength(100)]
        public string description { get; set; }
        [Display(Name = "Student Name")]
        public int studentId { get; set; }
        public virtual Student Student { get; set; }

        [Display(Name = "Class Name")]
        public int classId { get; set; }

        public virtual Class Class { get; set; }

    }

    public class Class
    {
        [Display(Name = "Class Name")]

        public int classId { get; set; }

        [Display(Name = "Class Title")]
        [Required(ErrorMessage = "Class title is required")]
        [StringLength(20)]
        public string classTitle { get; set; }

        [Display(Name = "Class Description")]
        [Required(ErrorMessage = "Class description is required")]
        [StringLength(100)]
        public string description { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }
    }
}