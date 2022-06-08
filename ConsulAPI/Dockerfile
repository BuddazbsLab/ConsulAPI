#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ConsulAPI/ConsulAPI.csproj", "ConsulAPI/"]
RUN dotnet restore "ConsulAPI/ConsulAPI.csproj"
COPY . .
WORKDIR "/src/ConsulAPI"
RUN dotnet build "ConsulAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsulAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsulAPI.dll"]