FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# repara que aqui eu NÃO uso Senai2025Api/Senai2025Api.csproj
COPY ["Senai2025Api.csproj", "./"]
RUN dotnet restore "Senai2025Api.csproj"

COPY . .
RUN dotnet publish "Senai2025Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Senai2025Api.dll"]
