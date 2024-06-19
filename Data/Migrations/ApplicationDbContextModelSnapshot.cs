﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingPlanApp.Web.Data;

#nullable disable

namespace TrainingPlanApp.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "543bced5-375b-5291-0a59-1dc59923d1b0",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "543bced5-375b-5291-0a59-1dc59923d1b1",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "654bced5-375b-5291-0a59-1dc59923d1b0",
                            RoleId = "543bced5-375b-5291-0a59-1dc59923d1b0"
                        },
                        new
                        {
                            UserId = "654bced5-375b-5291-0a59-1dc59923d1b1",
                            RoleId = "543bced5-375b-5291-0a59-1dc59923d1b1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.Diet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BreakfastId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DinnerId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("LunchId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SecondBreakfastId")
                        .HasColumnType("int");

                    b.Property<int?>("SnackId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BreakfastId");

                    b.HasIndex("DinnerId");

                    b.HasIndex("LunchId");

                    b.HasIndex("SecondBreakfastId");

                    b.HasIndex("SnackId");

                    b.ToTable("Diets");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalExerciseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdditionalExerciseNumberOfRepeats")
                        .HasColumnType("int");

                    b.Property<string>("AdditionalExerciseVideoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainExerciseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MainExerciseNumberOfRepeats")
                        .HasColumnType("int");

                    b.Property<string>("MainExerciseVideoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OverallNumberOfSets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.Ingredient", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("MealCreateVMId")
                        .HasColumnType("int");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServingSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealCreateVMId");

                    b.HasIndex("MealId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.Meal", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("Carbs")
                        .HasColumnType("int");

                    b.Property<int?>("Fat")
                        .HasColumnType("int");

                    b.Property<int?>("Kcal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Protein")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.TrainingPlan", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExerciseFirstId")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseFourthId")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseSecondId")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseThirdId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseFirstId");

                    b.HasIndex("ExerciseFourthId");

                    b.HasIndex("ExerciseSecondId");

                    b.HasIndex("ExerciseThirdId");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBith")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "654bced5-375b-5291-0a59-1dc59923d1b0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "acd4b6a3-3926-43a3-8094-dd13bdeeb7d5",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAR7GhFnA9m9zMUcN3Cyl2gYGojSL/APgmW1vtD/0IU5imjz6NsvWiR59U6RcRK+Dw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ebcd9e97-e260-4e21-b7fd-f53b99a10725",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "654bced5-375b-5291-0a59-1dc59923d1b1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b989947-df16-47af-891d-377e5e2c773e",
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            NormalizedUserName = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECHx2liRzAghwo6Z5oswxYiGKb48zf/GlFLzC7de6T93ItVVmjnwpylHKnPujSxhcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cab1428b-6456-4219-a4c8-215baa6555f9",
                            TwoFactorEnabled = false,
                            UserName = "user@localhost.com"
                        });
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Models.MealCreateVM", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("Carbs")
                        .HasColumnType("int");

                    b.Property<int?>("Fat")
                        .HasColumnType("int");

                    b.Property<string>("IngredientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IngredientServingSize")
                        .HasColumnType("int");

                    b.Property<int?>("Kcal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Protein")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MealCreateVM");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TrainingPlanApp.Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TrainingPlanApp.Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingPlanApp.Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TrainingPlanApp.Web.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.Diet", b =>
                {
                    b.HasOne("TrainingPlanApp.Web.Data.Meal", "Breakfast")
                        .WithMany()
                        .HasForeignKey("BreakfastId");

                    b.HasOne("TrainingPlanApp.Web.Data.Meal", "Dinner")
                        .WithMany()
                        .HasForeignKey("DinnerId");

                    b.HasOne("TrainingPlanApp.Web.Data.Meal", "Lunch")
                        .WithMany()
                        .HasForeignKey("LunchId");

                    b.HasOne("TrainingPlanApp.Web.Data.Meal", "SecondBreakfast")
                        .WithMany()
                        .HasForeignKey("SecondBreakfastId");

                    b.HasOne("TrainingPlanApp.Web.Data.Meal", "Snack")
                        .WithMany()
                        .HasForeignKey("SnackId");

                    b.Navigation("Breakfast");

                    b.Navigation("Dinner");

                    b.Navigation("Lunch");

                    b.Navigation("SecondBreakfast");

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.Ingredient", b =>
                {
                    b.HasOne("TrainingPlanApp.Web.Models.MealCreateVM", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("MealCreateVMId");

                    b.HasOne("TrainingPlanApp.Web.Data.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Data.TrainingPlan", b =>
                {
                    b.HasOne("TrainingPlanApp.Web.Data.Exercise", "ExerciseFirst")
                        .WithMany()
                        .HasForeignKey("ExerciseFirstId");

                    b.HasOne("TrainingPlanApp.Web.Data.Exercise", "ExerciseFourth")
                        .WithMany()
                        .HasForeignKey("ExerciseFourthId");

                    b.HasOne("TrainingPlanApp.Web.Data.Exercise", "ExerciseSecond")
                        .WithMany()
                        .HasForeignKey("ExerciseSecondId");

                    b.HasOne("TrainingPlanApp.Web.Data.Exercise", "ExerciseThird")
                        .WithMany()
                        .HasForeignKey("ExerciseThirdId");

                    b.Navigation("ExerciseFirst");

                    b.Navigation("ExerciseFourth");

                    b.Navigation("ExerciseSecond");

                    b.Navigation("ExerciseThird");
                });

            modelBuilder.Entity("TrainingPlanApp.Web.Models.MealCreateVM", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
