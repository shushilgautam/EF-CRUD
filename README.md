# Beginner Checklist: Teacher CRUD App in ASP.NET Core MVC + EF Core (No Code Generator)

This is a **simplified, step-by-step guide** for new learners to build a Teacher CRUD app using .NET Core—**no scaffolding or code generator commands required**!  
Just follow the terminal commands in order.

---

## 1. Create Your Project

```sh
dotnet new mvc -n EF_CRUD
cd EF_CRUD
```

---

## 2. Add Required Packages

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

## 3. Create/Edit Project Files (Open in your code editor)

- `Models/Teacher.cs` – Create the Teacher class/model.
- `Data/AppDbContext.cs` – Create the EF Core DbContext.
- `appsettings.json` – Add a connection string named `DefaultConnection` (use `(localdb)\MSSQLLocalDB` for local dev).
- `Program.cs` – Register your DbContext with the connection string.
- `Controllers/TeacherController.cs` – Write your Teacher controller for CRUD actions.
- Views:
  - `/Views/Teacher/Index.cshtml`
  - `/Views/Teacher/Create.cshtml`
  - `/Views/Teacher/Edit.cshtml`
  - `/Views/Teacher/Details.cshtml`
  - `/Views/Teacher/Delete.cshtml`

*(You’ll add code to these files in your editor.)*

---

## 4. Set Up Database (Migrations)

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 5. Run Your App

```sh
dotnet run
```
Open the URL shown (e.g. `http://localhost:5000`) and navigate to `/Teacher`.

---

## 6. Common Database Commands

**After changing your model:**
```sh
dotnet ef migrations add YourMigrationName
dotnet ef database update
```

**Remove last migration (before update):**
```sh
dotnet ef migrations remove
```

**Drop the database (for development only):**
```sh
dotnet ef database drop
```

---

## 7. Troubleshooting

If you get errors with migrations or DbContext:
- Make sure your `Program.cs` registers your DbContext properly.
- Specify the startup project if needed:
  ```sh
  dotnet ef migrations add InitialCreate --startup-project .
  dotnet ef database update --project . --startup-project .
  ```

---

**That’s it! Just follow these steps, and write your own model, controller, and views code in your editor.**
