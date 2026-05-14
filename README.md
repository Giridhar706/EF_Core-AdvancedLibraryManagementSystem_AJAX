# 📚 Advanced Library Management System

An ASP.NET Core MVC web application implementing Repository Pattern, Generic Repository, Entity Framework Core CRUD operations, AJAX integration, asynchronous programming, and Swagger API testing.

---

# 🚀 Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- AJAX
- C#
- HTML
- JavaScript
- Bootstrap

---

# ✨ Features

## ✅ CRUD Operations
- Add Books
- View Books
- Update Books
- Delete Books

## ✅ Repository Pattern
- Generic Repository Interface
- Reusable Data Access Layer
- Separation of Concerns

## ✅ AJAX Integration
- Load books asynchronously
- Partial page updates without refreshing the webpage

## ✅ EF Core Integration
- SQL Server database connectivity
- Navigation properties
- Relationship mapping

## ✅ Async Programming
- SaveChangesAsync()
- ToListAsync()
- Improved application performance

## ✅ Swagger API Testing
- GET API
- POST API
- PUT API
- DELETE API

---

# 📂 Project Structure

```bash
AdvancedLibraryManagementSystem
│
├── Controllers
│   ├── BooksController.cs
│   └── DatabaseBooksController.cs
│
├── Models
│   ├── Author.cs
│   ├── Book.cs
│   ├── Genre.cs
│   └── LibraryDbContext.cs
│
├── Repositories
│   ├── GenericRepository.cs
│   └── BookRepository.cs
│
├── Interfaces
│   └── IGenericRepository.cs
│
├── Views
│   └── Books
│       └── Index.cshtml
│
├── Program.cs
├── appsettings.json
└── AdvancedLibraryManagementSystem.csproj
```

---

# 🗄️ Database Tables

## Authors

| AuthorID | Name |
|----------|------|
| 1 | Chetan Bhagat |

---

## Books

| BookID | Title | AuthorID |
|--------|-------|----------|
| 1 | 2 States | 1 |

---

## Genres

| GenreID | GenreName |
|---------|------------|
| 1 | Fantasy |

---

# 🔥 API Endpoints

## GET Books

```http
GET /api/DatabaseBooks
```

---

## POST Book

```http
POST /api/DatabaseBooks
```

### Sample JSON

```json
{
  "title": "The Alchemist",
  "authorId": 1
}
```

---

## PUT Book

```http
PUT /api/DatabaseBooks/{id}
```

### Sample JSON

```json
{
  "bookId": 1,
  "title": "Updated Book",
  "authorId": 1
}
```

---

## DELETE Book

```http
DELETE /api/DatabaseBooks/{id}
```

---

# ⚡ AJAX Functionality

The application uses AJAX with JavaScript fetch() API to load books dynamically without refreshing the webpage.

```javascript
fetch('/api/DatabaseBooks')
```

---

# 🧠 Repository Pattern Implementation

## Generic Repository Interface

```csharp
public interface IGenericRepository<T>
```

---

## Generic Repository Class

```csharp
public class GenericRepository<T>
```

---

# 📸 Sample Outputs

## Swagger GET API Output

```json
[
  {
    "bookId": 1,
    "title": "2 States",
    "authorId": 1
  }
]
```

---

## AJAX Output

```text
Library Books

2 States
The Alchemist
```

---

# ▶️ How To Run The Project

## 1️⃣ Clone Repository

```bash
git clone <repository-url>
```

---

## 2️⃣ Open Project

Open the following file in Visual Studio:

```bash
AdvancedLibraryManagementSystem.csproj
```

---

## 3️⃣ Configure Database

Update the SQL Server connection string in:

```json
appsettings.json
```

---

## 4️⃣ Run Application

```bash
Ctrl + F5
```

---

## 5️⃣ Open Swagger

```bash
https://localhost:xxxx/swagger
```

---

# 📚 Concepts Covered

- ASP.NET Core MVC
- Entity Framework Core
- Repository Pattern
- Generic Repository
- Dependency Injection
- AJAX
- Async Programming
- CRUD Operations
- Query Optimization
- Swagger API Testing

---

# 👨‍💻 Author

Giridhar Gopal

---
