using System.ComponentModel.DataAnnotations;

namespace EF_CRUD.Models;

public class Teacher
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Subject is required")]
    [StringLength(50, ErrorMessage = "Subject cannot be longer than 50 characters")]
    public string Subject { get; set; } = "";

    [Range(21, 70, ErrorMessage = "Age must be between 21 and 70")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; } = "";
}