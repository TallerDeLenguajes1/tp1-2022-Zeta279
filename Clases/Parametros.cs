using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace TP1Taller2.Clases{ 

    public class Parametros
    {
        [JsonPropertyName("campos")]
        public List<string> Campos { get; set; }
    }

}