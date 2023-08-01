using ApiAppl.DAL.Repositories;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using ApiAppl.Infrastructure.Data;
using ApiAppl.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using ApiAppl.Application.Commands.Category;
using ApiAppl.Application.Handlers.Category;
using ApiAppl.Application.Queries.Category;
using ApiAppl.Application.Handlers.CategoryForActualObject;
using ApiAppl.Application.Handlers.ObjectMIO;
using ApiAppl.Application.Commands.ObjectMIO;
using ApiAppl.Application.Queries.CategoryForActualObject;
using ApiAppl.Application.Queries.ObjectMIO;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connStr);
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddScoped<IRequestHandler<GetAllMIOObjectsQuery, IEnumerable<ObjectsMIOCheck>>, GetAllMIOObjectsQueryHandler>();
builder.Services.AddScoped<IRequestHandler<CreateMIOObjectCommand, ObjectsMIOCheck>, CreateMIOObjectCommandHandler>();
builder.Services.AddScoped<IRequestHandler<ChangeStatusCommand, Unit>, ChangeStatusCommandHandler>();

builder.Services.AddScoped<IRequestHandler<GetAllMIOCategoryQuery, IEnumerable<MIOCategory>>, GetAllCategoryQueryHandler>();
builder.Services.AddScoped<IRequestHandler<CreateCategoryCommand, MIOCategory>, CreateCategoryCommandHandler>();
builder.Services.AddScoped<IRequestHandler<UpdateCategoryCommand, Unit>, UpdateCategoryCommandHandler>();
builder.Services.AddScoped<IRequestHandler<ChangeCategoryStatusCommand, Unit>, ChangeCategoryStatusCommandHandler>();


builder.Services.AddScoped<IRequestHandler<GetCategoriesForActualObjectsQuery, IEnumerable<string>>, GetCategoriesForActualObjectsQueryHandler>();



builder.Services.AddScoped<IObjectMIOCheckRepository, ObjectsMIOCheckRepository>();
builder.Services.AddScoped<IObjectsMIOCheckService, ObjectsMIOCheckService>();

builder.Services.AddScoped<IMIOCategoryRepository, MIOCategoryRepository>();
builder.Services.AddScoped<IMIOCategoryService, MIOCategoryService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();
app.UseHttpsRedirection();

app.MapControllers();


app.Run();