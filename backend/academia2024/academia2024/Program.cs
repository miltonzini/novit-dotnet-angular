var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddCors(options =>
    options.AddPolicy("Academia2024", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/testHolaMundo", () => "Hello, world!");
app.MapPost("/testHolaMundo", () => "Hello, world!");
app.MapGet("/sumarUno/{numero}", (int numero) => (numero + 1).ToString());

app.UseCors("Academia2024");

app.Run();