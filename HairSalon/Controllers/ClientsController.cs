using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using HairSalon.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace HairSalon.Controllers;
public class ClientsController : Controller
{
  private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

  public ActionResult Create(int employeeId)
  {
    var client = new Client { EmployeeId = employeeId };
    return View(client);
  }

  [HttpPost]
  public ActionResult Create(Client client)
  {
    if (ModelState.IsValid)
    {
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Show", "Employees", new { id = client.EmployeeId });
    }
    return View(client);
  }
}