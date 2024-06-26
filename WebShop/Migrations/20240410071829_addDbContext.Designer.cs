﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.Models;

namespace WebShop.Migrations
{
    [DbContext(typeof(dbMarketsContext))]
    [Migration("20240410071829_addDbContext")]
    partial class addDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebShop.ModelViews.LoginViewModel", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("LoginViewModel");
                });

            modelBuilder.Entity("WebShop.ModelViews.RegisterViewModel", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("CustomerId");

                    b.ToTable("RegisterViewModel");
                });

            modelBuilder.Entity("WebShop.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AccountID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleID");

                    b.Property<string>("Salt")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.HasKey("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            Active = true,
                            CreateDate = new DateTime(2024, 4, 10, 14, 18, 29, 49, DateTimeKind.Local).AddTicks(9025),
                            Email = "admin@gmail.com",
                            FullName = "Quản lý",
                            LastLogin = new DateTime(2024, 4, 10, 14, 18, 29, 48, DateTimeKind.Local).AddTicks(5727),
                            Password = "Admin123",
                            Phone = "0978719999",
                            RoleId = 1,
                            Salt = "Admin123"
                        });
                });

            modelBuilder.Entity("WebShop.Models.Attribute", b =>
                {
                    b.Property<int>("AttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AttributeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AttributeId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("WebShop.Models.AttributesPrice", b =>
                {
                    b.Property<int>("AttributesPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AttributesPriceID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("AttributeId")
                        .HasColumnType("int")
                        .HasColumnName("AttributeID");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.HasKey("AttributesPriceId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("AttributesPrices");
                });

            modelBuilder.Entity("WebShop.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CatID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CatName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Cover")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Levels")
                        .HasColumnType("int");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Ordering")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("SchemaMarkup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CatId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Alias = "rau",
                            CatName = "Rau",
                            Cover = "",
                            Description = "rau",
                            Levels = 1,
                            MetaDesc = "",
                            MetaKey = "",
                            Ordering = 1,
                            ParentId = 1,
                            Published = true,
                            SchemaMarkup = "",
                            Thumb = "rau1.png",
                            Title = ""
                        },
                        new
                        {
                            CatId = 2,
                            Alias = "cu",
                            CatName = "Củ",
                            Cover = "",
                            Description = "củ",
                            Levels = 1,
                            MetaDesc = "",
                            MetaKey = "",
                            Ordering = 1,
                            ParentId = 1,
                            Published = true,
                            SchemaMarkup = "",
                            Thumb = "cu.png",
                            Title = ""
                        },
                        new
                        {
                            CatId = 3,
                            Alias = "qua",
                            CatName = "Quả",
                            Cover = "",
                            Description = "quả",
                            Levels = 1,
                            MetaDesc = "",
                            MetaKey = "",
                            Ordering = 1,
                            ParentId = 1,
                            Published = true,
                            SchemaMarkup = "",
                            Thumb = "qua.png",
                            Title = ""
                        });
                });

            modelBuilder.Entity("WebShop.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Avatar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("District")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nchar(150)")
                        .IsFixedLength(true);

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Salt")
                        .HasMaxLength(8)
                        .HasColumnType("nchar(8)")
                        .IsFixedLength(true);

                    b.Property<int?>("Ward")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebShop.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<int?>("Levels")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameWithType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Parent")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WebShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int?>("District")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    b.Property<DateTime?>("ShipDate")
                        .HasColumnType("datetime");

                    b.Property<int>("TotalMoney")
                        .HasColumnType("int");

                    b.Property<int?>("TransactStatusId")
                        .HasColumnType("int")
                        .HasColumnName("TransactStatusID");

                    b.Property<int?>("Ward")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TransactStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("TotalMoney")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebShop.Models.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PageID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Ordering")
                        .HasColumnType("int");

                    b.Property<string>("PageName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Thumb")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("PageId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("WebShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Alias")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("BestSellers")
                        .HasColumnType("bit");

                    b.Property<int?>("CatId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("CatID");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<bool>("HomeFlag")
                        .HasColumnType("bit");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ShortDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("UnitsInStock")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Video")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ProductId");

                    b.HasIndex("CatId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Active = true,
                            Alias = "rau-muong",
                            BestSellers = true,
                            CatId = 1,
                            DateCreated = new DateTime(2024, 4, 10, 14, 18, 29, 50, DateTimeKind.Local).AddTicks(8092),
                            DateModified = new DateTime(2024, 4, 10, 14, 18, 29, 50, DateTimeKind.Local).AddTicks(8374),
                            Description = "",
                            Discount = 1200,
                            HomeFlag = true,
                            MetaDesc = "",
                            MetaKey = "",
                            Price = 6000,
                            ProductName = "Rau Muống",
                            ShortDesc = "Rau muống là một loài thực vật nhiệt đới bán thủy sinh thuộc họ Bìm bìm, là một loại rau ăn lá",
                            Tags = "",
                            Thumb = "rau-muong.jpg",
                            Title = "Rau muống tươi ngon ngọt và luộc lên uống rất mát",
                            UnitsInStock = 50
                        });
                });

            modelBuilder.Entity("WebShop.Models.QuangCao", b =>
                {
                    b.Property<int>("QuangCaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("QuangCaoID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ImageBg")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("ImageBG");

                    b.Property<string>("ImageProduct")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SubTitle")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UrlLink")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("QuangCaoId");

                    b.ToTable("QuangCaos");
                });

            modelBuilder.Entity("WebShop.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RoleID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Description = "admin",
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            Description = "customer",
                            RoleName = "Customer"
                        });
                });

            modelBuilder.Entity("WebShop.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ShipperID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<DateTime?>("ShipDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipperName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("WebShop.Models.TinDang", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PostID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("AccountID");

                    b.Property<string>("Alias")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Author")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("CatId")
                        .HasColumnType("int")
                        .HasColumnName("CatID");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsHot")
                        .HasColumnType("bit")
                        .HasColumnName("isHot");

                    b.Property<bool>("IsNewfeed")
                        .HasColumnType("bit")
                        .HasColumnName("isNewfeed");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Scontents")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("SContents");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Views")
                        .HasColumnType("int");

                    b.HasKey("PostId")
                        .HasName("PK_tblTinTucs");

                    b.ToTable("TinDangs");
                });

            modelBuilder.Entity("WebShop.Models.TransactStatus", b =>
                {
                    b.Property<int>("TransactStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TransactStatusID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TransactStatusId");

                    b.ToTable("TransactStatus");

                    b.HasData(
                        new
                        {
                            TransactStatusId = 1,
                            Description = "Chờ xác nhận",
                            Status = "Chờ xác nhận"
                        },
                        new
                        {
                            TransactStatusId = 2,
                            Description = "Đã xác nhận",
                            Status = "Đã xác nhận"
                        },
                        new
                        {
                            TransactStatusId = 3,
                            Description = "Đã lấy hàng",
                            Status = "Đã lấy hàng"
                        },
                        new
                        {
                            TransactStatusId = 4,
                            Description = "Đang giao hàng",
                            Status = "Đang giao hàng"
                        },
                        new
                        {
                            TransactStatusId = 5,
                            Description = "Hoàn thành",
                            Status = "Hoàn thành"
                        });
                });

            modelBuilder.Entity("WebShop.Models.Account", b =>
                {
                    b.HasOne("WebShop.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Accounts_Roles");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebShop.Models.AttributesPrice", b =>
                {
                    b.HasOne("WebShop.Models.Attribute", "Attribute")
                        .WithMany("AttributesPrices")
                        .HasForeignKey("AttributeId")
                        .HasConstraintName("FK_AttributesPrices_Attributes");

                    b.HasOne("WebShop.Models.Product", "Product")
                        .WithMany("AttributesPrices")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_AttributesPrices_Products");

                    b.Navigation("Attribute");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShop.Models.Order", b =>
                {
                    b.HasOne("WebShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("WebShop.Models.TransactStatus", "TransactStatus")
                        .WithMany("Orders")
                        .HasForeignKey("TransactStatusId")
                        .HasConstraintName("FK_Orders_TransactStatus");

                    b.Navigation("Customer");

                    b.Navigation("TransactStatus");
                });

            modelBuilder.Entity("WebShop.Models.OrderDetail", b =>
                {
                    b.HasOne("WebShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderDetails_Orders");

                    b.HasOne("WebShop.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderDetails_Products");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShop.Models.Product", b =>
                {
                    b.HasOne("WebShop.Models.Category", "Cat")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .HasConstraintName("FK_Products_Categories")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("WebShop.Models.Attribute", b =>
                {
                    b.Navigation("AttributesPrices");
                });

            modelBuilder.Entity("WebShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebShop.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebShop.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("WebShop.Models.Product", b =>
                {
                    b.Navigation("AttributesPrices");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("WebShop.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("WebShop.Models.TransactStatus", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
