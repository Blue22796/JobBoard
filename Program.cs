using JobBoard.Cosmos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IDB, CosmosDB>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();

//https://drive.google.com/u/0/uc?id=1QP7o3_uVKZOZP3D8NcTk1OxbWfRnC_zj&export=download
//http://fs1.megadb.xyz:8080/d/7dnhxwaoy5vxygoid7w7rv2em3yqqnyw4eo3tu6v4lbcrm44iwidcxqfteoojqw4gywjozan/OCTOPATH-TRAVELER-SteamRIP.com.rar
//https://1fichier.com/?abvb9rbyj380lmsf7q1w%20
//https://megadb.net/download
