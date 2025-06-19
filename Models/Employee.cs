using System.ComponentModel.DataAnnotations;

namespace MvcEmployee.Models;

public class Employee
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the First Name."), MinLength(3), MaxLength(50)]
    public required string FirstName { get; set; }

    [Required(ErrorMessage = "Please enter the Last Name.")]
    public required string LastName { get; set; }

    [Required(ErrorMessage = "Please enter the Job Title.")]
    public required string JobTitle { get; set; }

    [Required(ErrorMessage = "Please enter the Salary.")]
    [Range(0, double.MaxValue, ErrorMessage = "The Salary must be a valid number greater than 0.")]
    public decimal Salary { get; set; }

}