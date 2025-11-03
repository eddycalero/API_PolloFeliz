

namespace UNI.Models
{
    [Table("product.unit_measure")]
    public class UnitMeasure
    {
        [Key]
        public int unit_measure_id { get; set; }

        public string name { get; set; } = string.Empty;

        public bool is_active { get; set; }
    }
}
