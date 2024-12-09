using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class AdminModel
{
    [Key] // Marks the Id property as the primary key (equivalent to _id in MongoDB)
    public int Id { get; set; }

    [Required] // Equivalent to 'required: true' in Mongoose
    public string Name { get; set; }

    [Required] // Equivalent to 'required: true' in Mongoose
    [EmailAddress] // Optional: Adds email format validation
    public string Email { get; set; }

    [Required] // Equivalent to 'required: true' in Mongoose
    public string Password { get; set; }

    [Required] // Equivalent to 'required: true' in Mongoose
    [DefaultValue("Admin")] // Sets default value, but this requires using Fluent API to apply in EF Core
    public string Role { get; set; } = "Admin"; // Default value for role

    [Required] // Equivalent to 'required: true' in Mongoose
    public string SchoolName { get; set; }
}
