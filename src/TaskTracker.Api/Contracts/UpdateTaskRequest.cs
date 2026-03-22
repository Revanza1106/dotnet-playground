namespace TaskTracker.Api.Contracts;

public sealed record UpdateTaskRequest(string Title, string? Description, string Priority, bool IsDone);
