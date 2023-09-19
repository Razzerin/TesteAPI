using System.Text.Json;
using System.Text.Json.Serialization;

namespace AeCTeste.Models
{

    public partial class ClimaAeroModel
    {
        [JsonPropertyName("codigo_icao")]
        public string? CodigoIcao { get; set; }

        [JsonPropertyName("atualizado_em")]
        public DateTimeOffset? AtualizadoEm { get; set; }

        [JsonPropertyName("pressao_atmosferica")]
        public long? PressaoAtmosferica { get; set; }

        [JsonPropertyName("visibilidade")]
        public long? Visibilidade { get; set; }

        [JsonPropertyName("vento")]
        public long? Vento { get; set; }

        [JsonPropertyName("direcao_vento")]
        public long? DirecaoVento { get; set; }

        [JsonPropertyName("umidade")]
        public long? Umidade { get; set; }

        [JsonPropertyName("condicao")]
        public string? Condicao { get; set; }

        [JsonPropertyName("condicao_Desc")]
        public string? CondicaoDesc { get; set; }

        [JsonPropertyName("temp")]
        public long? Temp { get; set; }
    }
}
