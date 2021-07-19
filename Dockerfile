FROM mcr.microsoft.com/dotnet/core/sdk:5.0

WORKDIR /app
COPY ./output/ .

EXPOSE 80
ENTRYPOINT ["dotnet", "DiscData.dll"]
