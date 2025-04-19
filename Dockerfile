# Imagen base para construir el proyecto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia los archivos y restaura dependencias
COPY ["Minicore_Notas_MVC/Minicore_Notas_MVC.csproj", "Minicore_Notas_MVC/"]
RUN dotnet restore "Minicore_Notas_MVC/Minicore_Notas_MVC.csproj"

# Copia el resto de los archivos y compila
COPY . .
WORKDIR "/src/Minicore_Notas_MVC"
RUN dotnet build "Minicore_Notas_MVC.csproj" -c Release -o /app/build

# Publicar la app
FROM build AS publish
RUN dotnet publish "Minicore_Notas_MVC.csproj" -c Release -o /app/publish

# Ejecutar la app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Minicore_Notas_MVC.dll"]
