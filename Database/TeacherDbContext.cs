using tarik_kt_43_21.Database.Configurations;
using tarik_kt_43_21.Models;
using Microsoft.EntityFrameworkCore;

namespace tarik_kt_43_21.Database
{
    public class TeacherDbContext : DbContext
    {
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
        }

        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options)
        {
        }
    }
}
