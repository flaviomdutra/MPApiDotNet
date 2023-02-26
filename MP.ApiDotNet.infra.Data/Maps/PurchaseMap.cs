﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MP.ApiDotNet.Domain.Entities;

namespace MP.ApiDotNet.infra.Data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("compra");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("idcompra").UseIdentityColumn();

            builder.Property(x => x.PersonId).HasColumnName("idpessoa");

            builder.Property(x => x.ProductId).HasColumnName("idproduto");

            builder.Property(x => x.Date).HasColumnName("datacompra");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Purchases);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Purchases);
        }
    }
}

