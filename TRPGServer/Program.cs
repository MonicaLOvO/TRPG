using TRPGServer.Data;
using TRPGServer.Functions;
using TRPGServer.Functions.Interface;
using Microsoft.EntityFrameworkCore;
using TRPGServer.Functions.Logic;
using TRPGServer.Functions.Logic.CharacterLogicFolder;
using TRPGServer;
using TRPGServer.Functions.Logic.RoomLogicFolder;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                       policy =>
                       {
                           policy.WithOrigins("http://localhost:3000").AllowAnyHeader()
                                .AllowAnyMethod() ;
                      });
});

// Add services to the container.
# region Add class to DI
#endregion
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

# region Add class to DI

// dependency Inject a logic function call DIdemo(use inject to get the class in blazor)
//builder.Services.AddTransient<IDIdemo, DIdemo>(); //everytime call it will be a new class(the secound )
//builder.Services.AddSingleton<IDIdemo, BetterDIdemo>(); //stay as the same class everytime you call it (the variable will stay the same, every one who use the same server will get same variable)
//builder.Services.AddScoped<IDIdemo, DIdemo>();//Singleton per person(example: every new tab will have new variable, same tab/application have same variable)
//builder.Services.AddTransient<ILogicDemo, LogicDemo>(); //everytime call it will be a new class(the secound )
builder.Services.AddTransient<IAccountLogic, AccountLogic>();
builder.Services.AddTransient<ICharacterLogic, CharacterLogic>();
builder.Services.AddTransient<IStatusLogic, StatusLogic>();
builder.Services.AddTransient<IItemLogic, ItemLogic>();
builder.Services.AddTransient<IRoomLogic, RoomLogic>();
builder.Services.AddTransient<IActorLogic, ActorLogic>();
builder.Services.AddTransient<IClassLogic, ClassLogic>();
builder.Services.AddTransient<IRoomCharacterLogic, RoomCharacterLogic>();
#endregion


//Entity FrameWork
ServerEnv.DbConnectionString = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(ServerEnv.DbConnectionString, ServerVersion.AutoDetect(ServerEnv.DbConnectionString)));
var app = builder.Build();


// add cors allow
app.UseCors(MyAllowSpecificOrigins);

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
