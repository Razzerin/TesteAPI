using AeCTeste.Models;
using System.Text.Json.Serialization;

namespace AeCTeste.Dtos
{
    public class CidadeResponse
    {

        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public DateTimeOffset? AtualizadoEm { get; set; }
        public Clima[]? Clima { get; set; }
    }

    public partial class Clima
    {
        public DateTimeOffset? Data { get; set; }
        public string? Condicao { get; set; }
        public long? Min { get; set; }
        public long? Max { get; set; }
        public long? IndiceUv { get; set; }
        public string? CondicaoDesc { get; set; }

    }
}
