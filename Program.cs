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
int missing[] = [23,41,42,43,46,49,50,51,52]
//https://drive.google.com/drive/folders/1r2ld27sz_3VTnjzuvEavf0t2lddRucZO
