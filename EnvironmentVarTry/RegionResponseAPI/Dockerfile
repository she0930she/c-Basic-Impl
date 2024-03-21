FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RegionResponseAPI/RegionResponseAPI.csproj", "RegionResponseAPI/"]
RUN dotnet restore "RegionResponseAPI/RegionResponseAPI.csproj"
COPY . .
WORKDIR "/src/RegionResponseAPI"
RUN dotnet build "RegionResponseAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "RegionResponseAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RegionResponseAPI.dll"]
