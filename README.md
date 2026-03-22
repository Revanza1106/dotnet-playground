# Dotnet Task Tracker Lab

Repo ini dibuat sebagai tempat belajar .NET sekaligus dasar portofolio GitHub. Fokus proyek pertama adalah membuat `Task Tracker API` sederhana dengan ASP.NET Core Minimal API.

## Kenapa proyek ini cocok untuk belajar

- Cukup kecil untuk dipahami pemula, tetapi tetap relevan untuk portofolio.
- Kamu akan belajar C#, struktur project .NET, HTTP API, validasi input, dan Docker.
- Proyek ini bisa dikembangkan bertahap tanpa harus dibongkar dari nol.

## Yang perlu kamu pahami dulu

Sebelum masuk lebih jauh, kuasai konsep ini:

1. Dasar C#: variable, type, method, condition, loop, collection.
2. OOP dasar: class, property, object, `record`.
3. Error handling dan validasi input.
4. REST API dasar: `GET`, `POST`, `PUT`, `PATCH`, `DELETE`.
5. Struktur project .NET: `Program.cs`, `.csproj`, model, contract, service.
6. JSON request dan response.
7. Docker dasar untuk menjalankan environment konsisten.

Roadmap detail ada di [docs/roadmap.md](docs/roadmap.md).

## Struktur folder

```text
dotnet-task-tracker-lab/
|- compose.yaml
|- Dockerfile
|- docs/
|- examples/
`- src/
   `- TaskTracker.Api/
```

## Cara jalanin dengan Docker

Masuk ke folder ini:

```bash
cd dotnet-task-tracker-lab
```

Pull image SDK:

```bash
docker compose pull
```

Restore project:

```bash
docker compose run --rm dev dotnet restore src/TaskTracker.Api/TaskTracker.Api.csproj
```

Jalankan API:

```bash
docker compose run --rm --service-ports dev \
  dotnet run --project src/TaskTracker.Api/TaskTracker.Api.csproj --urls http://0.0.0.0:5050
```

Lalu buka:

- `http://localhost:5050/`
- `http://localhost:5050/health`
- `http://localhost:5050/tasks`

Kalau kamu ingin build image aplikasi:

```bash
docker build -t task-tracker-api .
docker run --rm -p 8080:8080 task-tracker-api
```

## Latihan bertahap

Urutan latihan yang saya sarankan:

1. Jalankan API dan pahami isi [src/TaskTracker.Api/Program.cs](src/TaskTracker.Api/Program.cs).
2. Coba request dari file [examples/task-tracker.http](examples/task-tracker.http).
3. Kerjakan tantangan di [docs/latihan.md](docs/latihan.md).
4. Commit tiap tahap ke GitHub agar progresmu terlihat.

## Ide commit untuk portofolio

- `chore: bootstrap dotnet task tracker lab with docker`
- `feat: add create and update task endpoints`
- `feat: add task filtering by status`
- `feat: persist tasks to json file`
- `test: add repository unit tests`
- `docs: improve readme and usage examples`

## Target akhir portofolio

Minimal target yang bagus untuk dipamerkan:

- API CRUD berjalan.
- README jelas.
- Docker setup ada.
- Request examples ada.
- Ada improvement buatanmu sendiri.

Kalau sudah selesai tahap dasar, proyek ini bisa kamu lanjutkan jadi:

- Task Tracker dengan database SQLite
- Expense Tracker API
- Habit Tracker API
- Notes API dengan authentication
