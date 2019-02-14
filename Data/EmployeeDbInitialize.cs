using System;
using System.Linq;
using employee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace employee.Data
{
    public static class EmployeeDbInitialize
    {
        public static void init(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeDbContext(serviceProvider.GetRequiredService<DbContextOptions<EmployeeDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Employees.Any()) return;
            }
        }
    }
}