namespace TodoAppMvvm.Pages.Todo.Models
{
    public class TodoModel
    {
        public Name Name { get; set; }
        public TimeSpanTodo TimeSpan { get; set; }
        public Description Description { get; set; }
        public List<Comments> Comments { get; set; }
        public Status Status { get; set; }
    }
    public record  Name(string value);
    public record TimeSpanTodo (DateTime Value);
    public record Description(string Value);
    public record Comments (string value);
    public record Status (bool TodoStatus);

}

