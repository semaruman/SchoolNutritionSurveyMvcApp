UsersDb db = new UsersDb();

var users = db.GetUsers();
foreach (var user in users)
{
    Console.WriteLine($"{user.LearningClass}, {user.AnswerForFood1}");
}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Form}/{action=Index}/{id?}"
    );

app.Run();

