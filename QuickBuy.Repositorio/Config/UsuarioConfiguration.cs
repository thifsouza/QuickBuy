using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            //builder utiliza o padrao fluent
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
               .Property(U => U.Senha)
               .IsRequired()
               .HasMaxLength(400);
               

            builder
                .Property(U => U.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
             .Property(U => U.Sobrenome)
             .IsRequired()
             .HasMaxLength(50);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);


        }
    }
}
