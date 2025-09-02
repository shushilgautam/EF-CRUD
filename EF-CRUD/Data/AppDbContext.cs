using EF_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CRUD.Data;
    

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Teacher> Teachers { get; set; }
}