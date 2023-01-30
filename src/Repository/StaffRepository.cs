using Capef.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Capef.Repository;

public class StaffRepository : IRepository<Employee>
{
  readonly CapefContext _context;

  public StaffRepository(CapefContext context)
  {
    _context = context;
  }

  public Employee Create(Employee employee)
  {
    Employee insertedEmployee = _context.Add(employee).Entity;
    _context.SaveChanges();

    return insertedEmployee;
  }

  public void Delete(int id)
  {
    _context.Find<Employee>(id);
    _context.SaveChanges();
  }

  public IEnumerable<Employee> ReadAll()
  {
    return _context.Set<Employee>();
  }

  public Employee? ReadOne(int id)
  {
    return _context.Find<Employee>(id);
  }

  public Employee Update(Employee employee)
  {
    Employee updatedEmployee = _context.Update(employee).Entity;
    _context.SaveChanges();

    return updatedEmployee;
  }
}