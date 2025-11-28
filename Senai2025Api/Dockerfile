# Etapa 1: runtime (imagem leve)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080

# Etapa 2: build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# copie o csproj primeiro para aproveitar cache
COPY ["Trainee2025Api.csproj", "./"]
RUN dotnet restore "Trainee2025Api.csproj"

# copía o resto do código
COPY . .
RUN dotnet publish "Trainee2025Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Etapa 3: imagem final
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Trainee2025Api.dll"]
