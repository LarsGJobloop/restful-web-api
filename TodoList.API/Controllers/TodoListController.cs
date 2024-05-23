using Microsoft.AspNetCore.Mvc;

namespace RestfulWebApi.Controllers;


// http://localhost:???   /api/v1/TodoList
[ApiController]
[Route("/api/v1/todolist")]
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

  [HttpPatch("{todoId}")]
  public ActionResult<TodoModel> UpdateTodo(int todoId, [FromBody] UpdateTodoModel todoInput)
  {
    TodoModel updatedTodo = todoListService.UpdateTodo(todoId, todoInput);

    return updatedTodo;
  }
}
