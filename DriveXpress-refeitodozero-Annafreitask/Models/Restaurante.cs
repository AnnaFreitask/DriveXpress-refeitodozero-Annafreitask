using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DriveXpress_refeitodozero_Annafreitask.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Nome { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public Categoria Categoria { get; set; }

        public ICollection<Cardapio> Cardapios { get; set; } //restaurante possui uma coleção de produtos

        
    }
    public enum Categoria
    {
        Gourmet,
        Doces,
        Japonesa
    }
}
