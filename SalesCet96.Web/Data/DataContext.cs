using Microsoft.EntityFrameworkCore;
using SalesCet96.Web.Data.Entities;

namespace SalesCet96.Web.Data
{
    //Código responsável por montar a base de dados
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {      
        }

        public DbSet<Country> Countries { get; set; }   //Crio (DbSet) a tabela "Countries"
    }
}
