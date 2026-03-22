namespace TaskTracker.Api.Contracts;

public sealed record CreateTaskRequest(string Title, string? Description);
