using EFDBfirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFDBfirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeControllers : ControllerBase
    {
        private readonly NorthwindContext _dbContext;


        public EmployeeControllers(NorthwindContext dbNorthWindContext)
        {
            _dbContext = dbNorthWindContext;
        }

        //[HttpGet(Name = "ProductsDetails")]
        //public IEnumerable<dynamic> Get()
        //{
        //    return _dbContext.Categories.ToList();
        //}

        [HttpGet]
        public IActionResult getEmploye() {

            var empList = _dbContext.Employees.ToList();
            
            return Ok(empList);

        }

        [HttpGet("EmployeeId")]
        public ActionResult Getbyid(int EmployeeId)
        {
            if (EmployeeId <= 0)
                return NotFound("not found");

            var employeedata = _dbContext.Employees.Find(EmployeeId);

            return employeedata!= null ? Ok(employeedata) : BadRequest();



        }

    }
}
