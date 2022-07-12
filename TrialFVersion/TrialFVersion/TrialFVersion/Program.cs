
using Microsoft.EntityFrameworkCore;
using TrialFVersion.Database;
using TrialFVersion.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddScoped<IAliasersService, AliasersService>();

ConfigureDb(builder.Services);
var app = builder.Build();
app.MapControllers();
app.UseStaticFiles();
app.UseRouting();

app.Run();

static void ConfigureDb(IServiceCollection services)
{
    var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
    var connectionString = config.GetConnectionString("Default");
    services.AddDbContext<ApplicationDbContext>(b => b.UseSqlServer(connectionString));
}
