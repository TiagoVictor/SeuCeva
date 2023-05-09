using Microsoft.EntityFrameworkCore;
using SeuCevApi;
using SeuCevApi.Data.Context;
using SeuCevApi.Data.Repository;
using SeuCevApi.Data.Repository.Interface;
using SeuCevApi.Service;
using SeuCevApi.Service.Interface;
using static SeuCevApi.AppSettings;

var MyAllowSpecifucOrigins = "_MyAllowSpecifucOrigins";

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecifucOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:3001","http://localhost:3001");
    });
});

// Add services to the container.
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("SeuCeva")));
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IDocumentoRepository, DocumentoRepository>();
builder.Services.AddTransient<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddTransient<IOfertaRepository, OfertaRepository>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<ITipoClienteRepository, TipoClienteRepository>();
builder.Services.AddTransient<ITipoPlanoRepository, TipoPlanoRepository>();

builder.Services.AddTransient<ITipoPlanoService, TipoPlanoService>();
builder.Services.AddTransient<ITipoClienteService, TipoClienteService>();
builder.Services.AddTransient<IEnderecoService, EnderecoService>();
builder.Services.AddTransient<IDocumentoService, DocumentoService>();
builder.Services.AddTransient<IProdutoService, ProdutoService>();
builder.Services.AddTransient<IOfertaService, OfertaService>();
builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors(MyAllowSpecifucOrigins);

app.Run();
