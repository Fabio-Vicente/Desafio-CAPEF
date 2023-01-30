namespace Capef.Repository.Models;

public class FullReport<T> : IFullReport<T>
{
  int _totalEmployees;
  IEnumerable<T> _employeesList = default!;

  public int EmployeesTotal
  {
    get
    {
      return _totalEmployees;
    }
  }
  public IEnumerable<T> Employees
  {
    get
    {
      return _employeesList;
    }
    set
    {
      _employeesList = value;
      _totalEmployees = value.Count();
    }
  }
}