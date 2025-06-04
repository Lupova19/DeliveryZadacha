using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryZadacha
{
    public class DishTypes
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Dish> Dishes { get; set; }
    }
}
