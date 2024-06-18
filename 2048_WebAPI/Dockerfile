#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["2048_WebAPI/2048_WebAPI.csproj", "2048_WebAPI/"]
RUN dotnet restore "2048_WebAPI/2048_WebAPI.csproj"
COPY . .
WORKDIR "/src/2048_WebAPI"
RUN dotnet build "2048_WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "2048_WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "2048_WebAPI.dll"]