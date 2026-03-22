# .NET Task Tracker Lab

This repository is designed as a .NET learning workspace and a GitHub portfolio starter. The first project is a simple `Task Tracker API` built with ASP.NET Core Minimal API.

## Why this project works well for learning

- It is small enough to understand quickly but still useful as a portfolio project.
- It teaches C#, .NET project structure, HTTP APIs, input validation, and Docker.
- It can grow incrementally without forcing a rewrite from scratch.

## Concepts to understand first

Before you go deeper, make sure you are comfortable with:

1. Core C#: variables, types, methods, conditionals, loops, and collections.
2. Basic OOP: classes, properties, objects, and `record`.
3. Error handling and input validation.
4. REST basics: `GET`, `POST`, `PUT`, `PATCH`, and `DELETE`.
5. .NET project structure: `Program.cs`, `.csproj`, models, contracts, and services.
6. JSON requests and responses.
7. Basic Docker usage for a reproducible development environment.

The detailed learning roadmap lives in [docs/roadmap.md](docs/roadmap.md).

## Folder structure

```text
dotnet-task-tracker-lab/
|- compose.yaml
|- Dockerfile
|- docs/
|- examples/
`- src/
   `- TaskTracker.Api/
```

## Run with Docker

Move into the project folder:

```bash
cd dotnet-task-tracker-lab
```

Pull the SDK image:

```bash
docker compose pull
```

Restore the project:

```bash
docker compose run --rm dev dotnet restore src/TaskTracker.Api/TaskTracker.Api.csproj
```

Run the API:

```bash
docker compose run --rm --service-ports dev \
  dotnet run --project src/TaskTracker.Api/TaskTracker.Api.csproj --urls http://0.0.0.0:5050
```

Then open:

- `http://localhost:5050/`
- `http://localhost:5050/health`
- `http://localhost:5050/tasks`

If you want to build the application image:

```bash
docker build -t task-tracker-api .
docker run --rm -p 8080:8080 task-tracker-api
```

## Suggested exercise flow

Recommended order:

1. Run the API and understand [src/TaskTracker.Api/Program.cs](src/TaskTracker.Api/Program.cs).
2. Try the requests in [examples/task-tracker.http](examples/task-tracker.http).
3. Work through the challenges in [docs/exercises.md](docs/exercises.md).
4. Commit each milestone so your GitHub history shows steady progress.

## Portfolio-friendly commit ideas

- `chore: bootstrap dotnet task tracker lab with docker`
- `feat: add create and update task endpoints`
- `feat: add task filtering by status`
- `feat: persist tasks to json file`
- `test: add repository unit tests`
- `docs: improve readme and usage examples`

## Good portfolio baseline

A solid minimum target:

- Working CRUD API.
- Clear README.
- Docker setup.
- Request examples.
- At least one improvement beyond the starter scope.

After the basic version is stable, you can extend it into:

- Task Tracker with SQLite
- Expense Tracker API
- Habit Tracker API
- Notes API with authentication
