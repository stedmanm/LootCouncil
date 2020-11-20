using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LootCouncil.Controllers;
using LootCouncil.Models;
using LootCouncil.Models.Database;
using LootCouncil.Models.Entities;
using LootCouncil.Models.Repositories;
using LootCouncil.Razor;
using LootCouncil.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LootCouncil
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseMySql(Configuration["Database:ConnectionString"]));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>();

            services.AddControllersWithViews(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddHttpContextAccessor();

            services.AddScoped<CharacterAccessor>();
            services.AddScoped<RaidTeamAccessor>();
            services.AddScoped<IEntityAccessor<Character>, CharacterAccessor>();
            services.AddScoped<IEntityAccessor<RaidTeam>, RaidTeamAccessor>();
            services.AddScoped<IGuildRepository, GuildRepository>();
            services.AddScoped<IRaidRepository, RaidRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<ICharacterRepository, CharacterRepository>();
            services.AddScoped<IRaidTeamRepository, RaidTeamRepository>();
            services.AddScoped<IRaidEventRepository, RaidEventRepository>();
            services.AddScoped<IUserProvider, UserProvider>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ILootRepository, LootRepository>();
            services.AddScoped<IBossRepository, BossRepository>();
            services.AddScoped<IItemPriorityRepository, ItemPriorityRepository>();

            services.AddTransient<IControllerServices, ControllerServices>();
            services.AddTransient<IRepositoryServices, RepositoryServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
