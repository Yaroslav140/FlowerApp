FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["FlowerShop/FlowerShop.Web.csproj", "FlowerShop/"]

COPY ["FlowerShop.Data/FlowerShop.Data.csproj", "FlowerShop.Data/"]

COPY ["FlowerShop.Dto/FlowerShop.Dto.csproj", "FlowerShop.Dto/"]

RUN dotnet restore "FlowerShop/FlowerShop.Web.csproj"

COPY . .

WORKDIR "/src/FlowerShop"
RUN dotnet publish "FlowerShop.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
USER app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "FlowerShop.Web.dll"]
