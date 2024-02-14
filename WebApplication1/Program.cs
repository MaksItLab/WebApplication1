var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllersWithViews(); 

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.MapGet("/throw", () => {
	throw new ApplicationException("Ошибка!");
});

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

