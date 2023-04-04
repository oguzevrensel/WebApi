# WebApi
This project is a .NET Core Web API for managing user data through CRUD operations. It provides endpoints for creating, reading, updating, and deleting users in the database.

# Requirements
.NET Core 6.0 or later
Microsoft SQL Server or another compatible database management system
# Getting Started
Clone or download the project to your local machine.

In the project directory, navigate to the appsettings.json file and update the connection string with your database information.


# Run the project using the following command:

```arduino
dotnet run
```
Open your web browser and navigate to the following URL to view the Swagger UI documentation:

```bash
http://localhost:5000/swagger
Use the Swagger UI to test the API endpoints.
```

# API Endpoints
 ## Get all users

```bash
GET /api/users
// This endpoint retrieves a list of all users in the database.
```
## Get user by ID
```bash
GET /api/users/{id}
// This endpoint retrieves a single user from the database based on the specified ID.
```
## Create user
```bash
POST /api/users
// This endpoint adds a new user to the database. The request body should contain a JSON object with the following properties:

first name (string): the user's first name
last name (string): the user's last name
address (string): the user's address
```
## Update user
```bash
PUT /api/users/{id}
// This endpoint updates an existing user in the database based on the specified ID. The request body should contain a JSON object with the following properties:

first name (string): the user's first name
last name (string): the user's last name
address (string): the user's address
```
## Delete user
```bash
DELETE /api/users/{id}
// This endpoint deletes a user from the database based on the specified ID.
```
# Screenshots
![Ekran Görüntüsü (78)](https://user-images.githubusercontent.com/73538407/229802125-3aa6d9cd-20b8-4b9c-b62b-ced4861c6f1d.png)
![Ekran Görüntüsü (79)](https://user-images.githubusercontent.com/73538407/229802163-56d9b6fe-d060-435d-a2bd-d7aba4aff4e4.png)
![Ekran Görüntüsü (80)](https://user-images.githubusercontent.com/73538407/229802197-0f7b2da7-29e5-41ca-bc9d-f4e4a00975b2.png)

