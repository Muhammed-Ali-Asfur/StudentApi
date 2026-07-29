# 🎓 Student API

**A secure RESTful Web API for student management**, built with ASP.NET Core Web API following an N-Tier architecture. Access is protected end-to-end with JWT authentication, refresh tokens, and role-based authorization.

---

## ✨ Features

- 🔑 **JWT Authentication** — Stateless, token-based access to API resources
- 🔄 **Refresh Token Flow** — Seamless session renewal without re-authentication
- 🛡️ **Role-Based Authorization** — Fine-grained access control per endpoint
- 🏗️ **N-Tier Architecture** — Clean separation between presentation, business, and data layers
- 📄 **Swagger/OpenAPI Documentation** — Interactive, self-documenting API reference
- 🌐 **RESTful Design** — Predictable, resource-oriented endpoint structure

---

## 🛠️ Tech Stack

| Layer | Technologies |
|---|---|
| **Backend** | C#, ASP.NET Core Web API |
| **Security** | JWT Authentication, Refresh Token, Role-Based Authorization |
| **Architecture** | N-Tier Architecture, REST API |
| **Documentation** | Swagger / OpenAPI |

---

## 🏗️ Architecture

This project follows an **N-Tier architecture**, keeping the API modular and maintainable:

```
StudentAPI/
├── Presentation Layer     → Controllers, Endpoints
├── Business Layer         → Services, Business Logic
├── Data Access Layer      → Repositories, Data Context
└── Entity/Domain Layer    → Models, DTOs
```

---

## 🔐 Authentication Flow

1. User logs in with credentials → API issues a **JWT access token** + **refresh token**
2. Access token is sent with each request via the `Authorization: Bearer <token>` header
3. When the access token expires, the **refresh token** is used to obtain a new one — no re-login required
4. Endpoints are further restricted based on the user's **role**

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- SQL Server or your configured database provider
- Visual Studio 2022 or VS Code

### Installation

```bash
# Clone the repository
git clone https://github.com/your-username/StudentAPI.git

# Navigate to the project directory
cd StudentAPI

# Restore dependencies
dotnet restore

# Update the database
dotnet ef database update

# Run the application
dotnet run
```

> 💡 Update the connection string and JWT settings (issuer, audience, secret key) in `appsettings.json` before running.

### API Documentation

Once running, navigate to `/swagger` to explore and test all available endpoints interactively.

---

## 📬 Contact

Feel free to reach out or open an issue if you have questions or suggestions.

---

⭐ If you found this project useful, consider giving it a star!
