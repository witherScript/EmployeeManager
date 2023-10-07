using System.Collections.Generic;
using HairSalon.Models;
namespace HairSalon.ViewModels;
public class EmployeeDetailsViewModel
{
    public Employee Employee { get; set; }
    public List<Client> Clients { get; set; }
}
