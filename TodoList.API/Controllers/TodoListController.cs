using Microsoft.AspNetCore.Mvc;

namespace RestfulWebApi.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class TodoListController : ControllerBase
{
  [HttpGet]
  public ActionResult<string> GetTodo()
  {
    return "Foo";
  }
}
