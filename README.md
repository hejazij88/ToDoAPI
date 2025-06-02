# ✅ ToDo API with JWT Authentication and Swagger

This project is a simple **Web API** for managing a **Todo List**, featuring:
- **CRUD** operations
- **JWT-based authentication and authorization**
- Full API documentation and testing with **Swagger**

---

## 🚀 Technologies Used
✅ **ASP.NET Core Web API**  
✅ **Entity Framework Core**  
✅ **JWT (JSON Web Token)**  
✅ **Swagger (Swashbuckle)**  

---

## 📦 How to Run the Project

1️⃣ **Clone or download the repository**:
```bash
git clone https://github.com/username/todoapi-jwt-swagger.git
cd todoapi-jwt-swagger
2️⃣ Configure the JWT key in appsettings.json:

json
Copy
Edit
"Jwt": {
  "Key": "this_is_a_super_secure_jwt_key_456789",
  "Issuer": "your_issuer",
  "Audience": "your_audience"
}
⚠️ Important Security Note: In production environments, store the JWT key securely using Secret Manager or Azure Key Vault. Avoid committing secrets to the source code!

3️⃣ Apply database migrations (if needed):

bash
Copy
Edit
dotnet ef database update
4️⃣ Run the project:

bash
Copy
Edit
dotnet run
🔐 Authentication and Authorization
Endpoints marked with [Authorize] require a valid JWT.

To test them in Swagger, click the Authorize button and enter your token:

Copy
Edit
Bearer {your_jwt_token}
🔎 Swagger UI
Once the project is running, navigate to:

bash
Copy
Edit
https://localhost:{port}/swagger
Here, you can test the API endpoints and see the full documentation.

📁 Project Structure
bash
Copy
Edit
├── Controllers/         # API Controllers
├── Data/                # EF Core DbContext
├── Model/               # Models / Entities
├── Program.cs           # Application configuration
├── appsettings.json     # Configuration (JWT, DB, ...)
└── README.md            # This file
✏️ Security Best Practices
✅ Never store sensitive keys in the source code.
✅ Use Secret Manager or Azure Key Vault for secure storage in production.

🎯 Summary
This project provides a solid foundation for building secure and scalable APIs with ASP.NET Core.
The code is designed to be easily extendable to add new features and business logic.

