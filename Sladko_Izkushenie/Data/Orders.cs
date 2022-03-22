using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sladko_Izkushenie.Data
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        ICollection<OrderDetails> OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
