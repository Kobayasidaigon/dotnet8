using Microsoft.EntityFrameworkCore;
using MyMVCapp.Models;

namespace MyMVCapp.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
}

