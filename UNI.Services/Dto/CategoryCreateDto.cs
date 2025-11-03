
namespace UNI.Services
{
    public class CategoryCreateDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
