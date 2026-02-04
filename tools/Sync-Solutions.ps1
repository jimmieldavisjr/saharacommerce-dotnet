# ===============================
# Reset solution project bindings
# ===============================

# Remove from root solution (incl tests)
dotnet sln .\Sahara.slnx remove `
  .\src\Sahara.Api\Sahara.Api.csproj `
  .\src\Sahara.App\Sahara.App.csproj `
  .\src\Sahara.Web\Sahara.Web.csproj `
  .\tests\Sahara.Api.Tests\Sahara.Api.Tests.csproj


# Remove from Sahara.Api.slnx
dotnet sln .\src\Sahara.Api\Sahara.Api.slnx remove `
  .\src\Sahara.Api\Sahara.Api.csproj


# Remove from Sahara.App.slnx
dotnet sln .\src\Sahara.App\Sahara.App.slnx remove `
  .\src\Sahara.App\Sahara.App.csproj


# Remove from Sahara.Web.slnx
dotnet sln .\src\Sahara.Web\Sahara.Web.slnx remove `
  .\src\Sahara.Web\Sahara.Web.csproj


# Add back to Sahara.Api.slnx
dotnet sln .\src\Sahara.Api\Sahara.Api.slnx add `
  .\src\Sahara.Api\Sahara.Api.csproj


# Add back to Sahara.App.slnx
dotnet sln .\src\Sahara.App\Sahara.App.slnx add `
  .\src\Sahara.App\Sahara.App.csproj


# Add back to Sahara.Web.slnx
dotnet sln .\src\Sahara.Web\Sahara.Web.slnx add `
  .\src\Sahara.Web\Sahara.Web.csproj


# Add all projects back to root solution (add tests last)
dotnet sln .\Sahara.slnx add `
  .\src\Sahara.Api\Sahara.Api.csproj `
  .\src\Sahara.App\Sahara.App.csproj `
  .\src\Sahara.Web\Sahara.Web.csproj `
  .\tests\Sahara.Api.Tests\Sahara.Api.Tests.csproj


# ===============================
# Git commit (only if changed)
# ===============================

git add *.slnx src/**/**.slnx

if (-not (git diff --cached --quiet)) {
    git commit -m "chore(solution): sync solution project bindings"
} else {
    Write-Host "No solution changes to commit."
}
