﻿using DriveXpress_refeitodozero_Annafreitask.Models;
using Microsoft.EntityFrameworkCore;

namespace DriveXpress_refeitodozero_Annafreitask.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }

    }
}