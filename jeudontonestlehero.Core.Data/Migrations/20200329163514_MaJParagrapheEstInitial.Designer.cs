﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jeudontonestlehero.Core.Data.Models;

namespace jeudontonestlehero.Core.Data.Migrations
{
    [DbContext(typeof(DefaultDBContext))]
    [Migration("20200329163514_MaJParagrapheEstInitial")]
    partial class MaJParagrapheEstInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("jeudontonestlehero.Core.Data.Models.Aventure", b =>
                {
                    b.Property<int>("AventureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TypeAventure")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("AventureId");

                    b.ToTable("Aventure");
                });

            modelBuilder.Entity("jeudontonestlehero.Core.Data.Models.Paragraphe", b =>
                {
                    b.Property<int>("ParagrapheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("EstInitial")
                        .HasColumnType("bit");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ParagrapheId");

                    b.ToTable("Paragraphe");
                });

            modelBuilder.Entity("jeudontonestlehero.Core.Data.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParagrapheId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("ParagrapheId")
                        .IsUnique();

                    b.ToTable("Question");
                });

            modelBuilder.Entity("jeudontonestlehero.Core.Data.Models.Reponse", b =>
                {
                    b.Property<int>("ReponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParagrapheId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("ReponseId");

                    b.HasIndex("ParagrapheId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Reponse");
                });

            modelBuilder.Entity("jeudontonestlehero.Core.Data.Models.Question", b =>
                {
                    b.HasOne("jeudontonestlehero.Core.Data.Models.Paragraphe", null)
                        .WithOne("maQuestion")
                        .HasForeignKey("jeudontonestlehero.Core.Data.Models.Question", "ParagrapheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("jeudontonestlehero.Core.Data.Models.Reponse", b =>
                {
                    b.HasOne("jeudontonestlehero.Core.Data.Models.Paragraphe", null)
                        .WithMany("reponse")
                        .HasForeignKey("ParagrapheId");

                    b.HasOne("jeudontonestlehero.Core.Data.Models.Question", null)
                        .WithMany("MesReponses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
