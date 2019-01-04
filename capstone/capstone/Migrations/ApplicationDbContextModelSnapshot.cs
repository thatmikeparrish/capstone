﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using capstone.Data;

namespace capstone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("capstone.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ClientTypeId");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("ClientId");

                    b.HasIndex("ClientTypeId");

                    b.ToTable("Client");

                    b.HasData(
                        new { ClientId = 1, City = "LaVergne", ClientTypeId = 1, Comments = "My first test project!", CompanyName = "Test Company 1", Email = "Random@gmail.com", FirstName = "Kayla", LastName = "Carter", PhoneNumber = "6156491437", State = "TN", StreetAddress = "307 Valley Forge Ct.", ZipCode = "37086" },
                        new { ClientId = 2, City = "Murfreesboro", ClientTypeId = 2, Comments = "My second test project!", CompanyName = "Test Company 2", Email = "thatmikeparrish@gmail.com", FirstName = "Mike", LastName = "Parrish", PhoneNumber = "6157886484", State = "TN", StreetAddress = "2324 Chandler Pl.", ZipCode = "37130" }
                    );
                });

            modelBuilder.Entity("capstone.Models.ClientType", b =>
                {
                    b.Property<int>("ClientTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ClientTypeId");

                    b.ToTable("ClientType");

                    b.HasData(
                        new { ClientTypeId = 1, Category = "Personal" },
                        new { ClientTypeId = 2, Category = "Commercial" }
                    );
                });

            modelBuilder.Entity("capstone.Models.Crew", b =>
                {
                    b.Property<int>("CrewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("EmployeeQuantity");

                    b.Property<int>("EmployeeTypeId");

                    b.Property<double?>("LaborHours");

                    b.Property<double?>("ManagmentHours");

                    b.Property<double?>("PayRate");

                    b.Property<int>("ProjectId");

                    b.HasKey("CrewId");

                    b.HasIndex("EmployeeTypeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Crew");

                    b.HasData(
                        new { CrewId = 1, EmployeeQuantity = 1.0, EmployeeTypeId = 1, PayRate = 15.0, ProjectId = 1 },
                        new { CrewId = 2, EmployeeQuantity = 2.0, EmployeeTypeId = 2, PayRate = 15.0, ProjectId = 1 },
                        new { CrewId = 3, EmployeeQuantity = 2.0, EmployeeTypeId = 3, PayRate = 12.5, ProjectId = 1 }
                    );
                });

            modelBuilder.Entity("capstone.Models.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("EmployeeTypeId");

                    b.ToTable("EmployeeType");

                    b.HasData(
                        new { EmployeeTypeId = 1, Category = "Lead Developer (Management)" },
                        new { EmployeeTypeId = 2, Category = "Lead Developer (Labor)" },
                        new { EmployeeTypeId = 3, Category = "Senior Developer" },
                        new { EmployeeTypeId = 4, Category = "Junior Developer" }
                    );
                });

            modelBuilder.Entity("capstone.Models.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<double?>("ManHours");

                    b.Property<double?>("MaterialCost");

                    b.Property<int>("ProjectId");

                    b.Property<double?>("SubCost");

                    b.HasKey("LineItemId");

                    b.HasIndex("ProjectId");

                    b.ToTable("LineItem");

                    b.HasData(
                        new { LineItemId = 1, Description = "Build out a 50000 page", ManHours = 2.0, MaterialCost = 50000.0, ProjectId = 1, SubCost = 50000.0 },
                        new { LineItemId = 2, Description = "Build out a 20000 page", ManHours = 4.0, MaterialCost = 20000.0, ProjectId = 2, SubCost = 20000.0 },
                        new { LineItemId = 3, Description = "Build out a 5000 page", ManHours = 6.0, MaterialCost = 5000.0, ProjectId = 1, SubCost = 5000.0 },
                        new { LineItemId = 4, Description = "Build out a 1000 page", ManHours = 6.0, MaterialCost = 1000.0, ProjectId = 2, SubCost = 1000.0 },
                        new { LineItemId = 5, Description = "Build out a 500 page", ManHours = 6.0, MaterialCost = 500.0, ProjectId = 1, SubCost = 500.0 },
                        new { LineItemId = 6, Description = "Build out a 100 page", ManHours = 6.0, MaterialCost = 100.0, ProjectId = 2, SubCost = 100.0 },
                        new { LineItemId = 7, Description = "Build out a free page", ManHours = 6.0, MaterialCost = 0.0, ProjectId = 1, SubCost = 0.0 }
                    );
                });

            modelBuilder.Entity("capstone.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime?>("CompletionDate");

                    b.Property<double?>("CrewSize");

                    b.Property<DateTime?>("ExpirationDate");

                    b.Property<bool?>("IsCompleted");

                    b.Property<double?>("LaborMargin");

                    b.Property<string>("ProjectNumber")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<double?>("SalesTax");

                    b.Property<DateTime?>("SubmittedDate");

                    b.Property<int?>("TimeTrackerId");

                    b.Property<double?>("TotalCrewLaborCost");

                    b.Property<double?>("TotalCrewLaborHours");

                    b.Property<double?>("TotalCrewManagementCost");

                    b.Property<double?>("TotalCrewManagementHours");

                    b.Property<double?>("TotalManHours");

                    b.Property<double?>("TotalMaterialCost");

                    b.Property<double?>("TotalMaterialQuote");

                    b.Property<double?>("TotalSubCost");

                    b.Property<double?>("TotalSubQuote");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<int>("WorkDay");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.HasIndex("UserId");

                    b.ToTable("Project");

                    b.HasData(
                        new { ProjectId = 1, ClientId = 1, CompletionDate = new DateTime(2017, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpirationDate = new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), IsCompleted = true, LaborMargin = 0.1, ProjectNumber = "17001", SalesTax = 9.75, SubmittedDate = new DateTime(2017, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), TimeTrackerId = 1, UserId = "c3175b13-315f-4349-89af-a32dffbceff4", WorkDay = 8 },
                        new { ProjectId = 2, ClientId = 2, IsCompleted = false, LaborMargin = 0.2, ProjectNumber = "17002", SalesTax = 9.75, TimeTrackerId = 2, UserId = "c3175b13-315f-4349-89af-a32dffbceff4", WorkDay = 8 }
                    );
                });

            modelBuilder.Entity("capstone.Models.TimeTracker", b =>
                {
                    b.Property<int>("TimeTrackerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("Date");

                    b.Property<double>("Hours");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("TimeTrackerId");

                    b.HasIndex("UserId");

                    b.ToTable("TimeTracker");

                    b.HasData(
                        new { TimeTrackerId = 1, Comments = "This went as expected.", Date = new DateTime(2017, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), Hours = 2.0, UserId = "c3175b13-315f-4349-89af-a32dffbceff4" },
                        new { TimeTrackerId = 2, Comments = "I had an issue with Grunt.", Date = new DateTime(2017, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Hours = 6.0, UserId = "c3175b13-315f-4349-89af-a32dffbceff4" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("capstone.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new { Id = "c3175b13-315f-4349-89af-a32dffbceff4", AccessFailedCount = 0, ConcurrencyStamp = "5954637a-52fc-49be-b58b-dcc08a2c3a8b", Email = "thatmikeparrish@gmail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "THATMIKEPARRISH@GMAIL.COM", NormalizedUserName = "THATMIKEPARRISH@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEJg7uc/JBKBkVchBNGzoIw1aJzp1IoyDt/v5nqi/b+iFrA+5HZMoulidoHyfHALYvA==", PhoneNumberConfirmed = false, SecurityStamp = "1cacd7eb-6219-4168-90d7-988ae1581ed2", TwoFactorEnabled = false, UserName = "thatmikeparrish@gmail.com", FirstName = "Mike", LastName = "Parrish" }
                    );
                });

            modelBuilder.Entity("capstone.Models.Client", b =>
                {
                    b.HasOne("capstone.Models.ClientType", "ClientType")
                        .WithMany()
                        .HasForeignKey("ClientTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("capstone.Models.Crew", b =>
                {
                    b.HasOne("capstone.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("capstone.Models.Project")
                        .WithMany("CrewMembers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("capstone.Models.LineItem", b =>
                {
                    b.HasOne("capstone.Models.Project", "Project")
                        .WithMany("LineItems")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("capstone.Models.Project", b =>
                {
                    b.HasOne("capstone.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("capstone.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("capstone.Models.TimeTracker", b =>
                {
                    b.HasOne("capstone.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
