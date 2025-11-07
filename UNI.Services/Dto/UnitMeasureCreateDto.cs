
namespace UNI.Services
{
    public class UnitMeasureCreateDto
    {
        public int UnitMeasureId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
