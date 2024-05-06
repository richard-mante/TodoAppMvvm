using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TodoAppMvvm.Pages.Todo.Models;

namespace TodoAppMvvm.Pages.Todo.ViewModel;

public partial class TodoViewModel : ObservableObject
{
    private ObservableCollection<TodoModel> _allTodos;

    [ObservableProperty]
    public string _notificationMessage;

    [RelayCommand]
    public void CreateTodo(TodoModel todo)
    {
        _allTodos.Add(todo);
    }

    [RelayCommand(CanExecute = nameof(CommentNotification) )]
   public void CreateCommentTodod(Name todoName, Comments todoComment)
    {
       
    
            var todoItem = _allTodos.Where(x => x.Name == todoName).FirstOrDefault();

            if (todoItem != null)
            {
                todoItem.Comments.Add(todoComment);
            }

    }

        [RelayCommand]
    public void CommentNotification() 
    {
        _notificationMessage = "New Comment has been Added";
    }

}

