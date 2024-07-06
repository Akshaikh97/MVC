using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}
        public DbSet<Category> Category { get; set; }
    }
}