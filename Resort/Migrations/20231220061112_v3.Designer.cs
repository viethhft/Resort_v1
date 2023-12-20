﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resort.Context;

#nullable disable

namespace Resort.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231220061112_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Resort.Models.Commune", b =>
                {
                    b.Property<int>("IdCommune")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCommune"));

                    b.Property<int>("IdDistrict")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCommune");

                    b.HasIndex("IdDistrict");

                    b.ToTable("Communes");
                });

            modelBuilder.Entity("Resort.Models.Convenient", b =>
                {
                    b.Property<int>("IdConvenient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConvenient"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdConvenient");

                    b.ToTable("Convenients");
                });

            modelBuilder.Entity("Resort.Models.ConvenientResort", b =>
                {
                    b.Property<int>("IdConvenient")
                        .HasColumnType("int");

                    b.Property<int>("IdResort")
                        .HasColumnType("int");

                    b.HasKey("IdConvenient", "IdResort");

                    b.HasIndex("IdResort");

                    b.ToTable("ConvenientResorts");
                });

            modelBuilder.Entity("Resort.Models.District", b =>
                {
                    b.Property<int>("IdDistrict")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDistrict"));

                    b.Property<int>("IdProvince")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDistrict");

                    b.HasIndex("IdProvince");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Resort.Models.Province", b =>
                {
                    b.Property<int>("IdProvince")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProvince"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProvince");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Resort.Models.Rate", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdResort")
                        .HasColumnType("int");

                    b.Property<int>("RateStar")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdResort");

                    b.HasIndex("IdResort");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Resort.Models.Resort", b =>
                {
                    b.Property<int>("IdResort")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdResort"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCommune")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Thumb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdResort");

                    b.HasIndex("IdCommune");

                    b.ToTable("Resorts");
                });

            modelBuilder.Entity("Resort.Models.ResortDetail", b =>
                {
                    b.Property<int>("IdResortDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdResortDetail"));

                    b.Property<string>("AddressDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdResort")
                        .HasColumnType("int");

                    b.Property<string>("ListImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdResortDetail");

                    b.HasIndex("IdResort")
                        .IsUnique();

                    b.ToTable("ResortDetails");
                });

            modelBuilder.Entity("Resort.Models.ResortDetailServices", b =>
                {
                    b.Property<int>("IdService")
                        .HasColumnType("int");

                    b.Property<int>("IdResortDetail")
                        .HasColumnType("int");

                    b.HasKey("IdService", "IdResortDetail");

                    b.HasIndex("IdResortDetail");

                    b.ToTable("ResortDetailServices");
                });

            modelBuilder.Entity("Resort.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Resort.Models.Service", b =>
                {
                    b.Property<int>("IdService")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdService"));

                    b.Property<string>("NameService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdService");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Resort.Models.TypeRoom", b =>
                {
                    b.Property<int>("IdTypeRoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTypeRoom"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTypeRoom");

                    b.ToTable("TypeRooms");
                });

            modelBuilder.Entity("Resort.Models.TypeRoomResortDetail", b =>
                {
                    b.Property<int>("IdTypeRoom")
                        .HasColumnType("int");

                    b.Property<int>("IdResortDetail")
                        .HasColumnType("int");

                    b.HasKey("IdTypeRoom", "IdResortDetail");

                    b.HasIndex("IdResortDetail");

                    b.ToTable("TypeRoomResortDetails");
                });

            modelBuilder.Entity("Resort.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.HasIndex("IdRole")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Resort.Models.UserDetail", b =>
                {
                    b.Property<int>("IdUserDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUserDetail"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("ImageProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUserDetail");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("Resort.Models.Commune", b =>
                {
                    b.HasOne("Resort.Models.District", "District")
                        .WithMany("Communes")
                        .HasForeignKey("IdDistrict")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("Resort.Models.ConvenientResort", b =>
                {
                    b.HasOne("Resort.Models.Convenient", "Convenient")
                        .WithMany("ConvenientResorts")
                        .HasForeignKey("IdConvenient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resort.Models.Resort", "Resort")
                        .WithMany("ConvenientResorts")
                        .HasForeignKey("IdResort")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Convenient");

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("Resort.Models.District", b =>
                {
                    b.HasOne("Resort.Models.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("IdProvince")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Resort.Models.Rate", b =>
                {
                    b.HasOne("Resort.Models.Resort", "Resort")
                        .WithMany("Rates")
                        .HasForeignKey("IdResort")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resort.Models.User", "User")
                        .WithMany("Rates")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resort");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Resort.Models.Resort", b =>
                {
                    b.HasOne("Resort.Models.Commune", "Commune")
                        .WithMany("Resort")
                        .HasForeignKey("IdCommune")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commune");
                });

            modelBuilder.Entity("Resort.Models.ResortDetail", b =>
                {
                    b.HasOne("Resort.Models.Resort", "Resort")
                        .WithOne("ResortDetail")
                        .HasForeignKey("Resort.Models.ResortDetail", "IdResort")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("Resort.Models.ResortDetailServices", b =>
                {
                    b.HasOne("Resort.Models.ResortDetail", "ResortDetail")
                        .WithMany("ResortDetailServices")
                        .HasForeignKey("IdResortDetail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resort.Models.Service", "Service")
                        .WithMany("ResortDetailServices")
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResortDetail");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Resort.Models.TypeRoomResortDetail", b =>
                {
                    b.HasOne("Resort.Models.ResortDetail", "ResortDetail")
                        .WithMany("TypeRoomResortDetails")
                        .HasForeignKey("IdResortDetail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Resort.Models.TypeRoom", "TypeRoom")
                        .WithMany("TypeRoomResortDetails")
                        .HasForeignKey("IdTypeRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResortDetail");

                    b.Navigation("TypeRoom");
                });

            modelBuilder.Entity("Resort.Models.User", b =>
                {
                    b.HasOne("Resort.Models.Role", "Role")
                        .WithOne("User")
                        .HasForeignKey("Resort.Models.User", "IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Resort.Models.UserDetail", b =>
                {
                    b.HasOne("Resort.Models.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("Resort.Models.UserDetail", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Resort.Models.Commune", b =>
                {
                    b.Navigation("Resort");
                });

            modelBuilder.Entity("Resort.Models.Convenient", b =>
                {
                    b.Navigation("ConvenientResorts");
                });

            modelBuilder.Entity("Resort.Models.District", b =>
                {
                    b.Navigation("Communes");
                });

            modelBuilder.Entity("Resort.Models.Province", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Resort.Models.Resort", b =>
                {
                    b.Navigation("ConvenientResorts");

                    b.Navigation("Rates");

                    b.Navigation("ResortDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Resort.Models.ResortDetail", b =>
                {
                    b.Navigation("ResortDetailServices");

                    b.Navigation("TypeRoomResortDetails");
                });

            modelBuilder.Entity("Resort.Models.Role", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Resort.Models.Service", b =>
                {
                    b.Navigation("ResortDetailServices");
                });

            modelBuilder.Entity("Resort.Models.TypeRoom", b =>
                {
                    b.Navigation("TypeRoomResortDetails");
                });

            modelBuilder.Entity("Resort.Models.User", b =>
                {
                    b.Navigation("Rates");

                    b.Navigation("UserDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
