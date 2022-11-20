using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Gamf4.Models
{
	public class Course
	{
        [Display(Name = "Kurzus az.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [Display(Name = "Kurzus")]
        [Required(ErrorMessage = "Kurzus kitöltése kötelező!")]
        public string Title { get; set; }

        [Display(Name = "Kredit")]
        [Required(ErrorMessage = "Kredit kitöltése kötelező!")]
        public int Credits { get; set; }

        [Display(Name = "Jelentkezések")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Course()
		{
		}
	}
}

