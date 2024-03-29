﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PixApi.Models;

namespace PixApi.Data.Map
{
    public class ClientMap : IEntityTypeConfiguration<ClientModel>
    {
        public void Configure(EntityTypeBuilder<ClientModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.ClientKeyId);

            builder.HasOne(x => x.Key).WithMany().HasForeignKey(x => x.ClientKeyId)
                .IsRequired(false).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
