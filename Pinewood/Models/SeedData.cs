
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pinewood.Data;
using System;
using System.Linq;

namespace Pinewood.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PinewoodContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<PinewoodContext>>()))
        {
            // Look for any movies.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }
            context.Customer.AddRange(
                new Customer
                {
                    Accountno = 1000,
                    FirstName = "Dave",
                    LastName = "Bryan",
                    Email = "db@coldmail.com"
                },
                new Customer
                {
                    Accountno = 1001,
                    FirstName = "Jan",
                    LastName = "Bryan",
                    Email = "jb@coldmail.com"
                },
                new Customer
                {
                    Accountno = 1002,
                    FirstName = "Lucy",
                    LastName = "Bryan",
                    Email = "lb@coldmail.com"
                },
                new Customer
                {
                    Accountno = 1003,
                    FirstName = "Matt",
                    LastName = "Bryan",
                    Email = "mb@coldmail.com"
                }
            );
            context.SaveChanges();
        }
    }
}

