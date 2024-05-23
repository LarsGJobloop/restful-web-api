public interface ITodoListService
{
  public TodoModel[] GetAllTodos();
  public TodoModel CreateNewTodo(CreateTodoModel todoInput);
}

public class TodoListInMemoryService : ITodoListService
{
  private List<TodoModel> todos;
  private int nextId;

  public TodoListInMemoryService()
  {
    todos = new List<TodoModel>();
    nextId = 0;
  }

  public TodoModel[] GetAllTodos()
  {
    return todos.ToArray();
  }

  public TodoModel CreateNewTodo(CreateTodoModel todoInput)
  {
    TodoModel newTodo = new TodoModel()
    {
      Id = nextId++,
      Title = todoInput.Title,
      CreatedAt = DateTime.Now,
      UpdatedAt = DateTime.Now,
    };

    todos.Add(newTodo);

    return newTodo;
  }
}
