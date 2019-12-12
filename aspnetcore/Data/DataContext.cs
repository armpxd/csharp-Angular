using aspnetcore.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore.Data {

    public class DataContext: DbContext {

        public DataContext(DbContextOptions<DataContext>options): base(options) {}
        
        public DbSet<Value> Values { get; set;}
        public DbSet<user> Users { get; set; }

    }
}