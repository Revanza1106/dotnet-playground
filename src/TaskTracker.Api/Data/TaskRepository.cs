using TaskTracker.Api.Models;

namespace TaskTracker.Api.Data;

public sealed class TaskRepository
{
    private readonly List<TaskItem> _tasks =
    [
        new()
        {
            Id = Guid.Parse("9e8f8e76-235c-4e3a-8826-51fb3e4f8380"),
            Title = "Pelajari route di ASP.NET Core",
            Description = "Pahami GET, POST, PUT, PATCH, dan DELETE.",
            IsDone = false,
            CreatedAtUtc = DateTime.UtcNow
        },
        new()
        {
            Id = Guid.Parse("5bcd9651-1a98-4910-9fca-9ebda7b53b74"),
            Title = "Rapikan README portofolio",
            Description = "Jelaskan fitur project dan cara menjalankannya.",
            IsDone = true,
            CreatedAtUtc = DateTime.UtcNow.AddDays(-1)
        }
    ];

    public IReadOnlyList<TaskItem> GetAll()
    {
        return _tasks
            .OrderByDescending(task => task.CreatedAtUtc)
            .ToList();
    }

    public TaskItem? GetById(Guid id)
    {
        return _tasks.FirstOrDefault(task => task.Id == id);
    }

    public TaskItem Add(string title, string description)
    {
        var task = new TaskItem
        {
            Id = Guid.NewGuid(),
            Title = title.Trim(),
            Description = description.Trim(),
            IsDone = false,
            CreatedAtUtc = DateTime.UtcNow
        };

        _tasks.Add(task);

        return task;
    }

    public TaskItem? Update(Guid id, string title, string description, bool isDone)
    {
        var task = GetById(id);

        if (task is null)
        {
            return null;
        }

        task.Title = title.Trim();
        task.Description = description.Trim();
        task.IsDone = isDone;

        return task;
    }

    public TaskItem? UpdateStatus(Guid id, bool isDone)
    {
        var task = GetById(id);

        if (task is null)
        {
            return null;
        }

        task.IsDone = isDone;

        return task;
    }

    public bool Delete(Guid id)
    {
        var task = GetById(id);

        if (task is null)
        {
            return false;
        }

        return _tasks.Remove(task);
    }
}
