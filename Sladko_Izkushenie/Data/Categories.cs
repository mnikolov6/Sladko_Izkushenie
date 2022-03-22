using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sladko_Izkushenie.Data
{
    public class Categories
    {
        [Key]        
        public int Id { get; set; }
        public string Category_Type { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }

    }
}
