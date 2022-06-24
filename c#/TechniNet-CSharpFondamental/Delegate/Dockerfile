FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Delegate/Delegate.csproj", "Delegate/"]
RUN dotnet restore "Delegate/Delegate.csproj"
COPY . .
WORKDIR "/src/Delegate"
RUN dotnet build "Delegate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delegate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delegate.dll"]
