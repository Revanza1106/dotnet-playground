# .NET Learning Roadmap

## Stage 1: C# Fundamentals

Goals:

- Understand `string`, `int`, `bool`, `DateTime`, and `Guid`.
- Understand `if`, `switch`, `for`, and `foreach`.
- Write simple methods.
- Understand the difference between `class` and `record`.

Exercises:

- Build a task list in a console app.
- Mark a task as complete or incomplete.
- Print only the tasks that are still open.

## Stage 2: .NET Project Structure

Goals:

- Understand what `.csproj` contains.
- Understand the role of `Program.cs`.
- Understand how a project runs with `dotnet run`.

Exercises:

- Open the `TaskTracker.Api` project.
- Identify the available endpoints.
- Change the root endpoint response to include application version data.

## Stage 3: Basic Web API Development

Goals:

- Understand HTTP verbs.
- Read JSON request bodies.
- Return `200`, `201`, `400`, `404`, and `204` responses correctly.

Exercises:

- Add a task filter endpoint by status.
- Add a minimum length validation rule for the title.
- Add a `priority` field.

## Stage 4: Refactoring and Portfolio Quality

Goals:

- Separate logic so the code is easier to maintain.
- Write a clear README.
- Use consistent commit messages.

Exercises:

- Move validation logic into a helper or service.
- Add simple JSON file persistence.
- Write short API documentation.

## Stage 5: Next Steps

Once the basic version is stable, continue with:

- Entity Framework Core
- SQLite or PostgreSQL
- xUnit tests
- JWT authentication
- Container deployment
