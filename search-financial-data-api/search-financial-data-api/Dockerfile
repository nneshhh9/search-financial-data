FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["search-financial-data-api/search-financial-data-api.csproj", "search-financial-data-api/"]
RUN dotnet restore "search-financial-data-api/search-financial-data-api.csproj"
COPY . .
WORKDIR "/src/search-financial-data-api"
RUN dotnet build "search-financial-data-api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "search-financial-data-api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "search-financial-data-api.dll"]
