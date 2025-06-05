using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryZadacha
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext() : base("DeliveryContext")
        {

        }
        public DbSet<DishTypes> DishTypes { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
