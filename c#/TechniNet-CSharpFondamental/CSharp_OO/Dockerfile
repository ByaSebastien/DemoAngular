FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CSharp_OO/CSharp_OO.csproj", "CSharp_OO/"]
RUN dotnet restore "CSharp_OO/CSharp_OO.csproj"
COPY . .
WORKDIR "/src/CSharp_OO"
RUN dotnet build "CSharp_OO.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CSharp_OO.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CSharp_OO.dll"]
