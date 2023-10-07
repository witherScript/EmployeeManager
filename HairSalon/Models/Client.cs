
namespace HairSalon.Models;
public class Client 
{
  public int ClientId { get; set; }
  public int EmployeeId { get; set; }
  public string Name { get; set; }
  public SpecialtyType SpecialtyNeeded {get; set;}
}