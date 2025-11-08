# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy project file(s) and restore as distinct layers
COPY ["VuelosApp/VuelosApp.csproj", "VuelosApp/"]
RUN dotnet restore "VuelosApp/VuelosApp.csproj"

# Copy everything and publish
COPY . .
RUN dotnet publish "VuelosApp/VuelosApp.csproj" -c Release -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish ./

# If you want a non-root user you can create one here (optional)
# RUN adduser --disabled-password appuser && chown -R appuser /app
# USER appuser

ENTRYPOINT ["dotnet", "VuelosApp.dll"]
