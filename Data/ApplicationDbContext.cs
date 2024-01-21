using Microsoft.EntityFrameworkCore;
using FetchWebapi.Model;
namespace FetchWebapi.Data{

public class Appdbcontext:DbContext{
    public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
    {
        
    }
    public DbSet<Vehicle> VehicleDetails{get; set;}
    
}
}