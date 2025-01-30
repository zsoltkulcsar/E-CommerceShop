﻿using Discount.Grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data
{
    public class DiscountContext : DbContext
    {
        public DbSet<Coupon> Coupons { get; set; } = default!;

        public DiscountContext(DbContextOptions<DiscountContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().HasData(
                    new Coupon { Id = 1, ProductName = "Iphone XX", Description = "Very good phone", Amount = 123 },
                    new Coupon { Id = 2, ProductName = "Samsung 30", Description = "Very good phone", Amount = 123 }
                );
        }
    }
}
