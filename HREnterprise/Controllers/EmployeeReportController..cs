using HREnterprise.Data;
using Microsoft.AspNetCore.Mvc;

namespace HREnterprise.Controllers
{
    public class EmployeeReportController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeReportController(ApplicationDbContext context) => _context = context;

        public IActionResult Index()
        {
            var data = _context.Employees
                .GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, Count = g.Count() })
                .ToList();

            return View(data);
        }
    }

}
