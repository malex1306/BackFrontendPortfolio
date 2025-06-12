using Microsoft.EntityFrameworkCore;
using ModernPorfolioBackend.Models;

namespace ModernPorfolioBackend.Data;

public class AppDbContext  : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<ContactForm> ContactForms => Set<ContactForm>();
}