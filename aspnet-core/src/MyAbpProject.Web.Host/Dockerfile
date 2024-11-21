FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/MyAbpProject.Web.Host/MyAbpProject.Web.Host.csproj", "src/MyAbpProject.Web.Host/"]
COPY ["src/MyAbpProject.Web.Core/MyAbpProject.Web.Core.csproj", "src/MyAbpProject.Web.Core/"]
COPY ["src/MyAbpProject.Application/MyAbpProject.Application.csproj", "src/MyAbpProject.Application/"]
COPY ["src/MyAbpProject.Core/MyAbpProject.Core.csproj", "src/MyAbpProject.Core/"]
COPY ["src/MyAbpProject.EntityFrameworkCore/MyAbpProject.EntityFrameworkCore.csproj", "src/MyAbpProject.EntityFrameworkCore/"]
WORKDIR "/src/src/MyAbpProject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MyAbpProject.Web.Host", "src/MyAbpProject.Web.Host"]
COPY ["src/MyAbpProject.Web.Core", "src/MyAbpProject.Web.Core"]
COPY ["src/MyAbpProject.Application", "src/MyAbpProject.Application"]
COPY ["src/MyAbpProject.Core", "src/MyAbpProject.Core"]
COPY ["src/MyAbpProject.EntityFrameworkCore", "src/MyAbpProject.EntityFrameworkCore"]
WORKDIR "/src/src/MyAbpProject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MyAbpProject.Web.Host.dll"]
