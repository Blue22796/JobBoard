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
//https://drive.google.com/drive/folders/1RM4GIj3XF9gG5J6Pfjt2y8qfLguC0j9z
//https://drive.google.com/drive/u/1/folders/1ScZvMJYoKhvJOWEffreFDVXBDlPjisay
//https://drive.google.com/drive/u/1/folders/1AmDI3stOdwqyTFZAolhrqOopo2jG5ZLJ

//https://cisasuedu-my.sharepoint.com/personal/2021170363_cis_asu_edu_eg/_layouts/15/onedrive.aspx?id=%2Fpersonal%2F2021170363%5Fcis%5Fasu%5Fedu%5Feg%2FDocuments%2FApps&ga=1
