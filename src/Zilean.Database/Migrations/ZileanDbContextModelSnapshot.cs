﻿// <auto-generated />
using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Zilean.Database;

#nullable disable

namespace Zilean.Database.Migrations
{
    [DbContext(typeof(ZileanDbContext))]
    partial class ZileanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Zilean.Shared.Features.Blacklist.BlacklistedItem", b =>
                {
                    b.Property<string>("InfoHash")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "info_hash");

                    b.Property<DateTime>("BlacklistedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'")
                        .HasAnnotation("Relational:JsonPropertyName", "blacklisted_at");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "reason");

                    b.HasKey("InfoHash");

                    b.HasIndex("InfoHash")
                        .IsUnique();

                    b.ToTable("BlacklistedItems", (string)null);
                });

            modelBuilder.Entity("Zilean.Shared.Features.Dmm.ParsedPages", b =>
                {
                    b.Property<string>("Page")
                        .HasColumnType("text");

                    b.Property<int>("EntryCount")
                        .HasColumnType("integer");

                    b.HasKey("Page");

                    b.ToTable("ParsedPages", (string)null);
                });

            modelBuilder.Entity("Zilean.Shared.Features.Dmm.TorrentInfo", b =>
                {
                    b.Property<string>("InfoHash")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "info_hash");

                    b.PrimitiveCollection<string[]>("Audio")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasAnnotation("Relational:JsonPropertyName", "audio");

                    b.Property<string>("BitDepth")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "bit_depth");

                    b.Property<string>("Bitrate")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "bitrate");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "category");

                    b.PrimitiveCollection<string[]>("Channels")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasAnnotation("Relational:JsonPropertyName", "channels");

                    b.Property<string>("CleanedParsedTitle")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("")
                        .HasAnnotation("Relational:JsonPropertyName", "cleaned_parsed_title");

                    b.Property<string>("Codec")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "codec");

                    b.Property<bool>("Complete")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "complete");

                    b.Property<string>("Container")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "container");

                    b.Property<bool>("Converted")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "converted");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "country");

                    b.Property<string>("Date")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.Property<bool>("Documentary")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "documentary");

                    b.Property<bool>("Dubbed")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "dubbed");

                    b.Property<string>("Edition")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "edition");

                    b.Property<string>("EpisodeCode")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "episode_code");

                    b.PrimitiveCollection<int[]>("Episodes")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasAnnotation("Relational:JsonPropertyName", "episodes");

                    b.Property<bool>("Extended")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "extended");

                    b.Property<string>("Extension")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "extension");

                    b.Property<string>("Group")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "group");

                    b.Property<bool>("Hardcoded")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "hardcoded");

                    b.PrimitiveCollection<string[]>("Hdr")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasAnnotation("Relational:JsonPropertyName", "hdr");

                    b.Property<string>("ImdbId")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "imdb_id");

                    b.Property<DateTime>("IngestedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'")
                        .HasAnnotation("Relational:JsonPropertyName", "ingested_at");

                    b.Property<bool>("Is3d")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "_3d");

                    b.Property<bool>("IsAdult")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasAnnotation("Relational:JsonPropertyName", "adult");

                    b.PrimitiveCollection<string[]>("Languages")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasAnnotation("Relational:JsonPropertyName", "languages");

                    b.Property<string>("Network")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "network");

                    b.Property<string>("NormalizedTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "normalized_title");

                    b.Property<string>("ParsedTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "parsed_title");

                    b.Property<bool>("Ppv")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "ppv");

                    b.Property<bool>("Proper")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "proper");

                    b.Property<string>("Quality")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "quality");

                    b.Property<string>("RawTitle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "raw_title");

                    b.Property<string>("Region")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "region");

                    b.Property<bool>("Remastered")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "remastered");

                    b.Property<bool>("Repack")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "repack");

                    b.Property<string>("Resolution")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "resolution");

                    b.Property<bool>("Retail")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "retail");

                    b.PrimitiveCollection<int[]>("Seasons")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasAnnotation("Relational:JsonPropertyName", "seasons");

                    b.Property<string>("Site")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "site");

                    b.Property<string>("Size")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "size");

                    b.Property<bool>("Subbed")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "subbed");

                    b.Property<bool>("Torrent")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "torrent");

                    b.Property<bool>("Trash")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "trash");

                    b.Property<bool>("Unrated")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "unrated");

                    b.Property<bool>("Upscaled")
                        .HasColumnType("boolean")
                        .HasAnnotation("Relational:JsonPropertyName", "upscaled");

                    b.PrimitiveCollection<int[]>("Volumes")
                        .IsRequired()
                        .HasColumnType("integer[]")
                        .HasAnnotation("Relational:JsonPropertyName", "volumes");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "year");

                    b.HasKey("InfoHash");

                    b.HasIndex("CleanedParsedTitle")
                        .HasDatabaseName("idx_cleaned_parsed_title_trgm");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("CleanedParsedTitle"), "GIN");
                    NpgsqlIndexBuilderExtensions.HasOperators(b.HasIndex("CleanedParsedTitle"), new[] { "gin_trgm_ops" });

                    b.HasIndex("Episodes")
                        .HasDatabaseName("idx_episodes_gin");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Episodes"), "GIN");

                    b.HasIndex("ImdbId")
                        .HasDatabaseName("idx_torrents_imdbid");

                    b.HasIndex("InfoHash")
                        .IsUnique();

                    b.HasIndex("IngestedAt")
                        .IsDescending()
                        .HasDatabaseName("idx_ingested_at");

                    b.HasIndex("IsAdult")
                        .HasDatabaseName("idx_torrents_isadult");

                    b.HasIndex("Languages")
                        .HasDatabaseName("idx_languages_gin");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Languages"), "GIN");

                    b.HasIndex("Seasons")
                        .HasDatabaseName("idx_seasons_gin");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("Seasons"), "GIN");

                    b.HasIndex("Trash")
                        .HasDatabaseName("idx_torrents_trash");

                    b.HasIndex("Year")
                        .HasDatabaseName("idx_year");

                    b.ToTable("Torrents", (string)null);
                });

            modelBuilder.Entity("Zilean.Shared.Features.Imdb.ImdbFile", b =>
                {
                    b.Property<string>("ImdbId")
                        .HasColumnType("text");

                    b.Property<bool>("Adult")
                        .HasColumnType("boolean");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("ImdbId");

                    b.HasIndex("ImdbId")
                        .IsUnique();

                    b.ToTable("ImdbFiles", (string)null);

                    b.HasAnnotation("Relational:JsonPropertyName", "imdb");
                });

            modelBuilder.Entity("Zilean.Shared.Features.Statistics.ImportMetadata", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<JsonDocument>("Value")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Key");

                    b.ToTable("ImportMetadata", (string)null);
                });

            modelBuilder.Entity("Zilean.Shared.Features.Dmm.TorrentInfo", b =>
                {
                    b.HasOne("Zilean.Shared.Features.Imdb.ImdbFile", "Imdb")
                        .WithMany()
                        .HasForeignKey("ImdbId");

                    b.Navigation("Imdb");
                });
#pragma warning restore 612, 618
        }
    }
}
