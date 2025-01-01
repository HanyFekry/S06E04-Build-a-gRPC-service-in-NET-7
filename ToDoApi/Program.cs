using ToDoGrpc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddGrpcClient<Image.ImageClient>(o =>
{
    o.Address = new Uri("https://localhost:7175"); // Replace with your gRPC service URL
});


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();
