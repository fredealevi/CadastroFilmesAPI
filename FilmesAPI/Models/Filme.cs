using FsCheck;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Titulo { get; set; }
        
        [Required]
        public string Diretor { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(30, ErrorMessage = "Máximo 15 caractéres. ")]
        public string Genero { get; set; }
        
        [Required(ErrorMessage ="Campo Obrigatório.")]
        [Range (1, 600)]
        public int Duracao { get; set; }

    }
}
