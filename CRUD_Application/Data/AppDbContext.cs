using System;
using CRUD_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Application.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Books> Books { get; set; }
}
