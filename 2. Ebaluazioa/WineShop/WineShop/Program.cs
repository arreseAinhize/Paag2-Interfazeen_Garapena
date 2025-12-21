using WineShop.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Session konfigurazioa
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(900); // sesioa zenbat denbora zabalik egongo den
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

//Gure zrbitzuak
builder.Services.AddScoped<IArdoaService, ArdoaService>();
builder.Services.AddScoped<ISaskiaService, SaskiaService>();


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

// Session konfigurazioa, garrantzitsua da hau erabiltzea
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
