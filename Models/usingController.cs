using System;
using System.ComponentModel.DataAnnotations;

System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int EmpNo { get; set; }

    [Required]
    public string Ci { get; set; }

    public DateTime BirthDate { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string Gender { get; set; }

    public DateTime HireDate { get; set; }

    [Required]
    [EmailAddress]
    public string Correo { get; set; }

    public bool Activo { get; set; } = true;
}