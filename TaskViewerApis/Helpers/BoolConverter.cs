using Newtonsoft.Json;

namespace TaskViewerApis.Helpers
{
    public class BoolConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString().ToLower();
            if (value == "1" || value == "true")
                return true;
            if (value == "0" || value == "false")
                return false;
            throw new JsonReaderException("Cannot convert to bool: " + value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue((bool)value ? "1" : "0");
        }
    }
}
