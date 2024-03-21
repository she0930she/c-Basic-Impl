FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV EnvMicro="Server=10.0.0.80;Database=EnvMicroDb;User=SA;Password=yourStrong1234;Trust Server Certificate=True"

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EnvironmentAPI/EnvironmentAPI.csproj", "EnvironmentAPI/"]
RUN dotnet restore "EnvironmentAPI/EnvironmentAPI.csproj"
COPY . .
WORKDIR "/src/EnvironmentAPI"
RUN dotnet build "EnvironmentAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EnvironmentAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EnvironmentAPI.dll"]
