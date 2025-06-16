// using para as ferramentas que vamos usar
using EncontreiPraVoce.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- Início da Configuração dos Serviços ---

// 1. Adiciona o serviço de Controllers, para que a aplicação reconheça nossas classes de Controller.
builder.Services.AddControllers();

// 2. Adiciona os serviços do Entity Framework Core e configura o SQLite.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// 3. Adiciona os serviços para a documentação da API (Swagger/OpenAPI).
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// --- Fim da Configuração dos Serviços ---

var app = builder.Build();

// --- Início da Configuração do Pipeline de Requisições ---

// Configure the HTTP request pipeline.
// Em ambiente de desenvolvimento, habilitamos a página do Swagger.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Adiciona o middleware de autorização (usaremos mais tarde para login).
app.UseAuthorization();

// Mapeia as rotas definidas nos seus arquivos de Controller.
app.MapControllers();

// --- Fim da Configuração do Pipeline de Requisições ---

app.Run();