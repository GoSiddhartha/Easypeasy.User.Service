FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 81
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Easypeasy.User.Service/Easypeasy.User.Service.csproj", "Easypeasy.User.Service/"]
RUN dotnet restore "Easypeasy.User.Service/Easypeasy.User.Service.csproj"
COPY . .
WORKDIR "/src/Easypeasy.User.Service"
RUN dotnet build "Easypeasy.User.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Easypeasy.User.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Easypeasy.User.Service.dll"]