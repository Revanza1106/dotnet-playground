FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY src/TaskTracker.Api/TaskTracker.Api.csproj src/TaskTracker.Api/
RUN dotnet restore src/TaskTracker.Api/TaskTracker.Api.csproj

COPY src/TaskTracker.Api/. src/TaskTracker.Api/
RUN dotnet publish src/TaskTracker.Api/TaskTracker.Api.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TaskTracker.Api.dll"]
