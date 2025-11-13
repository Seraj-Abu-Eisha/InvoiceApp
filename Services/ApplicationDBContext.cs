using InvoiceApp.models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Invoce> Invoices { get; set; } = null!;
    }
}
