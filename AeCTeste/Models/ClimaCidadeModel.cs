using System.Text.Json.Serialization;

namespace AeCTeste.Models
{
    public partial class ClimaCidadeModel
    {
      
            [JsonPropertyName("cidade")]
            public string? Cidade { get; set; }

            [JsonPropertyName("estado")]
            public string? Estado { get; set; }

            [JsonPropertyName("atualizado_em")]
            public DateTimeOffset? AtualizadoEm { get; set; }

            [JsonPropertyName("clima")]
            public Clima[]? Clima { get; set; }
    }

        public partial class Clima
        {
            [JsonPropertyName("data")]
            public DateTimeOffset? Data { get; set; }

            [JsonPropertyName("condicao")]
            public string? Condicao { get; set; }

            [JsonPropertyName("min")]
            public long? Min { get; set; }

            [JsonPropertyName("max")]
            public long? Max { get; set; }

            [JsonPropertyName("indice_uv")]
            public long? IndiceUv { get; set; }

            [JsonPropertyName("condicao_desc")]
            public string? CondicaoDesc { get; set; }
        }
    
}



