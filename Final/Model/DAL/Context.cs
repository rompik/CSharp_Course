using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;


namespace Model.DAL
{
    internal class Context : DbContext
    {
        public DbSet<MyTask> Tasks { get; set; }
        public Context() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOnBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocald;Database=TasksDB;Trusted_Connection=True;");
        }
    }
}
