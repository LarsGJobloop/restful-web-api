using Microsoft.AspNetCore.Mvc;

namespace RestfulWebApi.Controllers;


// http://localhost:???   /api/v1/TodoList
[ApiController]
[Route("/api/v1/[controller]")]
public class TodoListController : ControllerBase
{
  [HttpGet]
  public ActionResult<TodoModel> GetTodo()
  {
    TodoModel newTodo = new TodoModel()
    {
      Title = "Learn C#"
    };

    return newTodo;
  }

  [HttpPost]
  public ActionResult<TodoModel> CreateNewTodo(CreateTodoModel todoInput)
  {
    TodoModel newTodo = new TodoModel()
    {
      Title = todoInput.Title
    };

    return newTodo;
  }
}
