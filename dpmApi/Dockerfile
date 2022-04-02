#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["dpmApi/dpmApi.csproj", "dpmApi/"]
RUN dotnet restore "dpmApi/dpmApi.csproj"
COPY . .
WORKDIR "/src/dpmApi"
RUN dotnet build "dpmApi.csproj" -c Release -o /app/build -r linux-arm

FROM build AS publish
RUN dotnet publish "dpmApi.csproj" -c Release -o /app/publish -r linux-arm

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dpmApi.dll"]