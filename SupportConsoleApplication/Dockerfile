FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SupportConsoleApplication/SupportConsoleApplication.csproj", "SupportConsoleApplication/"]
RUN dotnet restore "SupportConsoleApplication/SupportConsoleApplication.csproj"
COPY . .
WORKDIR "/src/SupportConsoleApplication"
RUN dotnet build "SupportConsoleApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SupportConsoleApplication.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SupportConsoleApplication.dll"]
