using Harcama.Business;
using Harcama.DataAccess.Concrete;
using Harcama.Entities.Concrete;
using Harcama.WebAPI;
using Microsoft.AspNetCore.Identity;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDataAccessServices();
builder.Services.AddBusinessServices();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddAuthorizationBuilder();
builder.Services.AddControllers();
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory());
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
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

await Helper.CreateRoleAsync(app);
await Helper.CreateUsersAsync(app);
app.Run();
