using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveXpress_refeitodozero_Annafreitask.Models
{
    [Table("Cardapio")]
    public class Cardapio
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Nome { get; set; }
            [Required]
            public int Quantidade { get; set; }
            [Required]
            public string Descricao { get; set; }
            [Required]
            public double Valor { get; set; }
            [Required]
            public TipoProduto Tipo { get; set; }
            
    }
    public enum TipoProduto
    {
        Bebida,
        Comida,
        Sobremesa
    }
}
