# Brief Latihan Portofolio

Kamu akan mengembangkan `Task Tracker API` ini secara bertahap. Jangan langsung loncat ke fitur besar. Tujuannya adalah membuat progres yang terlihat jelas di GitHub.

## Aturan main

- Kerjakan satu fitur per commit.
- Pastikan API tetap jalan setelah tiap perubahan.
- Tulis perubahan yang kamu buat di README bila perlu.
- Jangan buru-buru menambah database sebelum CRUD dasar stabil.

## Latihan 1: Pahami project yang sudah ada

Target:

- Jalankan API.
- Pahami fungsi tiap file.
- Tes semua endpoint di `examples/task-tracker.http`.

Checklist:

- Bisa menjelaskan fungsi `TaskRepository`.
- Bisa menjelaskan alur `POST /tasks`.
- Bisa menjelaskan kapan API mengembalikan `404`.

## Latihan 2: Tambah field priority

Task:

- Tambah field `Priority` ke model task.
- Batasi nilai ke `Low`, `Medium`, atau `High`.
- Perbarui request dan response.

Output yang diharapkan:

- Task baru bisa dikirim dengan priority.
- Data seed juga memiliki priority.
- README dan contoh request ikut diperbarui.

## Latihan 3: Tambah pencarian dan filter

Task:

- Dukungan query `GET /tasks?status=open`.
- Dukungan query `GET /tasks?status=done`.
- Dukungan query `GET /tasks?search=dotnet`.

Output yang diharapkan:

- Task bisa difilter tanpa mengubah endpoint utama.
- Filtering tetap aman walau query kosong.

## Latihan 4: Simpan data ke file JSON

Task:

- Ganti repository in-memory menjadi file-based storage sederhana.
- Saat app restart, data task tetap ada.

Petunjuk:

- Mulai dengan satu file `tasks.json`.
- Jangan terlalu cepat masuk ke database.

## Latihan 5: Tambah test

Task:

- Tambah test untuk repository atau helper validasi.
- Minimal cover create, update, dan delete.

## Latihan 6: Rapikan untuk GitHub

Task:

- Tambah screenshot hasil request atau terminal run.
- Pastikan README menjelaskan fitur utama.
- Tulis section `What I learned`.

## Contoh pengembangan setelah MVP

- Tambah due date
- Tambah category
- Tambah SQLite
- Tambah Swagger
- Deploy ke host container
