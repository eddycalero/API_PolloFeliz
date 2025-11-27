using System.Text.Json;

namespace UNI.Commons
{
    public static class JsonUtil
    {
        private readonly static JsonSerializerOptions _defaultOption = new()
        {
            PropertyNamingPolicy = null,
            MaxDepth = 10,
        };

        public static dynamic Deserealizar(dynamic? model)
        {
            return JsonSerializer.Deserialize<dynamic>(model, _defaultOption);
        }
        public static dynamic Deserealizar<T>(dynamic? model)
        {
            return JsonSerializer.Deserialize<T>(model, _defaultOption);
        }
    }
}
