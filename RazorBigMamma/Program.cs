using Microsoft.Extensions.DependencyInjection;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IMenuItemRepository, MenuItemRepository>();
builder.Services.AddSingleton<IAccessoriesRepository, AccessoriesRepository>();
builder.Services.AddSingleton<IShoppingBasket, ShoppingBasket>();
builder.Services.AddTransient<IShoppingBasket2, ShoppingBasket2>();

builder.Services.AddSession();    //Nyt
builder.Services.AddHttpContextAccessor();//Nyt
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddTransient<LogInService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();  //Nyt

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
