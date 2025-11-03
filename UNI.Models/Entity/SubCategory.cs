

namespace UNI.Models
{
    [Table("product.subcategory")]
    public class SubCategory
    {
        [Key]
        public int subcategory_id { get; set; }
        public string name { get; set; } = string.Empty;
        public bool is_active { get; set; }

       
    }
}
