FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 50821
EXPOSE 44319

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY TestWCFCore/TestWCFCore.csproj TestWCFCore/
RUN dotnet restore TestWCFCore/TestWCFCore.csproj
COPY . .
WORKDIR /src/TestWCFCore
RUN dotnet build TestWCFCore.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TestWCFCore.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestWCFCore.dll"]
