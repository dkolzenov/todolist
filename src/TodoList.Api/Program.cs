using TodoList.Api.Extensions;
using TodoList.Data.Repositories.Interfaces;
using TodoList.Data.Repositories.Task;
using TodoList.Services.Interfaces;
using TodoList.Services.Task;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCustomSqliteContext(builder.Configuration);
builder.Services.AddCustomAutoMapper();
builder.Services.AddSingleton<ITaskRepository, TaskRepository>();
builder.Services.AddSingleton<ITaskService, TaskService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
