# 🧾 Enquiry CRUD API (ASP.NET Core)

This is a simple **CRUD API** built using **ASP.NET Core Web API** and **Entity Framework Core** to manage Enquiries, Enquiry Types, and Enquiry Statuses.

---

## ⚙️ Requirements
- .NET 8 SDK or later  
- SQL Server 
- Visual Studio or VS Code  

---

## 🚀 Getting Started

### 1️⃣ Clone the repository  
Clone this project from your repository and open it in your IDE.

### 2️⃣ Restore dependencies  
Run the command to restore NuGet packages.

### 3️⃣ Configure database connection  
Update your database connection string in **appsettings.json** under `"ConnectionStrings"`.

### 4️⃣ Run migrations (if applicable)  
Run EF Core migrations to create the database schema.

### 5️⃣ Start the API  
Start the application using `dotnet run` or from Visual Studio.

API will be available at:
- `http://localhost:5000`
- `https://localhost:7000`

---

## 📡 API Endpoints

| Method | Endpoint | Description |
|:------:|:----------|:-------------|
| **GET** | `/api/EnquiryMaster/GetAllStatus` | Get all enquiry statuses |
| **GET** | `/api/EnquiryMaster/GetAllTypes` | Get all enquiry types |
| **GET** | `/api/EnquiryMaster/GetAllEnquiry` | Get all enquiries |
| **POST** | `/api/EnquiryMaster/CreateNewEnquiry` | Create a new enquiry |
| **PUT** | `/api/EnquiryMaster/UpdateEnquiry` | Update an existing enquiry |
| **DELETE** | `/api/EnquiryMaster/DeleteEnquiryById?id={id}` | Delete an enquiry by ID |

---

## 🧠 Entities Overview

**EnquiryModel**  
Represents a customer enquiry record, including title, description, type, status, resolution, and created date.

**EnquiryStatus**  
Represents the various statuses an enquiry can have (e.g., Pending, Resolved, Closed).

**EnquiryType**  
Represents the category or type of enquiry (e.g., Product, Service, Technical).

---

## 🧩 Controller Overview

**EnquiryMasterController**  
Handles all enquiry-related CRUD operations, including:  
- Fetching all enquiries  
- Creating new enquiries  
- Updating existing ones  
- Deleting by ID  
Also includes endpoints for retrieving all enquiry types and statuses.

---

## 🔧 CORS Setup
Enable CORS in your project to allow API access from other domains by defining a policy in `Program.cs` and applying it globally or to specific controllers.

---

## 🧪 Testing the API
You can test the API using:
- **Swagger UI** (default path `/swagger`)
- **Postman**
- **cURL** requests

Example test:
- GET all enquiries  
- POST a new enquiry with JSON body  
- PUT to update an enquiry’s status or resolution  
- DELETE an enquiry by ID  

---

## 🧰 Tech Stack
- ASP.NET Core 8.0  
- Entity Framework Core  
- SQL Server / SQLite  
- Swagger UI for API documentation  
- CORS for frontend integration  

---

## 📝 License
This project is open-source. You may freely modify and use it for educational or commercial purposes.
