using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNI.Models
{
    [Table("product.subcategory")]
    public class SubCategory
    {
        [Key]
        public string name { get; set; }
        public int subcategory_id { get; set; }
        public bool is_active { get; set; }

       
    }
}
