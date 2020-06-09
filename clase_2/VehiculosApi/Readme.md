## Instructions

1. dotnet new webapi -o VehiculosApi
2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
3. dotnet add package Microsoft.EntityFrameworkCore.InMemory
4. Open project in vs code
5. dotnet run
6. See it running here: https://localhost:5001/WeatherForecast
7. Create Models directory
8. Create Model Class Vehicle
9. Create database context class
10. Register the database context in Startup.cs file
11. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
12. dotnet add package Microsoft.EntityFrameworkCore.Design
13. dotnet tool install --global dotnet-aspnet-codegenerator
14. dotnet aspnet-codegenerator controller -name VehiclesController -async -api -m Vehicle -dc DataBaseContext -outDir Controllers
15. Read reference here: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code
