# Portfolio Exercise Brief

You will build this `Task Tracker API` step by step. Do not jump into large features too early. The goal is to create visible, understandable progress on GitHub.

## Ground rules

- Ship one feature per commit.
- Keep the API working after every change.
- Update the README when the behavior changes.
- Do not rush into a database before the basic CRUD flow is stable.

## Exercise 1: Understand the existing project

Goals:

- Run the API.
- Understand the role of each file.
- Test every endpoint in `examples/task-tracker.http`.

Checklist:

- You can explain what `TaskRepository` does.
- You can explain the `POST /tasks` flow.
- You can explain when the API returns `404`.

## Exercise 2: Add a priority field

Task:

- Add a `Priority` field to the task model.
- Restrict the value to `Low`, `Medium`, or `High`.
- Update the request and response shape.

Expected outcome:

- New tasks can be submitted with a priority.
- Seed data also includes priority values.
- The README and request examples are updated.

## Exercise 3: Add search and filtering

Task:

- Support `GET /tasks?status=open`.
- Support `GET /tasks?status=done`.
- Support `GET /tasks?search=dotnet`.

Expected outcome:

- Tasks can be filtered without changing the main endpoint.
- Filtering remains safe when the query is empty.

## Exercise 4: Persist data to JSON

Task:

- Replace the in-memory repository with a simple file-based storage layer.
- Keep task data after an application restart.

Hints:

- Start with a single `tasks.json` file.
- Do not introduce a database too early.

## Exercise 5: Add tests

Task:

- Add tests for the repository or validation helper.
- Cover create, update, and delete at minimum.

## Exercise 6: Polish it for GitHub

Task:

- Add screenshots of requests or terminal output.
- Make sure the README explains the main features.
- Add a `What I learned` section.

## Post-MVP extension ideas

- Add due date support
- Add categories
- Add SQLite
- Add Swagger
- Deploy the containerized app
