using GreetingAppCommannLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingAppRepositoriesLayer.Context
{
    public class RepoDbContext: DbContext
    {
        public RepoDbContext(DbContextOptions<RepoDbContext> options) : base(options)
        {
        }
        public DbSet<GreetingModel> Employees { get; set; }        
    }
}
