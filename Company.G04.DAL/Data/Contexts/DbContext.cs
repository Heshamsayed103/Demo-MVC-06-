using System.Reflection;

namespace Company.G04.DAL.Data.Contexts
{
    public class DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}