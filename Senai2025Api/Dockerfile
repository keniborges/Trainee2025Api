# Imagem base de runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Imagem de build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Como o contexto é a pasta Senai2025Api, o csproj está na raiz desse contexto
COPY ["Senai2025Api.csproj", "./"]
RUN dotnet restore "Senai2025Api.csproj"

COPY . .
RUN dotnet build "Senai2025Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Senai2025Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Senai2025Api.dll"]
