using hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace hospital.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}