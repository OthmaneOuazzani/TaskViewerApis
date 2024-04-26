using TaskViewerApis.Interfaces;
using TaskViewerApis.Services;
using System;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IProjectService, ProjectService>();

var stopwatch = Stopwatch.StartNew();

var taskServiceFactory = new TaskServiceFactory();
var taskService = await taskServiceFactory.CreateAsync();
builder.Services.AddSingleton<ITaskService>(taskService);

var taskDetailServiceFactory = new TaskDetailServiceFactory();
var taskDetailService = await taskDetailServiceFactory.CreateAsync();
builder.Services.AddSingleton<ITaskDetailService>(taskDetailService);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:4200")
           .AllowAnyMethod()
           .AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

stopwatch.Stop();
Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");
app.Run();

