# AgendaElectronica
Es una aplicación trabajada con <b>Blazor Server</b> y <b>C#</b> usando <b>EF Core</b> con Microsoft SQL Server.

# Agregar los paquetes por la terminal
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

# Antes de crear las migraciones
dotnet tool install --global dotnet-ef

# Crear la primera migracion con EF Core desde la solución
dotnet ef migrations add InitialCreate --project AgendaElectronica

# Actualizar la base de datos despues de la micgración
dotnet ef database update --project AgendaElectronica