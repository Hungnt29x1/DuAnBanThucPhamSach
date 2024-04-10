using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Security.AccessControl;
using System.Security.Policy;
using WebShop.Models;

namespace WebShop.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin", Description = "admin" },
                new Role { RoleId = 2, RoleName = "Customer", Description = "customer" }
            );
            modelBuilder.Entity<Account>().HasData(
                new Account { AccountId = 1, Phone = "0978719999", Email = "admin@gmail.com", Password = "Admin123", Salt = "Admin123", Active = true, FullName = "Quản lý", RoleId = 1, LastLogin = DateTime.Now, CreateDate = DateTime.Now }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category{CatId = 1,CatName = "Rau",Description = "rau",ParentId = 1,Levels = 1,Ordering = 1,Published = true,Thumb = "rau1.png",Title = "",Alias = "rau",MetaDesc = "",MetaKey = "",Cover = "",SchemaMarkup = ""},
                new Category{CatId = 2,CatName = "Củ",Description = "củ",ParentId = 1,Levels = 1,Ordering = 1,Published = true,Thumb = "cu.png",Title = "",Alias = "cu",MetaDesc = "",MetaKey = "",Cover = "",SchemaMarkup = ""},
                new Category{CatId = 3,CatName = "Quả",Description = "quả",ParentId = 1,Levels = 1,Ordering = 1,Published = true,Thumb = "qua.png",Title = "",Alias = "qua",MetaDesc = "",MetaKey = "",Cover = "",SchemaMarkup = ""}
            );
            modelBuilder.Entity<Product>().HasData(
               new Product {ProductId = 1,ProductName = "Rau Muống",ShortDesc = "Rau muống là một loài thực vật nhiệt đới bán thủy sinh thuộc họ Bìm bìm, là một loại rau ăn lá",Description = "",CatId = 1,Price = 6000,Discount = 1200,Thumb = "rau-muong.jpg",Video= null,DateCreated = DateTime.Now,DateModified = DateTime.Now,BestSellers = true,HomeFlag = true,Active = true,Tags = "",Title = "Rau muống tươi ngon ngọt và luộc lên uống rất mát",Alias = "rau-muong",MetaDesc = "",MetaKey= "",UnitsInStock = 50}
            );
            modelBuilder.Entity<TransactStatus>().HasData(
                new TransactStatus { TransactStatusId = 1, Status = "Chờ xác nhận", Description = "Chờ xác nhận" },
                new TransactStatus { TransactStatusId = 2, Status = "Đã xác nhận", Description = "Đã xác nhận" },
                new TransactStatus { TransactStatusId = 3, Status = "Đã lấy hàng", Description = "Đã lấy hàng" },
                new TransactStatus { TransactStatusId = 4, Status = "Đang giao hàng", Description = "Đang giao hàng" },
                new TransactStatus { TransactStatusId = 5, Status = "Hoàn thành", Description = "Hoàn thành" }
            );
        }
    }
}
