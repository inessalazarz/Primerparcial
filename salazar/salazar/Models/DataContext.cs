
namespace salazar.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {

        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<salazar.Models.Clown> Clowns { get; set; }
    }
}