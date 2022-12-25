using StudentGrades.Data;

namespace StudentGrades.Pages;

public class ListStudentsModel : PageModel
{
    private readonly StudentGradesDbContext context;

    public ListStudentsModel(StudentGradesDbContext context)
    {
        this.context = context;
    }

    public IList<Student> Students { get; private set; } = new List<Student>();

    public void OnGet()
    {
        Students = context.Students.OrderBy(p => p.Name).ToList();
    }
}