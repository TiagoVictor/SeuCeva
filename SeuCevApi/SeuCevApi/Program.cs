using SeuCevApi.Data.Repository;
using SeuCevApi.Data.Repository.Interface;
using static SeuCevApi.AppSettings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IDocumentoRepository, DocumentoRepository>();
builder.Services.AddTransient<IEnderecoRepository, EnderecoRepository>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
