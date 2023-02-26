using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloMVC_mei.Models;

namespace HelloMVC_mei.Data
{
    public class HelloMVC_meiContext : DbContext
    {
        public HelloMVC_meiContext (DbContextOptions<HelloMVC_meiContext> options)
            : base(options)
        {
        }

        public DbSet<HelloMVC_mei.Models.Movie> Movie { get; set; } = default!;
    }
}
