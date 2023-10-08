using DriveXpress_refeitodozero_Annafreitask.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DriveXpress_refeitodozero_Annafreitask.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    namespace DriveXpress_refeitodozero_Annafreitask.Models
    {
        [Table("Usuario")]
        public class Usuario: LinksHATEOS
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Nome { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            [JsonIgnore]
            public string Senha { get; set; }
            [Required]
            public PerfilUsuario Perfil { get; set; }

            public ICollection<RestaurantesUsuarios> Restaurantes { get; set; } //usuario possui uma coleção de restaurantes. usuario possui varios restaurantes

        }

        public enum PerfilUsuario
        {
            [Display(Name = "Cliente")]
            Cliente,
            [Display(Name = "Funcionario")]
            Funcionario,
            [Display(Name = "Gerente")]
            Gerente
        }
    }

}