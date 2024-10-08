#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DWBot/DWBot.csproj", "DWBot/"]
COPY ["DWBot.Data/DWBot.Data.csproj", "DWBot.Data/"]
COPY ["DWBot.Domain/DWBot.Domain.csproj", "DWBot.Domain/"]
COPY ["DWBot.Infrastructure/DWBot.Infrastructure.csproj", "DWBot.Infrastructure/"]
RUN dotnet restore "./DWBot/DWBot.csproj"
COPY . .
WORKDIR "/src/DWBot"
RUN dotnet build "./DWBot.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DWBot.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DWBot.dll"]