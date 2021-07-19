#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DiscData/DiscData.csproj", "DiscData/"]
RUN dotnet restore "DiscData/DiscData.csproj"
COPY . .
WORKDIR "/src/DiscData"
RUN dotnet build "DiscData.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DiscData.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DiscData.dll"]