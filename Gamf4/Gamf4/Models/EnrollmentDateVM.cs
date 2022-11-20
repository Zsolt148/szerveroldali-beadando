using System;
namespace Gamf4.Models
{
	public class EnrollmentDateVM
	{
        public DateTimeOffset EnrollmentDate { get; set; }
        public int StudentCount { get; set; }

        public EnrollmentDateVM()
		{
		}
	}
}

