# Use the .NET 9 ASP.NET Core runtime as the base image
FROM mcr.microsoft.com/dotnet/nightly/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

# Use the .NET 9 SDK for building the app
FROM mcr.microsoft.com/dotnet/nightly/sdk:9.0 AS build
WORKDIR /src

# Copy everything and publish
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MinimalApiDemo.dll"]
