using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tododatabase.Models;

namespace tododatabase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
