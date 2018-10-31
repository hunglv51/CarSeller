FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 57924
EXPOSE 44376

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Car4U/Car4U.csproj", "Car4U/"]
RUN dotnet restore "Car4U/Car4U.csproj"
COPY . .
WORKDIR "/src/Car4U"
RUN dotnet build "Car4U.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Car4U.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Car4U.dll"]