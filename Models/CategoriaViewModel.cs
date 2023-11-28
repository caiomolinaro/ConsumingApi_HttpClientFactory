using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HttpClientFactory.Models
{
    public class CategoriaViewModel
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Você precisa escrever um nome")]
        public string? Nome { get; set; }

        [Display(Name = "Imagem")]
        public string? ImagemUrl { get; set; }
    }
}