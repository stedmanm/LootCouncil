using LootCouncil.Models.Entities;
using LootCouncil.Security;
using LootCouncil.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LootCouncil.Models.Database
{
    public static class ModelBuilderExtensions
    {
        public static void BuildUniqueConstraintForHasEntities(this ModelBuilder modelBuilder)
        {
            MethodInfo method = typeof(ModelBuilder).GetMethods().Single(m => m.Name == nameof(ModelBuilder.Entity)
                                                                         && m.GetGenericArguments().Length == 1
                                                                         && m.GetParameters().Length == 0);

            foreach (Type type in typeof(HasEntity<,>).FindSubTypesOfGenericTypeDefinition())
            {
                MethodInfo generic = method.MakeGenericMethod(type);
                EntityTypeBuilder entityTypeBuilder = generic.Invoke(modelBuilder, null) as EntityTypeBuilder;
                entityTypeBuilder.HasIndex("ParentId", "ChildId").IsUnique();
            }
        }

        public static void PopulateIdentityRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "c6965c4a-787c-4cfc-a27e-874ac926e3dc",
                    Name = ApplicationRole.Member.ToString(),
                    NormalizedName = ApplicationRole.Member.ToString().ToUpper(),
                    ConcurrencyStamp = "909231bd-a7ba-4b0e-9762-dae4dbd94822"
                }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "8cb63961-5d08-498d-9c67-ea4f9ff36ea6",
                    Name = ApplicationRole.GuildMaster.ToString(),
                    NormalizedName = ApplicationRole.GuildMaster.ToString().ToUpper(),
                    ConcurrencyStamp = "9cdae67b-ac2d-4a25-a5f8-0dcca7c9de6f"
                }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "f166a50a-287d-42c3-af06-f7e42977fc7c",
                    Name = ApplicationRole.Admin.ToString(),
                    NormalizedName = ApplicationRole.Admin.ToString().ToUpper(),
                    ConcurrencyStamp = "057b3554-e749-4c52-859f-7732c36856d0"
                }
            );
        }
    }
}
