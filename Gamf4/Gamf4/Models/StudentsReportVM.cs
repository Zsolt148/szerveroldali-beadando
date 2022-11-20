using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Gamf4.Models
{
	public class StudentsReportVM
	{
        public Student Student { get; set; }
        public int CreditsSum { get; set; }

		public StudentsReportVM()
		{
		}
	}
}

