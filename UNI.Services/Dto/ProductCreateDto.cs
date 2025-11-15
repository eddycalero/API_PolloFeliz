namespace UNI.Services
{
    public class ProductCreateDto
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage ="El activo es requerido")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "El expiration es requerido")]
        public bool IsExpirate { get; set; }
        [Required(ErrorMessage = "La sub categoria id")]
        public int SubCategoryId { get; set; }
        [Required(ErrorMessage = "La unidad de medida es requerida")]
        public int UnitMeasureId { get; set; }
    }
}
