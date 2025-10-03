# Book Library

A simple ASP.NET Core web application for managing books with full CRUD (Create, Read, Update, Delete) operations.

## Overview

This project demonstrates a complete CRUD application built with ASP.NET Core 10.0, Entity Framework Core, and SQLite database. It provides a user-friendly interface for managing a book collection with features for adding, viewing, editing, and deleting book records.

## Features

- **Create**: Add new books with title, description, and author
- **Read**: View all books in a responsive table format
- **Update**: Edit existing book information
- **Delete**: Remove books from the collection
- **Details**: View detailed information for individual books
- **Responsive Design**: Built with Bootstrap 5 for mobile-friendly interface
- **Data Validation**: Form validation using Data Annotations

## Technology Stack

- **Framework**: ASP.NET Core 10.0
- **Database**: SQLite with Entity Framework Core 9.0
- **Frontend**: Razor Pages with Bootstrap 5.3.8
- **ORM**: Entity Framework Core
- **Language**: C# with nullable reference types enabled

## Prerequisites

- .NET 10.0 SDK or later
- Visual Studio Code
- Git (for cloning the repository)

## Getting Started

### 1. Clone the Repository

```bash
git clone <repository-url>
cd CRUD_Application
```

### 2. Navigate to Project Directory

```bash
cd CRUD_Application
```

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Update Database

The application uses Entity Framework migrations. If this is your first time running the project:

```bash
dotnet ef database update
```

### 5. Run the Application

```bash
dotnet run
```

The application will be available at:
- HTTP: `http://localhost:5000`
- HTTPS: `https://localhost:5001`

## Project Structure

```
CRUD_Application/
├── Data/
│   └── AppDbContext.cs          # Entity Framework DbContext
├── Models/
│   └── Books.cs                 # Book entity model
├── Pages/
│   ├── Book/                    # Book management pages
│   │   ├── Index.cshtml         # Books listing page
│   │   ├── Create.cshtml        # Create new book page
│   │   ├── Edit.cshtml          # Edit book page
│   │   ├── Details.cshtml       # Book details page
│   │   └── Delete.cshtml        # Delete confirmation page
│   └── Shared/                  # Shared layouts and components
├── Migrations/                  # Entity Framework migrations
├── wwwroot/                     # Static files (CSS, JS, images)
├── appsettings.json            # Application configuration
└── Program.cs                   # Application entry point
```

## Database Schema

The application uses a simple `Books` table with the following structure:

- `Bookid` (int, Primary Key)
- `BookTitle` (string, Required)
- `BookDescription` (string, Required)
- `BookAuthor` (string, Required)

## Usage

1. **View Books**: Navigate to the home page to see all books in a table format
2. **Add Book**: Click "Create New Book" to add a new book entry
3. **Edit Book**: Click "Edit" next to any book to modify its information
4. **View Details**: Click "Details" to see complete book information
5. **Delete Book**: Click "Delete" and confirm to remove a book

## Development

### Adding New Features

1. Create new Razor Pages in the `Pages/` directory
2. Update the `AppDbContext` if new entities are needed
3. Create and apply migrations for database changes

### Database Migrations

To create a new migration:
```bash
dotnet ef migrations add MigrationName
```

To update the database:
```bash
dotnet ef database update
```
