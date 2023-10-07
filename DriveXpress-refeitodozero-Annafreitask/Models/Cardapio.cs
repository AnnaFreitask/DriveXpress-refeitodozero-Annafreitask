using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveXpress_refeitodozero_Annafreitask.Models
{
    [Table("Cardapio")]
    public class Cardapio
    {
        public class Cardapios
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


            [Required]
            public int RestauranteId { get; set; } //produto pertence a um unico restaurante (produto associado a Key de restaurante)

            public Cardapio Cardapio { get; set; } //retorna produtos do restaurante

        }
        public enum TipoProduto
        {
            Bebida,
            Comida
        }
    }
}
