﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SupportAPI.Helpers;

#nullable disable

namespace SupportAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231009130030_MakeUpdates")]
    partial class MakeUpdates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SupportAPI.Common.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AgentId")
                        .HasColumnType("text");

                    b.Property<DateTime>("ClosedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ChatId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsSentByAgent")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FinishAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsNightShift")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOverflow")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5"),
                            FinishAt = new DateTime(2023, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsNightShift = false,
                            IsOnline = false,
                            IsOverflow = false,
                            MaxCapacity = 0,
                            StartAt = new DateTime(2023, 12, 31, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamName = "Team A"
                        },
                        new
                        {
                            Id = new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e"),
                            FinishAt = new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            IsNightShift = false,
                            IsOnline = false,
                            IsOverflow = false,
                            MaxCapacity = 0,
                            StartAt = new DateTime(2023, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamName = "Team B"
                        },
                        new
                        {
                            Id = new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec"),
                            FinishAt = new DateTime(2023, 12, 31, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            IsNightShift = true,
                            IsOnline = false,
                            IsOverflow = false,
                            MaxCapacity = 0,
                            StartAt = new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamName = "Team C"
                        },
                        new
                        {
                            Id = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83"),
                            FinishAt = new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            IsNightShift = false,
                            IsOnline = false,
                            IsOverflow = true,
                            MaxCapacity = 0,
                            StartAt = new DateTime(2023, 12, 31, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamName = "Overflow Team"
                        });
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Agent", b =>
                {
                    b.HasBaseType("SupportAPI.Common.Entities.User");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean");

                    b.Property<int>("Seniority")
                        .HasColumnType("integer");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.HasIndex("TeamId");

                    b.HasDiscriminator().HasValue("Agent");

                    b.HasData(
                        new
                        {
                            Id = "7d398b03-357b-4570-a915-56c59cde0f12",
                            IsOnline = true,
                            Seniority = 3,
                            TeamId = new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5")
                        },
                        new
                        {
                            Id = "45bc8d19-32a0-46c1-b8d0-7686b60cb5d0",
                            IsOnline = true,
                            Seniority = 1,
                            TeamId = new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5")
                        },
                        new
                        {
                            Id = "aa8454cc-2638-4eab-9510-351a2c49d146",
                            IsOnline = true,
                            Seniority = 1,
                            TeamId = new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5")
                        },
                        new
                        {
                            Id = "f1288a5b-1e1f-4d66-ab81-e9515bceeed7",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5")
                        },
                        new
                        {
                            Id = "ff486a52-2ea7-4392-84a2-903e093b942a",
                            IsOnline = true,
                            Seniority = 2,
                            TeamId = new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e")
                        },
                        new
                        {
                            Id = "7be9216a-4db7-4e3a-9504-1c096503e4c7",
                            IsOnline = true,
                            Seniority = 1,
                            TeamId = new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e")
                        },
                        new
                        {
                            Id = "69657f86-adb6-4e61-94a8-2b91ddd02a68",
                            IsOnline = true,
                            Seniority = 1,
                            TeamId = new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e")
                        },
                        new
                        {
                            Id = "0c0ac714-f4c2-42fe-9c45-e1de3d7f5f06",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e")
                        },
                        new
                        {
                            Id = "14f1c3f5-8d43-4903-ad23-ccc2d865a034",
                            IsOnline = true,
                            Seniority = 1,
                            TeamId = new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec")
                        },
                        new
                        {
                            Id = "85ef3836-c36e-46f9-8707-e389288e55e9",
                            IsOnline = true,
                            Seniority = 1,
                            TeamId = new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec")
                        },
                        new
                        {
                            Id = "6152df35-d4c8-4683-94fe-18565d85a4d7",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83")
                        },
                        new
                        {
                            Id = "7cb4ff35-2ec5-456f-9876-c8b3a187215c",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83")
                        },
                        new
                        {
                            Id = "f03adb73-248e-449e-bf68-fb27de807579",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83")
                        },
                        new
                        {
                            Id = "e21584d7-e58f-4e3a-92b3-969b64e490a8",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83")
                        },
                        new
                        {
                            Id = "f48ea0f3-b6ec-4d76-ac76-28430cd91955",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83")
                        },
                        new
                        {
                            Id = "7775923e-6f5b-44a1-8590-46b2e4d05c6a",
                            IsOnline = true,
                            Seniority = 0,
                            TeamId = new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83")
                        });
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Customer", b =>
                {
                    b.HasBaseType("SupportAPI.Common.Entities.User");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.HasDiscriminator().HasValue("Customer");

                    b.HasData(
                        new
                        {
                            Id = "3d2f8c6a-a206-4f99-a2ff-c5206c41741b",
                            AccountId = new Guid("7100d2c8-918f-4d12-809b-28995482d85d")
                        });
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Chat", b =>
                {
                    b.HasOne("SupportAPI.Common.Entities.Agent", "Agent")
                        .WithMany("Chats")
                        .HasForeignKey("AgentId");

                    b.HasOne("SupportAPI.Common.Entities.Customer", "Customer")
                        .WithMany("Chats")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Message", b =>
                {
                    b.HasOne("SupportAPI.Common.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId");

                    b.HasOne("SupportAPI.Common.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Agent", b =>
                {
                    b.HasOne("SupportAPI.Common.Entities.Team", "Team")
                        .WithMany("Agents")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Team", b =>
                {
                    b.Navigation("Agents");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Agent", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("SupportAPI.Common.Entities.Customer", b =>
                {
                    b.Navigation("Chats");
                });
#pragma warning restore 612, 618
        }
    }
}
