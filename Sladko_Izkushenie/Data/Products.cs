using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sladko_Izkushenie.Data
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public string ImgURL { get; set; }
        public float Price { get; set; }
        public DateTime Date_of_register { get; set; }
        ICollection<OrderDetails> OrderDetails { get; set; }
        ICollection<Categories> Categories { get; set; }

    }
}
