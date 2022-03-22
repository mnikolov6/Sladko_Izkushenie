using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sladko_Izkushenie.Data
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int OrdersId { get; set; }
        public Orders Orders { get; set; }

        public int Quantity { get; set; }
    }
}
