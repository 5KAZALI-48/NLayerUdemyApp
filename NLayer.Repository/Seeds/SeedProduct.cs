using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class SeedProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CatagoryId = 1,
                Name = "Dolma Kalem",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                Id = 2,
                CatagoryId = 1,
                Name = "Pilot Kalem",
                Price = 75,
                Stock = 20,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                Id = 3,
                CatagoryId = 1,
                Name = "Kursun Kalem",
                Price = 50,
                Stock = 20,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                Id = 4,
                CatagoryId = 2,
                Name = "Programlamaya Giris",
                Price = 250,
                Stock = 20,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                Id = 5,
                CatagoryId = 2,
                Name = "C# Ogreniyorum",
                Price = 300,
                Stock = 20,
                CreatedDate = DateTime.Now,
            }) ;
        }
    }
}
