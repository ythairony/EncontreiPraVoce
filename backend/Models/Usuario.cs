using System.ComponentModel.DataAnnotations; // Usado para validações

namespace EncontreiPraVoce.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string NomeUsuario { get; set; }

        [Required]
        public required string SenhaHash { get; set; }

        [Required]
        [MaxLength(100)]
        public required string NomeCompleto { get; set; }

        [Required]
        [MaxLength(11)]
        public required string TelefoneContato { get; set; }
    }
}