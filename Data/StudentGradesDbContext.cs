using Microsoft.EntityFrameworkCore;

namespace StudentGrades.Data;

public class StudentGradesDbContext : DbContext
{
    public StudentGradesDbContext(
        DbContextOptions<StudentGradesDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();
}