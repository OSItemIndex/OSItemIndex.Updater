﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OSItemIndex.Data;
using OSItemIndex.Data.Database;

namespace OSItemIndex.Data.Migrations
{
    [DbContext(typeof(OsItemIndexDbContext))]
    partial class OsItemIndexDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("OSItemIndex.Data.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<object>("Details")
                        .HasColumnType("jsonb")
                        .HasColumnName("details");

                    b.Property<int>("Source")
                        .HasColumnType("integer")
                        .HasColumnName("source");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("timestamp");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("p_k_p_k_events");

                    b.ToTable("events");
                });

            modelBuilder.Entity("OSItemIndex.Data.OsrsBoxItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("BuyLimit")
                        .HasColumnType("integer")
                        .HasColumnName("buy_limit");

                    b.Property<int?>("Cost")
                        .HasColumnType("integer")
                        .HasColumnName("cost");

                    b.Property<bool>("Duplicate")
                        .HasColumnType("boolean")
                        .HasColumnName("duplicate");

                    b.Property<bool>("Equipable")
                        .HasColumnType("boolean")
                        .HasColumnName("equipable");

                    b.Property<bool>("EquipableByPlayer")
                        .HasColumnType("boolean")
                        .HasColumnName("equipable_by_player");

                    b.Property<bool>("EquipableWeapon")
                        .HasColumnType("boolean")
                        .HasColumnName("equipable_weapon");

                    b.Property<Equipment>("Equipment")
                        .HasColumnType("jsonb")
                        .HasColumnName("equipment");

                    b.Property<string>("Examine")
                        .HasColumnType("text")
                        .HasColumnName("examine");

                    b.Property<int?>("Highalch")
                        .HasColumnType("integer")
                        .HasColumnName("highalch");

                    b.Property<byte[]>("Icon")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("icon");

                    b.Property<bool>("Incomplete")
                        .HasColumnType("boolean")
                        .HasColumnName("incomplete");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_updated");

                    b.Property<int?>("LinkedIdItem")
                        .HasColumnType("integer")
                        .HasColumnName("linked_id_item");

                    b.Property<int?>("LinkedIdNoted")
                        .HasColumnType("integer")
                        .HasColumnName("linked_id_noted");

                    b.Property<int?>("LinkedIdPlaceholder")
                        .HasColumnType("integer")
                        .HasColumnName("linked_id_placeholder");

                    b.Property<int?>("Lowalch")
                        .HasColumnType("integer")
                        .HasColumnName("lowalch");

                    b.Property<bool>("Members")
                        .HasColumnType("boolean")
                        .HasColumnName("members");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<bool>("Noteable")
                        .HasColumnType("boolean")
                        .HasColumnName("noteable");

                    b.Property<bool>("Noted")
                        .HasColumnType("boolean")
                        .HasColumnName("noted");

                    b.Property<bool>("Placeholder")
                        .HasColumnType("boolean")
                        .HasColumnName("placeholder");

                    b.Property<bool>("QuestItem")
                        .HasColumnType("boolean")
                        .HasColumnName("quest_item");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("text")
                        .HasColumnName("release_date");

                    b.Property<bool>("Stackable")
                        .HasColumnType("boolean")
                        .HasColumnName("stackable");

                    b.Property<int?>("Stacked")
                        .HasColumnType("integer")
                        .HasColumnName("stacked");

                    b.Property<bool>("Tradeable")
                        .HasColumnType("boolean")
                        .HasColumnName("tradeable");

                    b.Property<bool>("TradeableOnGe")
                        .HasColumnType("boolean")
                        .HasColumnName("tradeable_on_ge");

                    b.Property<Equipment.WeaponInfo>("Weapon")
                        .HasColumnType("jsonb")
                        .HasColumnName("weapon");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision")
                        .HasColumnName("weight");

                    b.Property<string>("WikiName")
                        .HasColumnType("text")
                        .HasColumnName("wiki_name");

                    b.Property<string>("WikiUrl")
                        .HasColumnType("text")
                        .HasColumnName("wiki_url");

                    b.HasKey("Id")
                        .HasName("p_k_p_k_items");

                    b.ToTable("items");
                });

            modelBuilder.Entity("OSItemIndex.Data.RealtimeItemPrice+FiveMinutePrice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("AverageHighPrice")
                        .HasColumnType("integer")
                        .HasColumnName("average_high_price");

                    b.Property<int?>("AverageLowPrice")
                        .HasColumnType("integer")
                        .HasColumnName("average_low_price");

                    b.Property<int?>("HighPriceVolume")
                        .HasColumnType("integer")
                        .HasColumnName("high_price_volume");

                    b.Property<int?>("LowPriceVolume")
                        .HasColumnType("integer")
                        .HasColumnName("low_price_volume");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("timestamp");

                    b.HasKey("Id")
                        .HasName("p_k_p_k_prices_realtime_five_minutes");

                    b.ToTable("prices_realtime_five_minutes");
                });

            modelBuilder.Entity("OSItemIndex.Data.RealtimeItemPrice+LatestPrice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("High")
                        .HasColumnType("integer")
                        .HasColumnName("high");

                    b.Property<DateTime?>("HighTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("high_time");

                    b.Property<int?>("Low")
                        .HasColumnType("integer")
                        .HasColumnName("low");

                    b.Property<DateTime?>("LowTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("low_time");

                    b.HasKey("Id")
                        .HasName("p_k_p_k_prices_realtime_latest");

                    b.ToTable("prices_realtime_latest");
                });

            modelBuilder.Entity("OSItemIndex.Data.RealtimeItemPrice+OneHourPrice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("AverageHighPrice")
                        .HasColumnType("integer")
                        .HasColumnName("average_high_price");

                    b.Property<int?>("AverageLowPrice")
                        .HasColumnType("integer")
                        .HasColumnName("average_low_price");

                    b.Property<int?>("HighPriceVolume")
                        .HasColumnType("integer")
                        .HasColumnName("high_price_volume");

                    b.Property<int?>("LowPriceVolume")
                        .HasColumnType("integer")
                        .HasColumnName("low_price_volume");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("timestamp");

                    b.HasKey("Id")
                        .HasName("p_k_p_k_prices_realtime_one_hour");

                    b.ToTable("prices_realtime_one_hour");
                });
#pragma warning restore 612, 618
        }
    }
}
