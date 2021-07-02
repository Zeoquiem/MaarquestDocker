#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Maarquest.WEB/Maarquest.WEB.csproj", "Maarquest.WEB/"]
RUN dotnet restore "Maarquest.WEB/Maarquest.WEB.csproj"
COPY . .
WORKDIR "/src/Maarquest.WEB"
RUN dotnet build "Maarquest.WEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Maarquest.WEB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Maarquest.WEB.dll"]