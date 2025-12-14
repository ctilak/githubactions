## .NET Core Sample for GitHub Actions

This repo contains a minimal .NET 8 console app with xUnit tests to help you experiment with multiple GitHub Actions workflows.

### Structure
- `src/SimpleApp`: Console app with a tiny `MathService`.
- `tests/SimpleApp.Tests`: xUnit tests for `MathService`.
- `.github/workflows/dotnet-ci.yml`: CI workflow to restore, build, and test.
- `SimpleApp.sln`: Solution file linking both projects.

### Try it locally
```powershell
dotnet --info
dotnet restore SimpleApp.sln
dotnet build SimpleApp.sln -c Release
dotnet test SimpleApp.sln -c Release
dotnet run --project src/SimpleApp/SimpleApp.csproj
```

### GitHub Actions
Push to `main` or open a PR to trigger:
- Build and test on `ubuntu-latest` with .NET `8.0.x`.
- A linter job (super-linter) for general static checks.

You can add additional workflows (coverage, security scans, caching) under `.github/workflows/`.
# githubactions