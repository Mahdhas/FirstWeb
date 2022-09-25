var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//
app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "cat",
    pattern: "{controller=Home}/{action=Index}/{cat}"
    );

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();


app.Run();
