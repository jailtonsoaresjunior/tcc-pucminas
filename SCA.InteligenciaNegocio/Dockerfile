#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SCA.InteligenciaNegocio/SCA.InteligenciaNegocio.csproj", "SCA.InteligenciaNegocio/"]
RUN dotnet restore "SCA.InteligenciaNegocio/SCA.InteligenciaNegocio.csproj"
COPY . .
WORKDIR "/src/SCA.InteligenciaNegocio"
RUN dotnet build "SCA.InteligenciaNegocio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SCA.InteligenciaNegocio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SCA.InteligenciaNegocio.dll"]
