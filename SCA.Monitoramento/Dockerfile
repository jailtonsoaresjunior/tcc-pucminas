#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SCA.Monitoramento/SCA.Monitoramento.csproj", "SCA.Monitoramento/"]
RUN dotnet restore "SCA.Monitoramento/SCA.Monitoramento.csproj"
COPY . .
WORKDIR "/src/SCA.Monitoramento"
RUN dotnet build "SCA.Monitoramento.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SCA.Monitoramento.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SCA.Monitoramento.dll"]
