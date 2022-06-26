using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.InMemory;
using restapinet.Domain.Repositories;
using restapinet.Domain.Services;
using restapinet.Persistence.Contexts;
using restapinet.Persistence.Repositories;
using restapinet.Services;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace restapinet
{
    public class Startup
    {
            public IConfiguration Configuration { get; }

            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseInMemoryDatabase("moodentry-restapi-in-memory");
                });

                services.AddScoped<IMoodEntryRepository, MoodEntryRepository>();
                services.AddScoped<IMoodEntryService, MoodEntryService>();
                services.AddMvc(options => { options.EnableEndpointRouting = false;});
            }

            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            {
                if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
                else app.UseHsts();
                
                app.UseHttpsRedirection();
                app.UseMvc();
            }
    }
}



/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
*/