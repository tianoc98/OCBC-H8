using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Data{
    public class ApiDbContext : DbContext{
        public virtual DbSet<ItemData> Items {get;set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            :base(options){
                
            }
    }
}