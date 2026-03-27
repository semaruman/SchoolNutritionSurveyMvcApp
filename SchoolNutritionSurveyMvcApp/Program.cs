using SchoolNutritionSurveyMvcApp.Services.EF;
using SchoolNutritionSurveyMvcApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserService, UserJsonSevice>();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Form}/{action=Index}/{id?}"
    );

app.Run();