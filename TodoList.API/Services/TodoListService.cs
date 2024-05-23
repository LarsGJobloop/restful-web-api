public interface ITodoListService
{
  public TodoModel[] GetAllTodos();
  public TodoModel CreateNewTodo(CreateTodoModel todoInput);
}

public class TodoListInMemoryService : ITodoListService
{
  private List<TodoModel> todos;

  public TodoListInMemoryService()
  {
    todos = new List<TodoModel>();
  }

  public TodoModel[] GetAllTodos()
  {
    return todos.ToArray();
  }

  public TodoModel CreateNewTodo(CreateTodoModel todoInput)
  {
    TodoModel newTodo = new TodoModel()
    {
      Title = todoInput.Title,
      CreatedAt = DateTime.Now,
      UpdatedAt = DateTime.Now,
    };

    todos.Add(newTodo);

    return newTodo;
  }
}
