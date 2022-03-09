using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using apprenticeaspnetmvc.web.jason;

namespace ApprenticeAspNetMvc.Web.Jason
{
    public class RootObject
    {
        
            [JsonPropertyName("results")]
            public Result[] Results { get; set; }

           
       }

      

        public partial class Result
        {
            [JsonPropertyName("gender")]
            public string Gender { get; set; }

            [JsonPropertyName("name")]
            public Name Name { get; set; }

            [JsonPropertyName("location")]
            public Location Location { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("login")]
            public Login Login { get; set; }

            [JsonPropertyName("dob")]
            public Dob Dob { get; set; }

            [JsonPropertyName("registered")]
            public Dob Registered { get; set; }

            [JsonPropertyName("phone")]
            public string Phone { get; set; }

            [JsonPropertyName("cell")]
            public string Cell { get; set; }

           

            [JsonPropertyName("picture")]
            public Picture Picture { get; set; }

            [JsonPropertyName("nat")]
            public string Nat { get; set; }
        }

        public partial class Dob
        {
            [JsonPropertyName("date")]
            public DateTimeOffset Date { get; set; }

            
        }

        

        public partial class Location
        {
            [JsonPropertyName("street")]
            public Street Street { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("postcode")]
            [JsonConverter(typeof(NumberToStringConverter))]
            public string Postcode { get; set; }

            [JsonPropertyName("coordinates")]
            public Coordinates Coordinates { get; set; }

            [JsonPropertyName("timezone")]
            public Timezone Timezone { get; set; }
        }

        public partial class Coordinates
        {
            [JsonPropertyName("latitude")]
            [JsonConverter(typeof(StringToDoubleConverter))]
            public double Latitude { get; set; }

            [JsonPropertyName("longitude")]
            [JsonConverter(typeof(StringToDoubleConverter))]
             public double Longitude { get; set; }

        }

    

    public partial class Street
        {
            
            //[JsonIgnore]
            //public long Number { get; set; }

            //[JsonPropertyName("number")]
            //public string NumberAsString
            //{

            //    get
            //    {
            //        return Number.ToString();
            //    }
            //    set
            //    {
            //        Number = long.Parse(value);
            //    }
            //}

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public partial class Timezone
        {
            [JsonPropertyName("offset")]
            public string Offset { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }
        }

        public partial class Login
        {
            [JsonPropertyName("uuid")]
            public Guid Uuid { get; set; }

            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("password")]
            public string Password { get; set; }

            [JsonPropertyName("salt")]
            public string Salt { get; set; }

            [JsonPropertyName("md5")]
            public string Md5 { get; set; }

            [JsonPropertyName("sha1")]
            public string Sha1 { get; set; }

            [JsonPropertyName("sha256")]
            public string Sha256 { get; set; }
        }

        public partial class Name
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("first")]
            public string First { get; set; }

            [JsonPropertyName("last")]
            public string Last { get; set; }
        }

        public partial class Picture
        {
            [JsonPropertyName("large")]
            public Uri Large { get; set; }

            [JsonPropertyName("medium")]
            public Uri Medium { get; set; }

            [JsonPropertyName("thumbnail")]
            public Uri Thumbnail { get; set; }
        }

   

    
}

