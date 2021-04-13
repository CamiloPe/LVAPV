using lva0008.Entidades;
using System.Data.Entity;

namespace lva0008
    
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        //constructor
        public DataContext():base("name=miConexion")
        {
        }
    }
}
