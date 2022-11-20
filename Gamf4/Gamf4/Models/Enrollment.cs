using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Gamf4.Models
{
    public enum Grade { A, B, C, D, F }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        [Display(Name = "Kurzus")]
        public int CourseId { get; set; }

        [Display(Name = "Hallgató")]
        public int StudentId { get; set; }

        [Display(Name = "Jegy")]
        public Grade? Grade { get; set; }

        [Display(Name = "Kurzus")]
        public virtual Course Course { get; set; }

        [Display(Name = "Hallgató")]
        public virtual Student Student { get; set; }

        public Enrollment()
        {
        }
    }
}

