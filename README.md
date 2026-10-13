# Blazor-AI-ChatBot
AI ChatBot built with Blazor and OpenAI API for intelligent assistance and website integration.

# 🤖 Blazor AI ChatBot

AI ChatBot built using Blazor Server and OpenAI API.

## 🧩 Features

- Ask any question and get intelligent answers
- Built with Blazor Server
- Easily integrable into websites

## 🚀 Run locally

```bash
dotnet run

```

## API key configuration

Do **not** commit API keys to this repository. Use a new key stored in an environment variable or ASP.NET Core user secrets instead of putting a key in `Program.cs` or `appsettings.json`.

For a local PowerShell session:

```powershell
$env:OpenAI__ApiKey = "YOUR_NEW_API_KEY"
cd Blazor_AI_APP/Blazor_AI_APP
dotnet run
```

ASP.NET Core maps `OpenAI__ApiKey` to the `OpenAI:ApiKey` configuration setting. Previously exposed keys must be **revoked** with the provider; deleting them from the latest commit does **not** erase Git history.

**Current implementation note:** `OpenAIService.AskAsync` currently returns a placeholder response rather than calling the OpenAI API.
