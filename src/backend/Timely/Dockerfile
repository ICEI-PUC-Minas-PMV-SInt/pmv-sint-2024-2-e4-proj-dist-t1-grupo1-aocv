FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
WORKDIR /app
RUN apk add --no-cache icu-libs icu-data-full
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /src
COPY ["Timely.csproj", "./"]
RUN dotnet restore "Timely.csproj"
COPY . .
WORKDIR "/src/."

RUN dotnet build "Timely.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Timely.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Timely.dll"]

