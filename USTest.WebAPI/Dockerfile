FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["USTest.WebAPI/USTest.WebAPI.csproj", "USTest.WebAPI/"]
RUN dotnet restore "USTest.WebAPI/USTest.WebAPI.csproj"
COPY . .
WORKDIR "/src/USTest.WebAPI"
RUN dotnet build "USTest.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "USTest.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "USTest.WebAPI.dll"]
