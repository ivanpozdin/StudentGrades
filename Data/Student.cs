using System.ComponentModel.DataAnnotations;

namespace StudentGrades.Data;

public class Student
{
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Please enter name")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Please enter subject")]
    public string Subject { get; set; } = "";

    [Required(ErrorMessage = "Please enter grade")]
    [RegularExpression("^([1-9]|10)$", ErrorMessage = "Please enter a valid number from 0 to 10")]
    public byte Grade { get; set; }
}