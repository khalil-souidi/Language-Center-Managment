using Application_GS_ecole.Data;
using Application_GS_ecole.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Mvcecolecontext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MvcecolecontextConnection")));
builder.Services.AddScoped<CoursServices>();
builder.Services.AddScoped<GroupeServices>();
builder.Services.AddScoped<ProfServices>();
builder.Services.AddSession();





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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Login}/{id?}");


app.Run();

