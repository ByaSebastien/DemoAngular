FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TechniNet-CSharpFondamental/TechniNet-CSharpFondamental.csproj", "TechniNet-CSharpFondamental/"]
RUN dotnet restore "TechniNet-CSharpFondamental/TechniNet-CSharpFondamental.csproj"
COPY . .
WORKDIR "/src/TechniNet-CSharpFondamental"
RUN dotnet build "TechniNet-CSharpFondamental.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechniNet-CSharpFondamental.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechniNet-CSharpFondamental.dll"]
