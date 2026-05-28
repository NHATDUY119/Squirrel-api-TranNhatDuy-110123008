var builder = WebApplication.CreateBuilder(args);

// Bắt buộc: Thêm dòng này để ứng dụng hỗ trợ Controller
builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Bắt buộc: Kích hoạt định tuyến tới các file Controller
app.MapControllers();

app.Run();