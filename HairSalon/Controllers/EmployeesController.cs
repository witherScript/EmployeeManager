using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using HairSalon.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class EmployeesController : Controller
  {
    private readonly HairSalonContext _db;

    public EmployeesController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Employee> model = _db.Employees.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Employee employee)
    {
      _db.Employees.Add(employee);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Show(int id)
    {
      var employee = _db.Employees.FirstOrDefault(e => e.EmployeeId == id);
      var clients = _db.Clients.Where(c => c.EmployeeId == id).ToList();

      var viewModel = new EmployeeDetailsViewModel
      {
          Employee = employee,
          Clients = clients
      };

      return View(viewModel);

    }
  }
}