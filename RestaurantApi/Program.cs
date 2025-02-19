using Restaurant.BusinessLayer.Abstract;
using Restaurant.BusinessLayer.Concrete;
using Restaurant.BusinessLayer.Container;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DataAccessLayer.EntityFramework;
using RestaurantApi.Hubs;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(opt=>
{
    opt.AddPolicy("CorsPolicy", builder =>
        {
         builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
        });
});
builder.Services.AddSignalR();

builder.Services.AddDbContext<RestaurantContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.ContainerDependencies();

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

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
