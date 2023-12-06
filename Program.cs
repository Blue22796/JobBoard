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

//https://drive.google.com/file/d/1rHMfGWe1mUAv3XxJ_mIUoIaJTlU4Vn11/view?usp=sharing
//https://drive.google.com/file/d/1wGMd2svGh2uGhV5BpnxhFMrycas1nA6z/view?usp=sharing
//https://groups.google.com/g/itskayoanime/c/1-5fT7wPz58?pli=1
//https://drive.google.com/drive/folders/1r2ld27sz_3VTnjzuvEavf0t2lddRucZO
