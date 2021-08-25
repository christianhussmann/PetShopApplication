FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HussmannDev.PetShopApp/HussmannDev.PetShopApp.csproj", "HussmannDev.PetShopApp/"]
RUN dotnet restore "HussmannDev.PetShopApp/HussmannDev.PetShopApp.csproj"
COPY . .
WORKDIR "/src/HussmannDev.PetShopApp"
RUN dotnet build "HussmannDev.PetShopApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HussmannDev.PetShopApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HussmannDev.PetShopApp.dll"]
