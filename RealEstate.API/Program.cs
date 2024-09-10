var builder = WebApplication.CreateBuilder(args);
var testOrigins = "allowLocalDevelopement";
builder.Services.AddControllers();
builder.Services.AddCors((options) =>
    {
        options.AddPolicy(testOrigins, policy =>
            {
                policy.WithOrigins(new[] { "http://localhost:3000" });
            });
    });
// Add services to the container.
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
app.UseRouting();
app.UseCors(testOrigins);
app.MapControllers();
app.Run();
