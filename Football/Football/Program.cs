using FootballDB;
using System.Reflection;
using Football.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<FootballContext>();

//DBHelper dBHelper = new DBHelper();
//dBHelper.PopulateLeagues();
//dBHelper.PopulateTransfers();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ILeagueCollectionService, LeagueCollectionService>();
builder.Services.AddSingleton<ITeamCollectionService, TeamCollectionService>();
builder.Services.AddSingleton<IPlayerCollectionService, PlayerCollectionService>();
builder.Services.AddSingleton<ITransferCollectionService, TransferCollectionService>();
builder.Services.AddSingleton<IUserCollectionService, UserCollectionService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://127.0.0.1:5500")
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowSpecificOrigin");

app.MapControllers();

app.Run();
