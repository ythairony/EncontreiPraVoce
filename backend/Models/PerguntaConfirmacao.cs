using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EncontreiPraVoce.Models
{
    public class PerguntaConfirmacao
    {
        public int Id { get; set; }
        public required string Pergunta { get; set; }

        // Uma pergunta tem 3 opções
        public List<OpcaoResposta> Opcoes { get; set; } = new();

        // Chave para o post
        public int AcheiNaRuaPostId { get; set; }
        [JsonIgnore]
        public AcheiNaRuaPost? AcheiNaRuaPost { get; set; }
    }
}