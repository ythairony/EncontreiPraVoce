using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EncontreiPraVoce.Models
{
    public class OpcaoResposta
    {
        public int Id { get; set; }
        public required string Texto { get; set; }
        public bool EhCorreta { get; set; } = false;

        public int PerguntaConfirmacaoId { get; set; }
        [JsonIgnore]  //Impede que a propriedade seja enviada de volta em um loop infinito
        public PerguntaConfirmacao? perguntaConfirmacao { get; set; }
    }
}