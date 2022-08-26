using System.Text.Json.Serialization; 
namespace TP1Taller2.Clases{ 

    public class Provincia
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }

}