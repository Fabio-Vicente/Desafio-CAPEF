namespace Capef.Repository.Models;

public interface IFullReport<T>
{
  public int EmployeesTotal { get; }
  public IEnumerable<T> Employees { get; set; }
}