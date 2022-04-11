using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    //DbContext lo puedo poner ahora que he incorporado al proyecto (tools, nuget package manager.. )
    //paquetes para poder trabajar con sql y entity framework
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
