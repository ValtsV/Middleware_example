using WebApplication1.Extensions;
using WebApplication1.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<AppSampleLogsMiddleware>();


var app = builder.Build();

// app.UseMiddleware<AppSampleLogsMiddleware>();


app.UseAppCulture();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Map("/life", (app) =>
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("This is ife handler");
    });
});

app.Run();

