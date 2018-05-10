﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Zop.Identity;
using Zop.Identity.Server;

namespace Zop.Identity.Server.Migrations
{
    [DbContext(typeof(MigrationsDbContext))]
    [Migration("20180510034501_itit")]
    partial class itit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Zop.Domain.Entities.ApiResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("UserClaims")
                        .HasMaxLength(2000);

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApiResources");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ApiScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApiResourceId");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.Property<string>("UserClaims")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApiScopes");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ApiSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .HasMaxLength(10000);

                    b.HasKey("Id");

                    b.ToTable("ApiSecrets");
                });

            modelBuilder.Entity("Zop.Domain.Entities.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(200);

                    b.Property<int>("AbsoluteRefreshTokenLifetime");

                    b.Property<int>("AccessTokenLifetime");

                    b.Property<int>("AccessTokenType");

                    b.Property<bool>("AllowAccessTokensViaBrowser");

                    b.Property<bool>("AllowOfflineAccess");

                    b.Property<bool>("AllowPlainTextPkce");

                    b.Property<bool>("AllowRememberConsent");

                    b.Property<string>("AllowedCorsOrigins")
                        .HasMaxLength(2000);

                    b.Property<string>("AllowedGrantTypes")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("AllowedScopes")
                        .HasMaxLength(2000);

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken");

                    b.Property<bool>("AlwaysSendClientClaims");

                    b.Property<int>("AuthorizationCodeLifetime");

                    b.Property<bool>("BackChannelLogoutSessionRequired");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<string>("ClientClaimsPrefix")
                        .HasMaxLength(200);

                    b.Property<string>("ClientName")
                        .HasMaxLength(200);

                    b.Property<string>("ClientUri")
                        .HasMaxLength(2000);

                    b.Property<int?>("ConsentLifetime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(20000);

                    b.Property<bool>("EnableLocalLogin");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("FrontChannelLogoutSessionRequired");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<string>("IdentityProviderRestrictions")
                        .HasMaxLength(2000);

                    b.Property<int>("IdentityTokenLifetime");

                    b.Property<bool>("IncludeJwtId");

                    b.Property<string>("LoginUri")
                        .HasMaxLength(300);

                    b.Property<string>("LogoUri")
                        .HasMaxLength(2000);

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PairWiseSubjectSalt")
                        .HasMaxLength(200);

                    b.Property<string>("PostLogoutRedirectUris")
                        .HasMaxLength(10000);

                    b.Property<string>("ProtocolType")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("RedirectUris")
                        .HasMaxLength(2000);

                    b.Property<int>("RefreshTokenExpiration");

                    b.Property<int>("RefreshTokenUsage");

                    b.Property<bool>("RequireClientSecret");

                    b.Property<bool>("RequireConsent");

                    b.Property<bool>("RequirePkce");

                    b.Property<int>("SlidingRefreshTokenLifetime");

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh");

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ClientClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientClaims");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ClientProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientProperties");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ClientSecret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .HasMaxLength(10000);

                    b.HasKey("Id");

                    b.ToTable("ClientSecrets");
                });

            modelBuilder.Entity("Zop.Domain.Entities.IdentityResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.Property<string>("UserClaims")
                        .HasMaxLength(2000);

                    b.Property<int>("VersionNo");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("IdentityResources");
                });

            modelBuilder.Entity("Zop.Domain.Entities.IdentityToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000);

                    b.Property<string>("IdentityIP4")
                        .IsRequired();

                    b.Property<string>("ReturnUrl")
                        .HasMaxLength(1000);

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("ValidityTime");

                    b.HasKey("Id");

                    b.ToTable("IdentityToken");
                });

            modelBuilder.Entity("Zop.Domain.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("PersistedGrant");
                });

            modelBuilder.Entity("Zop.Domain.Entities.Secret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApiResourceId");

                    b.Property<string>("ClientId");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .HasMaxLength(10000);

                    b.HasKey("Id");

                    b.HasIndex("ApiResourceId");

                    b.HasIndex("ClientId");

                    b.ToTable("Secret");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ApiScope", b =>
                {
                    b.HasOne("Zop.Domain.Entities.ApiResource")
                        .WithMany("Scopes")
                        .HasForeignKey("ApiResourceId");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ClientClaim", b =>
                {
                    b.HasOne("Zop.Domain.Entities.Client")
                        .WithMany("Claims")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Zop.Domain.Entities.ClientProperty", b =>
                {
                    b.HasOne("Zop.Domain.Entities.Client")
                        .WithMany("Properties")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Zop.Domain.Entities.Secret", b =>
                {
                    b.HasOne("Zop.Domain.Entities.ApiResource")
                        .WithMany("Secrets")
                        .HasForeignKey("ApiResourceId");

                    b.HasOne("Zop.Domain.Entities.Client")
                        .WithMany("Secrets")
                        .HasForeignKey("ClientId");
                });
#pragma warning restore 612, 618
        }
    }
}
