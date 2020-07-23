using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CCSS.CORE.REPOSITORY;

namespace CCSS.CORE
{
    public class Startup
    {
        readonly string AllowSpecificOrigins = "AllowOrigin";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options => {
                options.AddPolicy(name: AllowSpecificOrigins,
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            services.AddDbContext<CCSSCOREContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CCSSCOREContext"),
                        b => b.MigrationsAssembly("CCSS.CORE")
                    ));

            services.AddScoped<KnowledgeRepository>();
            services.AddScoped<TechnologyRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(AllowSpecificOrigins);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
