FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 63146
EXPOSE 44313

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY BracketWebApp/BracketWebApp.csproj BracketWebApp/
RUN dotnet restore BracketWebApp/BracketWebApp.csproj
COPY . .
WORKDIR /src/BracketWebApp
RUN dotnet build BracketWebApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish BracketWebApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BracketWebApp.dll"]
