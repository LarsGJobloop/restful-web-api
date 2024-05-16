using Microsoft.AspNetCore.Mvc;

namespace RestfulWebApi.Controllers;


// http://localhost:???   /api/v1/TodoList
[ApiController]
[Route("/api/v1/[controller]")]
public class TodoListController : ControllerBase
{
  private ITodoListService todoListService;

  public TodoListController(ITodoListService TodoList)
  {
    todoListService = TodoList;
  }

  [HttpGet]
  public ActionResult<TodoModel[]> GetTodo()
  {
    return todoListService.GetAllTodos();
  }

  [HttpPost]
  public ActionResult<TodoModel> CreateNewTodo(CreateTodoModel todoInput)
  {
    TodoModel newTodo = todoListService.CreateNewTodo(todoInput);
    return newTodo;
  }
}
