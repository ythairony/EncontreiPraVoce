using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncontreiPraVoce
{
    public class AcheiNaRuaPost
    {
        public int Id { get; set; }
        public required string NomeProduto { get; set; }
        public required string LocalEncontrado { get; set; }
        public DateTime DataEncontrado { get; set; }
        public DateTime DataPostagem { get; set; }

        //Categoria
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }


        // Usuário
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }


        // Lista das 3 perguntas
        public List<PerguntaConfirmacao> PerguntaConfirmacao { get; set; } = new();
    }
}