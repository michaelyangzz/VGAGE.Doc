using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGAGE.Doc.Data;
using VGAGE.Doc.Models;

namespace VGAGE.Doc
{
    public static class IdentityServiceExtension
    {
        public static IServiceCollection AddVGIdentity(this IServiceCollection sc, IConfiguration Configuration)
        {
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            var connectionString = Configuration.GetConnectionString("BlogContext");
            sc.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

            

            sc.AddIdentity<ApplicationUser, IdentityRole>()
                .AddErrorDescriber<IdentityLocalization>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();


            return sc;
        }
    }
}
