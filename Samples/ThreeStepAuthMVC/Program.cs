using Celigo.ServiceManager.NetSuite.TSA;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRequestTokenService,RequestTokenService>();
builder.Services.AddScoped<IAccessTokenService,AccessTokenService>();
builder.Services.AddScoped<IRevokeTokenService,RevokeTokenService>();
builder.Services
    .AddOptions()
    .AddHttpClient()
    .AddSingleton<IAccessTokenService,AccessTokenService>()
    .AddSingleton<IRequestTokenService, RequestTokenService>();

builder.Services.Configure<TokenServiceOptions>(builder.Configuration.GetSection("Celigo:NetSuite:TSA"));
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
