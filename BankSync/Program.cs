using BankSynce.DbContexts;
using BankSynce.Entities;
using BankSynce.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUsuario, BankSynce.Repositories.Usuario>();
builder.Services.AddScoped<IConta, BankSynce.Repositories.Conta>();
builder.Services.AddScoped<ICliente, BankSynce.Repositories.Cliente>();
builder.Services.AddScoped<IFornecedor, BankSynce.Repositories.Fornecedor>();
builder.Services.AddScoped<ITransacao, BankSynce.Repositories.Transacao>();
builder.Services.AddDbContext<BankSynceContext>(options => {
    options.UseNpgsql("Host=localhost;Port=5432;Database=BannkSynce;Username=postgres;Password=3309;Include Error Detail=true");
});


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
