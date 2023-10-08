using DriveXpress_refeitodozero_Annafreitask.Models.DriveXpress_refeitodozero_Annafreitask.Models;
using Microsoft.EntityFrameworkCore;

namespace DriveXpress_refeitodozero_Annafreitask.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RestaurantesUsuarios>()
                .HasKey(c => new { c.RestauranteId, c.UsuarioId });

            builder.Entity<RestaurantesUsuarios>()
                .HasOne(c => c.Restaurante).WithMany(c => c.Usuarios)
                .HasForeignKey(c => c.RestauranteId);

            builder.Entity<RestaurantesUsuarios>()
                .HasOne(c => c.Usuario).WithMany(c => c.Restaurantes)
                .HasForeignKey(c => c.UsuarioId);
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Cardapio> Cardapios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RestaurantesUsuarios> RestaurantesUsuarios { get; set; }





    }
}