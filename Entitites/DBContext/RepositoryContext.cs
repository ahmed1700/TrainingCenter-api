using Entitites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DBContext
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }  
        public DbSet<Employee> Employees { get; set; }
    }
}
