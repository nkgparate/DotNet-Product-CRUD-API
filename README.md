# DotNet-Product-CRUD-API

## Description
A simple RESTful API built with .NET Core for managing products.  
Supports CRUD operations and follows clean architecture principles.

## Features
- Create, Read, Update, Delete (CRUD) products
- RESTful API endpoints
- Validation for input data
- Error handling
- EF Core integration with SQL Server
- Unit tests for core functionalities

## Tech Stack
- .NET Core 7
- C#
- Entity Framework Core
- SQL Server
- Swagger (API documentation)
- xUnit (unit testing)

## Folder Structure
- Controllers/ -> API controllers
- Models/ -> Product entity
- DTOs/ -> Data transfer objects
- Data/ -> DbContext for EF Core
- Services/ -> Business logic
- Migrations/ -> EF Core database migrations

  
## Installation / Setup
1. Clone the repo:
```bash
git clone https://github.com/<username>/Product-CRUD-API.git

2. Navigate to project directory:
cd Product-CRUD-API

3. Update connection string in appsettings.json:

"ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=ProductDb;Trusted_Connection=True;"
}

4.Apply migrations and run the project:

dotnet ef database update
dotnet run
Open Swagger UI for testing: https://localhost:5001/swagger/index.html

## API Endpoints

| Method | Endpoint           | Description        |
| ------ | ------------------ | ------------------ |
| GET    | /api/products      | Get all products   |
| GET    | /api/products/{id} | Get product by ID  |
| POST   | /api/products      | Create new product |
| PUT    | /api/products/{id} | Update product     |
| DELETE | /api/products/{id} | Delete product     |


