using TaskViewerApis.Interfaces;
using TaskViewerApis.Services;
using System;
using System.Diagnostics;
using TaskViewerApis.Data;
using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Helpers;
using TaskViewerApis.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TaskViewerApis.Data.Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IErrorService, ErrorService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IRatingService, RatingService>();


//var taskServiceFactory = new TaskServiceFactory();
//var taskService = await taskServiceFactory.CreateAsync();
builder.Services.AddScoped<ITaskService, TaskService>();

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var taskService = scope.ServiceProvider.GetRequiredService<ITaskService>() as TaskService;
    await taskService?.InitializeAsync();
}

//var taskDetailServiceFactory = new TaskDetailServiceFactory();
//var taskDetailService = await taskDetailServiceFactory.CreateAsync();
builder.Services.AddScoped<ITaskDetailService, TaskDetailService>(); 

builder.Services.AddAutoMapper(typeof(MappingProfile));
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

//app.Run();
app.Run("http://0.0.0.0:80");
