# Use the official .NET 6.0 SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy the .csproj file and restore any dependencies (if necessary)
COPY ["CalcApp/CalcApp.csproj", "CalcApp/"]
RUN dotnet restore "CalcApp/CalcApp.csproj"

# Copy the rest of the application source code
COPY . ./

# Build the application
RUN dotnet publish "CalcApp/CalcApp.csproj" -c Release -o out

# Use the official ASP.NET Core image for the runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build-env /app/out .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "CalcApp.dll"]

