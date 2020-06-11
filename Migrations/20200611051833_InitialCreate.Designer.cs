﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalPresents.DataBase;

namespace PersonalPresents.Migrations
{
    [DbContext(typeof(AppDbContent))]
    [Migration("20200611051833_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("PersonalPresents.Models.PackageModels.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PresentsId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("PersonalPresents.Models.PackageModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Present")
                        .HasColumnType("TEXT");

                    b.Property<int>("PresentsId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PersonalPresents.Models.PackageModels.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "cash"
                        },
                        new
                        {
                            Id = 2,
                            Name = "card"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.Festival", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Festivals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New Year"
                        },
                        new
                        {
                            Id = 2,
                            Name = "23rd of February"
                        },
                        new
                        {
                            Id = 3,
                            Name = "8th of March"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Teacher's Day"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Happy Birhtday"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Anniversary"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Wedding"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Valentine's Day"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Wedding anniversary"
                        },
                        new
                        {
                            Id = 10,
                            Name = "High school graduation"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Housewarming"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Birth of a child"
                        },
                        new
                        {
                            Id = 13,
                            Name = "To visit"
                        },
                        new
                        {
                            Id = 14,
                            Name = "1st of September"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Other"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Doesn't matter"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Man"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Woman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Doesn't matter"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Traveler"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Geek"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hunter/fisherman"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Athlete"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cars"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fan"
                        },
                        new
                        {
                            Id = 7,
                            Name = "For home"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.Present", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("FestivalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InterestId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FestivalId");

                    b.HasIndex("GenderId");

                    b.HasIndex("InterestId");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Presents");
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Teacher"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Driver"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Doctor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Trainer"
                        },
                        new
                        {
                            Id = 5,
                            Name = "ITSpecialist"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Builder"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Lawyer"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Accountant"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Military"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Oilman"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sailor"
                        },
                        new
                        {
                            Id = 12,
                            Name = "LawOfficer"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Other"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Doesn't matter"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.RoleForUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RoleForUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mother"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Father"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Brother"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sister"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Grandmother"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Grandfather"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Wife"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Husbend"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Boyfriend"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Girlfriend"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Friend"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Boss"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Сolleague"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Other"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Doesn't matter"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@mail.ru",
                            Password = "123456",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("PersonalPresents.Models.PackageModels.Basket", b =>
                {
                    b.HasOne("PersonalPresents.Models.User", "user")
                        .WithMany("baskets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalPresents.Models.PackageModels.Order", b =>
                {
                    b.HasOne("PersonalPresents.Models.PackageModels.Payment", "payment")
                        .WithMany("orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalPresents.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalPresents.Models.PresentModels.Present", b =>
                {
                    b.HasOne("PersonalPresents.Models.PresentModels.Festival", "festival")
                        .WithMany("Presents")
                        .HasForeignKey("FestivalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalPresents.Models.PresentModels.Gender", "gender")
                        .WithMany("Presents")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalPresents.Models.PresentModels.Interest", "interest")
                        .WithMany("Presents")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalPresents.Models.PresentModels.Profession", "profession")
                        .WithMany("Presents")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalPresents.Models.PresentModels.RoleForUser", "role")
                        .WithMany("Presents")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonalPresents.Models.User", b =>
                {
                    b.HasOne("PersonalPresents.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
