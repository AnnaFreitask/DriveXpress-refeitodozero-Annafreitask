using DriveXpress_refeitodozero_Annafreitask.Models.DriveXpress_refeitodozero_Annafreitask.Models;

using System.ComponentModel.DataAnnotations.Schema;



namespace DriveXpress_refeitodozero_Annafreitask.Models

{

    [Table("RestauranteUsuarios")]

    public class RestauranteUsuarios

    {

        public int RestauranteId { get; set; }

        public Restaurante Restaurante { get; set; }



        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    }

}