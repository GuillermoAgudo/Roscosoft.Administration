using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Roscosoft.Administration.Contracts.ServiceLibrary.Contracts;
using Roscosoft.Administration.Contracts.ServiceLibrary.DTO;
using Roscosoft.Administration.EF.DB.Infrastructure.Context;
using Roscosoft.Administration.EF.DB.Infrastructure.Repositories;
using Roscosoft.Administration.Impl.ServiceLibrary.Implementations;
using Roscosoft.Administration.Library.DomainContracts;
using Roscosoft.Administration.Library.DomainImplementations;
using Roscosoft.Administration.Library.Entites;
using Roscosoft.Administration.Library.InfrastrucutreContracts;
using Roscosoft.Administration.WebUI.Models;

namespace Roscosoft.Administration
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            RegisterDependencies(services);
            RegisterMappings();
            
            services.AddMvc();
        }

        public void RegisterDependencies(IServiceCollection services)
        {
            services.AddSingleton<INewService, NewService>();
            services.AddSingleton<INewLibrary, NewLibrary>();
            services.AddSingleton<IRepository<NewEntity>, NewRepository>();

            var connection = @"Server=localhost;Database=Roscosoft_Administration;Trusted_Connection=True; Integrated Security=SSPI;";
            var options = new DbContextOptionsBuilder<BaseDbContext>();
            options.UseSqlServer(connection);
            var _context = new BaseDbContext(options.Options);
            services.AddSingleton(new BaseDbContext((options.Options)));
        }

        public void RegisterMappings()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<NewModel, NewDTO>();
                cfg.CreateMap<NewDTO, NewEntity>();
            });
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
