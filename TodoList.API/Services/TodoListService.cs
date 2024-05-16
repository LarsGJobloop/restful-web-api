public interface ITodoListService
{
  public TodoModel[] GetAllTodos();
  public TodoModel CreateNewTodo(CreateTodoModel todoInput);
}

public class TodoListService : ITodoListService
{
  private List<TodoModel> todos;

  public TodoListService()
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
      Title = todoInput.Title
    };

    todos.Add(newTodo);

    return newTodo;
  }
}
