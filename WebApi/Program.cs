
using Microsoft.EntityFrameworkCore;
using WebApi;
using Microsoft.Data.OData;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<masterContext>(op => op.UseSqlServer("Data Source = THARWATEXAM\\SQL2019STD; Database = Cloth_Factory; User ID = sa; Password = Yemen@134;"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddSwaggerGen();
//https://www.youtube.com/watch?v=ZCDWUBOJ5FU
//odata tutirial


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
