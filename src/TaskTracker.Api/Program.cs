using TaskTracker.Api.Contracts;
using TaskTracker.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TaskRepository>();

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    name = "Task Tracker API",
    message = "Gunakan project ini sebagai latihan portofolio .NET.",
    endpoints = new[]
    {
        "GET /health",
        "GET /tasks",
        "GET /tasks/{id}",
        "POST /tasks",
        "PUT /tasks/{id}",
        "PATCH /tasks/{id}/status",
        "DELETE /tasks/{id}"
    }
}));

app.MapGet("/health", () => Results.Ok(new
{
    status = "ok",
    utc = DateTime.UtcNow
}));

app.MapGet("/tasks", (TaskRepository repository) => Results.Ok(repository.GetAll()));

app.MapGet("/tasks/{id:guid}", (Guid id, TaskRepository repository) =>
{
    var task = repository.GetById(id);

    return task is null
        ? Results.NotFound(new { message = "Task tidak ditemukan." })
        : Results.Ok(task);
});

app.MapPost("/tasks", (CreateTaskRequest request, TaskRepository repository) =>
{
    if (string.IsNullOrWhiteSpace(request.Title))
    {
        return Results.BadRequest(new { message = "Title wajib diisi." });
    }

    var task = repository.Add(request.Title, request.Description ?? string.Empty);

    return Results.Created($"/tasks/{task.Id}", task);
});

app.MapPut("/tasks/{id:guid}", (Guid id, UpdateTaskRequest request, TaskRepository repository) =>
{
    if (string.IsNullOrWhiteSpace(request.Title))
    {
        return Results.BadRequest(new { message = "Title wajib diisi." });
    }

    var updatedTask = repository.Update(
        id,
        request.Title,
        request.Description ?? string.Empty,
        request.IsDone);

    return updatedTask is null
        ? Results.NotFound(new { message = "Task tidak ditemukan." })
        : Results.Ok(updatedTask);
});

app.MapPatch("/tasks/{id:guid}/status", (Guid id, UpdateTaskStatusRequest request, TaskRepository repository) =>
{
    var updatedTask = repository.UpdateStatus(id, request.IsDone);

    return updatedTask is null
        ? Results.NotFound(new { message = "Task tidak ditemukan." })
        : Results.Ok(updatedTask);
});

app.MapDelete("/tasks/{id:guid}", (Guid id, TaskRepository repository) =>
    repository.Delete(id)
        ? Results.NoContent()
        : Results.NotFound(new { message = "Task tidak ditemukan." }));

app.Run();
