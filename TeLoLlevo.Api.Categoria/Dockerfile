#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TeLoLlevo.Api.Categoria/TeLoLlevo.Api.Categoria.csproj", "TeLoLlevo.Api.Categoria/"]
RUN dotnet restore "TeLoLlevo.Api.Categoria/TeLoLlevo.Api.Categoria.csproj"
COPY . .
WORKDIR "/src/TeLoLlevo.Api.Categoria"
RUN dotnet build "TeLoLlevo.Api.Categoria.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TeLoLlevo.Api.Categoria.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TeLoLlevo.Api.Categoria.dll"]