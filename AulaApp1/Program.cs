using AulaApp1.Components;
using AulaApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace AulaApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Banco MySQL via EF Core. A string de conexão fica em appsettings.json
            // (a senha de verdade fica nos User Secrets, fora do Git).
            // Em Blazor Server usamos uma FÁBRICA de contextos: cada operação cria
            // um DbContext curto e o descarta, em vez de um único contexto vivo
            // durante toda a conexão do usuário (circuito).
            var conexao = builder.Configuration.GetConnectionString("Distribuidora")
                ?? throw new InvalidOperationException("String de conexão 'Distribuidora' não encontrada.");
            builder.Services.AddDbContextFactory<AppDbContext>(options =>
                options.UseMySQL(conexao));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
