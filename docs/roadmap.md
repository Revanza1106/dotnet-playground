# Roadmap Belajar .NET

## Tahap 1: Dasar C#

Target:

- Paham `string`, `int`, `bool`, `DateTime`, `Guid`.
- Paham `if`, `switch`, `for`, `foreach`.
- Bisa membuat method sederhana.
- Paham perbedaan `class` dan `record`.

Latihan:

- Buat list task di console app.
- Tandai task selesai atau belum.
- Cetak task yang statusnya belum selesai.

## Tahap 2: Struktur Project .NET

Target:

- Paham isi `.csproj`.
- Paham fungsi `Program.cs`.
- Paham bagaimana project dijalankan dengan `dotnet run`.

Latihan:

- Buka project `TaskTracker.Api`.
- Identifikasi endpoint yang tersedia.
- Ubah response root endpoint agar menampilkan data versi aplikasi.

## Tahap 3: Web API Dasar

Target:

- Paham HTTP verb.
- Bisa baca body JSON.
- Bisa kirim response `200`, `201`, `400`, `404`, `204`.

Latihan:

- Tambah endpoint filter task berdasarkan status.
- Tambah validasi title minimal 3 karakter.
- Tambah field `priority`.

## Tahap 4: Refactor dan Portofolio

Target:

- Pisahkan logic agar code lebih rapi.
- Tulis README yang jelas.
- Gunakan commit message yang konsisten.

Latihan:

- Pisahkan logic validasi ke service atau helper.
- Tambah penyimpanan ke file JSON.
- Tulis dokumentasi API singkat.

## Tahap 5: Lanjutan

Setelah tahap dasar ini stabil, lanjutkan ke:

- Entity Framework Core
- SQLite atau PostgreSQL
- xUnit test
- Authentication JWT
- Deployment container
