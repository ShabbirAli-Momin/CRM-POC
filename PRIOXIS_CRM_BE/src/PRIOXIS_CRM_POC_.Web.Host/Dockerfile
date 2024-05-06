FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/PRIOXIS_CRM_POC_.Web.Host/PRIOXIS_CRM_POC_.Web.Host.csproj", "src/PRIOXIS_CRM_POC_.Web.Host/"]
COPY ["src/PRIOXIS_CRM_POC_.Web.Core/PRIOXIS_CRM_POC_.Web.Core.csproj", "src/PRIOXIS_CRM_POC_.Web.Core/"]
COPY ["src/PRIOXIS_CRM_POC_.Application/PRIOXIS_CRM_POC_.Application.csproj", "src/PRIOXIS_CRM_POC_.Application/"]
COPY ["src/PRIOXIS_CRM_POC_.Core/PRIOXIS_CRM_POC_.Core.csproj", "src/PRIOXIS_CRM_POC_.Core/"]
COPY ["src/PRIOXIS_CRM_POC_.EntityFrameworkCore/PRIOXIS_CRM_POC_.EntityFrameworkCore.csproj", "src/PRIOXIS_CRM_POC_.EntityFrameworkCore/"]
WORKDIR "/src/src/PRIOXIS_CRM_POC_.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PRIOXIS_CRM_POC_.Web.Host", "src/PRIOXIS_CRM_POC_.Web.Host"]
COPY ["src/PRIOXIS_CRM_POC_.Web.Core", "src/PRIOXIS_CRM_POC_.Web.Core"]
COPY ["src/PRIOXIS_CRM_POC_.Application", "src/PRIOXIS_CRM_POC_.Application"]
COPY ["src/PRIOXIS_CRM_POC_.Core", "src/PRIOXIS_CRM_POC_.Core"]
COPY ["src/PRIOXIS_CRM_POC_.EntityFrameworkCore", "src/PRIOXIS_CRM_POC_.EntityFrameworkCore"]
WORKDIR "/src/src/PRIOXIS_CRM_POC_.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PRIOXIS_CRM_POC_.Web.Host.dll"]
