using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncontreiPraVoce
{
    public class PerdiNaRuaPost
    {
        public int Id { get; set; }
        public required string NomeItem { get; set; }
        public string? FotoUrl { get; set; }
        public required string Descricao { get; set; }
        public required string LocalPerdido { get; set; }
        public required string TelefoneContato { get; set; }
        public DateTime DataPostagem { get; set; }

        // Usuário
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }
    }
}