using TRPGServer.Data;
using TRPGServer.Functions;
using TRPGServer.Functions.Interface;
using Microsoft.EntityFrameworkCore;
using TRPGServer.Functions.Logic;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
# region Add class to DI
#endregion
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

# region Add class to DI

// dependency Inject a logic function call DIdemo(use inject to get the class in blazor)
builder.Services.AddTransient<IDIdemo, DIdemo>(); //everytime call it will be a new class(the secound )
builder.Services.AddSingleton<IDIdemo, BetterDIdemo>(); //stay as the same class everytime you call it (the variable will stay the same, every one who use the same server will get same variable)
//builder.Services.AddScoped<IDIdemo, DIdemo>();//Singleton per person(example: every new tab will have new variable, same tab/application have same variable)
builder.Services.AddTransient<ILogicDemo, LogicDemo>(); //everytime call it will be a new class(the secound )
builder.Services.AddTransient<IAccountLogic, AccountLogic>();

#endregion


//Entity FrameWork
var connectionString = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
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
