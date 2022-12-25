using StudentGrades.Data;

namespace StudentGrades.Pages;

[BindProperties]
public class GradeModel : PageModel
{
    private readonly StudentGradesDbContext _context;

    public GradeModel(StudentGradesDbContext context)
    {
        _context = context;
    }

    public Student Student { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();
        _context.Students.Add(Student);
        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }
}