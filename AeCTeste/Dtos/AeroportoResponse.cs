namespace AeCTeste.Dtos
{
    public class AeroportoResponse
    {

        public string? CodigoIcao { get; set; }
        public DateTimeOffset? AtualizadoEm { get; set; }
        public long? PressaoAtmosferica { get; set; }
        public long? Visibilidade { get; set; }
        public long? Vento { get; set; }
        public long? DirecaoVento { get; set; }
        public long? Umidade { get; set; }
        public string? Condicao { get; set; }
        public string? CondicaoDesc { get; set; }
        public long? Temp { get; set; }
    }
}
