/* O program.cs é o ponto de entrada para a aplicação.

Ele configura:
• serviços;
• Swagger;
• middlewares;
• rotas;
• execução da API.

*/

// Criar o construtor da aplicação. É onde começamos a configurar a API.
var builder = WebApplication.CreateBuilder(args);

// Ativa o uso dos Controllers.
builder.Services.AddControllers();

// Ativa o suporte ao Swagger, que é a tela usada para testar a API.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Constrói a aplicação com base nas configurações feitas.
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    // Ativa a documentação visual da API no navegador.
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redireciona requisições HTTP para HTTPS
app.UseHttpsRedirection();

// Ativa o middleware de autorização
app.UseAuthorization();

// Mapeia os Controllers, ou seja, permite que as rotas dos controllers funcionem.
app.MapControllers();

// Inicia a aplicação.
app.Run();

