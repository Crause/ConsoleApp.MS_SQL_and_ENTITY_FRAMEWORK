using System;
using System.Data.Entity;

namespace ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK
{
  class MyDbContext : DbContext
  {
    public MyDbContext() : base("DbConnectionString")
    {
    }

    public DbSet<Group> Groups { get; set; }
    public DbSet<Song> Songs { get; set; }
  }
}
