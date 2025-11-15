

namespace UNI.Models
{
    [Table ("product.product")]
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public bool is_active { get; set; }
        public bool is_expirate { get; set; }
        public int sub_category_id { get; set; }    

        [Write(false)]
        public SubCategory SubCategory { get; set; } = null!;
        public int unit_measure_id { get; set; }
        [Write(false)]
        public UnitMeasure UnitMeasure { get; set; } = null!;
    }
}
