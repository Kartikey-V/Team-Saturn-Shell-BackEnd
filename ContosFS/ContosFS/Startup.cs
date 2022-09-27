using ContosFS.Data;
using ContosFS.Data.GraphQL;
using ContosFS.Repository;
using GraphQL;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosFS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllers();
            services.AddDbContext<UserDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:FuelDB1"]));

           /*services.AddDbContext<StockDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:FuelDB"]));

            services.AddDbContext<HoldingsDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:FuelDB"]));

            services.AddDbContext<TransactionsDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:FuelDB"]));*/


            services.AddScoped<UserRepository>();
           /* services.AddScoped<StockRepository>();
            services.AddScoped<TransactionsRepository>();
            services.AddScoped<HoldingsRepository>();*/

            // GraphQL
            // GOTO: https://localhost:5001/ui/playground
            services.AddScoped<ContosSchema>();

            services.AddScoped<IServiceProvider>(s =>
                new FuncServiceProvider(s.GetRequiredService));

            services.AddGraphQL()
                .AddSystemTextJson()
                .AddGraphTypes(ServiceLifetime.Scoped);

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:3000");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseGraphQL<ContosSchema>();
            app.UseGraphQLPlayground();
            app.UseRouting();
            app.UseCors();


            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseHttpsRedirection();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }
}
