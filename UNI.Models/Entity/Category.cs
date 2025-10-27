namespace UNI.Models
{
    [Table ("product.category")]
    public class Category
    {
        
        [Key]
        public int category_id {  get; set; }
        public string name  { get; set; } = string.Empty;

        public bool is_active { get; set; }
    }
}
