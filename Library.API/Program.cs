using Books.Core.Repositories;
using Books.Core.Service;
using Books.Data;
using Books.Data.Reposirories;
using Books.Service;
using Library.Core.Repositories;
using Library.Core.Service;
using Library.Data.Reposirories;
using Library.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBooksRepository, BooksRepository>();
builder.Services.AddScoped<IBooksService, BooksService>();
builder.Services.AddScoped<BooksService>();
//AddSingleton רק בשלב שעדיין אין dataBase והנתונים נשמרים בזמן ריצה
//builder.Services.AddSingleton<DataContext>();


builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<UsersService>();


////AddSingleton רק בשלב שעדיין אין dataBase והנתונים נשמרים בזמן ריצה
//builder.Services.AddSingleton<DataContext>();

builder.Services.AddScoped<ILenderService,LendersService>();
builder.Services.AddScoped<ILendersRepository, LendersRepository>();
builder.Services.AddScoped<LendersService>();

builder.Services.AddDbContext<DataContext>();


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
