using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCrudOperation.Data;
using WebAppCrudOperation.Models;

namespace WebAppCrudOperation.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDBContext _context; //ده عشان الداتا بيز 

        public EmployeesController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.Include(x => x.Department).OrderByDescending(x => x.CreatedDate).ToList();

            return View(employees);
        }
        public IActionResult Create()
        {

            ViewBag.Department = _context.Departments.OrderByDescending(x => x.CreatedDate).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee , [FromForm] IFormFile EmployeeImage)
        {
            UploadImage(employee);
         
            if (ModelState.IsValid)
            {

                _context.Employees.Add(employee);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Department = _context.Departments.OrderByDescending(x => x.CreatedDate).ToList();
            return View();

        }

        private void UploadImage(Employee employee)
        {
            var file = HttpContext.Request.Form.Files[0];
            var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filestream = new FileStream(Path.Combine("wwwroot/images", ImageName), FileMode.Create);
            file.CopyTo(filestream);
            employee.EmployeeImage = ImageName;
        }
    }
}
