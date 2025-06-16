using System.ComponentModel.DataAnnotations;

namespace EncontreiPraVoce.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Nome { get; set; }

        //Caminho da imagem
        public required string ImagemItemUrl { get; set; }
    }
}