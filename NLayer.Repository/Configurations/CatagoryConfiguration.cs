﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class CatagoryConfiguration : IEntityTypeConfiguration<Catagory>
    {
        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.ToTable("Catagories");

            



        }
    }
}