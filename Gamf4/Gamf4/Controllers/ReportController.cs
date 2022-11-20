using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gamf4.Data;
using Gamf4.Models;
using System.Linq;

namespace Gamf4.Controllers
{
	public class ReportController : Controller
	{
		private readonly GAMFDbContext _context;

		public ReportController(GAMFDbContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

        public IActionResult EnrollmentDateReport()
        {
            var result = _context.Students
                .GroupBy(s => s.EnrollmentDate)
                .Select(s => new EnrollmentDateVM {
                    EnrollmentDate = s.Key,
                    StudentCount = s.Count()
                });


            return View(result.ToList());
        }

        public IActionResult StudentsReport()
        {          
            var result = _context.Students
                .Select(s => new StudentsReportVM {
                    Student = s,
                    CreditsSum = s.Enrollments.Sum(e => e.Course.Credits)
                });

            return View(result.ToList());
        }

    }
}

