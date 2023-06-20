
using Microsoft.AspNetCore.Mvc;
using Prutech.Examples.API.Models;

namespace Prutech.Examples.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RajuController : ControllerBase
{
 
   
    [HttpGet]
    public string AddTwoNumbers(int a , int b)
    {
        Employee employee = new Employee();
        employee.EmployeeId = 1;
        return $" this is the calcuation of A = {a}  and B = {b} after adding both the values  are  : {(a + b)}"; 
    }

}
