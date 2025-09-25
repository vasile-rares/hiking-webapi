# Hiking API 🥾

A REST API for managing hiking trails, built with **ASP.NET Core 8** and **Entity Framework Core**.

---

## 📋 Features
- Manage regions and hiking trails  
- Upload and manage images  
- Authentication and authorization with JWT  
- Filtering, sorting, and pagination  

---

## 🛠️ Technologies
- ASP.NET Core 8  
- Entity Framework Core + SQL Server  
- JWT Authentication & ASP.NET Core Identity  
- AutoMapper  
- Swagger / OpenAPI  

---

## 🚀 Installation
1. Clone the repository:  
   ```bash
   git clone <repository-url>
   cd NZWalks.API
   ```
2. Configure the connection string in `appsettings.json`  
3. Run migrations:  
   ```bash
   dotnet ef database update
   dotnet ef database update --context NZWalksAuthDbContext
   ```
4. Start the application:  
   ```bash
   dotnet run
   ```
5. Access Swagger at `https://localhost:7075/swagger`

---

## 📝 Example Endpoints
- `POST /api/auth/register` – Register a new user  
- `POST /api/auth/login` – User login  
- `GET /api/regions` – Get all regions  
- `GET /api/walks` – Get all walks (with filtering/pagination)  
- `POST /api/images` – Upload an image  

---

## 📄 License
Educational project based on the course [Build ASP.NET Core Web API - Scratch To Finish (.NET8 API)](https://www.udemy.com/course/build-rest-apis-with-aspnet-core-web-api-entity-framework/).
