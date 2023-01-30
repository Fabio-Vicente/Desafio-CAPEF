using Capef.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Capef.Controllers;

public interface IController<T>
{
  ActionResult<FullReport<T>> GetAll();

  ActionResult<T> GetOne(int id);
  ActionResult<T> Create(Employee employee);
  ActionResult<T> Update(Employee employee);
  ActionResult Delete(int id);
}