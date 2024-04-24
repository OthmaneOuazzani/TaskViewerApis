using TaskViewerApis.Interfaces;
using TaskViewerApis.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IProjectService, ProjectService>();


var taskServiceFactory = new TaskServiceFactory();
var taskService = await taskServiceFactory.CreateAsync();
builder.Services.AddSingleton<ITaskService>(taskService);

var taskDetailServiceFactory = new TaskDetailServiceFactory();
var taskDetailService = await taskDetailServiceFactory.CreateAsync();
builder.Services.AddSingleton<ITaskDetailService>(taskDetailService);

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

app.UseAuthorization();

app.MapControllers();

app.Run();
