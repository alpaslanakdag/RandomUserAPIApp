using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;
using System;
using ApprenticeAspNetMvc.Web.Jason;

namespace apprenticeaspnetmvc.web.jason
{
    public class StringToDoubleConverter : JsonConverter<double>
    {
        //readonly jsonserializer _defaultserializer = new jsonserializer();

        

        public override double Read(ref Utf8JsonReader reader, Type objecttype, JsonSerializerOptions serializer)
        {
            var value = reader.GetString();

            if (double.TryParse(value,out double value2))
            {
                return value2;
            }
            else
            {
                return -1;
            }
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions serializer)
        {

            var item = value.ToString();
            writer.WriteNumberValue(Convert.ToDouble(item));

        }

       
    }

    public class NumberToStringConverter : JsonConverter<string>
    {
        

        public override string Read(ref Utf8JsonReader reader, Type objecttype,  JsonSerializerOptions serializer)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                var value = reader.GetInt32();
                return value.ToString();
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        // public override bool write { get { return false; } }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions serializer)
        {

            //var item = value.ToString();
            writer.WriteStringValue(value);

        }
    }
}
