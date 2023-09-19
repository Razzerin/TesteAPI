using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeCTeste.API
{
    public partial class ClimaCidade
    {
        [JsonProperty("codigo_icao")]
        public string CodigoIcao { get; set; }

        [JsonProperty("atualizado_em")]
        public DateTimeOffset AtualizadoEm { get; set; }

        [JsonProperty("pressao_atmosferica")]
        public long PressaoAtmosferica { get; set; }

        [JsonProperty("visibilidade")]
        public long Visibilidade { get; set; }

        [JsonProperty("vento")]
        public long Vento { get; set; }

        [JsonProperty("direcao_vento")]
        public long DirecaoVento { get; set; }

        [JsonProperty("umidade")]
        public long Umidade { get; set; }

        [JsonProperty("condicao")]
        public string Condicao { get; set; }

        [JsonProperty("condicao_Desc")]
        public string CondicaoDesc { get; set; }

        [JsonProperty("temp")]
        public long Temp { get; set; }
    }
}
