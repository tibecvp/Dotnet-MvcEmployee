using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcEmployee.Data;
using System;
using System.Linq;

namespace MvcEmployee.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcEmployeeContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcEmployeeContext>>()))
        {
            // Check if the database is already seeded
            if (context.Employee.Any())
            {
                return;
            }
            context.Employee.AddRange(
                new Employee
                {
                    FirstName = "Tiberio",
                    LastName = "Calderon",
                    JobTitle = "FullStack Developer",
                    Salary = 6237.34m
                },
                new Employee
                {
                    FirstName = "Dennis",
                    LastName = "Calderon",
                    JobTitle = "Flutter Developer",
                    Salary = 6237.34m
                },
                new Employee
                {
                    FirstName = "Catalina",
                    LastName = "Rodriguez",
                    JobTitle = "QA Engineer",
                    Salary = 6237.34m
                },
                new Employee
                {
                    FirstName = "Diego",
                    LastName = "Umba",
                    JobTitle = "DevOps Engineer",
                    Salary = 7324.63m
                },
                new Employee
                {
                    FirstName = "Felipe",
                    LastName = "Ardila",
                    JobTitle = "Project Manager",
                    Salary = 7634.92m
                }
            );
            context.SaveChanges();
        }
    }
}