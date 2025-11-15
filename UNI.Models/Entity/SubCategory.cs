namespace UNI.Models
{
    [Table("product.subcategory")]
    public class SubCategory
    {
        [Key]
        public int subcategory_id { get; set; }
        public string name { get; set; } = string.Empty;
        public bool is_active { get; set; }
        public int category_id { get; set; }
        [Write(false)]
        public Category Category { get; set; } = null!;
        [Write(false)]
        public ICollection<Product> Products { get; set; } = null!;
    }
}
