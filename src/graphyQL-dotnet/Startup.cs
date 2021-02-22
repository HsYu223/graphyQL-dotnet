using GraphQL.Server;
using GraphQL.Types;
using graphyQL.GraphyQuery;
using graphyQL.GraphySchema;
using graphyQL.GraphyType;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories.Implement;
using Repositories.Interface;

namespace graphyQL_dotnet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IDatabaseConstants, DatabaseConstants>();
            services.AddScoped<ICombokindRepository>(
                sp =>
                {
                    return new CombokindRepository(
                        "",
                        sp.GetRequiredService<IDatabaseConstants>());
                });

            services.AddScoped<GraphyQuery>();
            services.AddScoped<CustomType>();
            services.AddScoped<ISchema, GraphySchema>();

            services
                .AddGraphQL(options =>
                {
                    options.EnableMetrics = true;
                })
                .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
                .AddSystemTextJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>();

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground();
        }
    }
}
