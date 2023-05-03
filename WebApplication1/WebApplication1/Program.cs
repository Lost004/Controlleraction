using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
    );


app.Run();
