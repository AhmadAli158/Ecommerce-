using Microsoft.EntityFrameworkCore;

namespace Ecommerce_app.Data
{ 
public class Datadbcontext : DbContext
{

	public Datadbcontext(DbContextOptions<Datadbcontext> options) : base(options) { }

	public DbSet<product> products { get; set; }


}

}

