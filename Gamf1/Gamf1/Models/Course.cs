using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gamf1.Models
{
	public class Course
	{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Course()
		{
            //
		}
	}
}

