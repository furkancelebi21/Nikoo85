using Microsoft.EntityFrameworkCore;
using System;

namespace furkii.Databases
{    public class furkiican:DbContext
    {
        public furkiican(DbContextOptions<furkiican> options):base(options) {}

        public DbSet<User> Users { get; set; }
    }
}
