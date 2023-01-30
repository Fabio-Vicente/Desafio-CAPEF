namespace Capef.Repository.Models;
using System.ComponentModel.DataAnnotations;

public class Employee
{
  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public string Gender { get; set; } = default!;
  public string MarriageState { get; set; } = default!;
  public DateTime BornDate { get; set; }
  [StringLength(11)]
  public string Cpf { get; set; } = default!;
  [EmailAddress]
  public string Email { get; set; } = default!;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
