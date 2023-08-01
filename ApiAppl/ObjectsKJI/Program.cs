using ApiAppl.Application.Commands.Category;
using ApiAppl.Application.Handlers.Category;
using ApiAppl.Application.Queries.Category;
using ApiAppl.DAL.Repositories;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using ApiAppl.Infrastructure.Data;
using ApiAppl.Infrastructure.Service;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
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

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
