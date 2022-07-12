using Microsoft.EntityFrameworkCore;
using Reddit2.Database;
using Reddit2.Services;

var builder = WebApplication.CreateBuilder(args);

ConfigureDb(builder.Services);
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.WriteIndented = true;
    });

builder.Services.AddMvc();
builder.Services.AddScoped<PostService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddSingleton<CurrentUserService>();
var app = builder.Build();
app.MapControllers();
app.UseRouting();

app.Run();
static void ConfigureDb(IServiceCollection services)
{
    var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
    var connectionString = config.GetConnectionString("Default");
    services.AddDbContext<ApplicationDbContext>(b => b.UseSqlServer(connectionString));
}
