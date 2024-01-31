using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Repository.Seeds
{
    internal class CatagorySeed : IEntityTypeConfiguration<Catagory>
    {
        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            builder.HasData(new Catagory { Id = 1, Name = "Kalemler" },
                            new Catagory { Id = 2, Name = "Kitaplar" },
                            new Catagory { Id = 3, Name = "Defterler" });
        }
    }
}
