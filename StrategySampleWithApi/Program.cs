using StrategySampleWithApi.CompressionModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ZipCompression>();
builder.Services.AddTransient<RarCompression>();
builder.Services.AddTransient<Func<string, ICompressionStrategy>>(provider => key =>
{
    return key.ToLower() switch
    {
        "zip" => provider.GetRequiredService<ZipCompression>(),
        "rar" => provider.GetRequiredService<RarCompression>(),
        _ => throw new ArgumentException("Invalid compression type")
    };
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

app.MapControllers();

app.Run();
