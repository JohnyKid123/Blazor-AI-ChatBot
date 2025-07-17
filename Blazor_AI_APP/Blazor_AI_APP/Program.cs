using Blazor_AI_APP.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // ❗️ важно

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ✅ Регистрирай услугата ПРЕДИ builder.Build()
builder.Services.AddSingleton<OpenAIService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();


//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
