using Capef.Repository;
using Capef.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Capef.Controllers;

[ApiController]
[Route("[controller]")]
public class StaffController : ControllerBase, IController<Employee>
{
    // private readonly ILogger<WeatherForecastController> _logger;

    // public WeatherForecastController(ILogger<WeatherForecastController> logger)
    // {
    //     _logger = logger;
    // }

    readonly IRepository<Employee> _repository;

    public StaffController(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<FullReport<Employee>> GetAll()
    {
        FullReport<Employee> report = new() {
            Employees = _repository.ReadAll()
        };

        return Ok(report);
    }

    [HttpGet("{id}"), ActionName("GetEmployee")]
    public ActionResult<Employee> GetOne(int id)
    {
        Employee? foundEmployee = _repository.ReadOne(id);
        if (foundEmployee == null)
        {
            return NotFound();
        }

        return Ok(foundEmployee);
    }

    [HttpPost]
    public ActionResult<Employee> Create([FromBody] Employee employee)
    {
      Employee createdEmployee = _repository.Create(employee);

      return CreatedAtAction("GetEmployee", createdEmployee, new { createdEmployee.Id });
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Employee? foundEmployee = _repository.ReadOne(id);
          if (foundEmployee == null)
          {
              return NotFound();
          }
        
        _repository.Delete(id);

        return NoContent();
    }

    [HttpPut("{id}")]
    public ActionResult<Employee> Update([FromBody] Employee employee)
    {
      Employee updatedEmployee = _repository.Update(employee);

      return Ok(updatedEmployee);
    }
}
