FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 62130
EXPOSE 44383

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Car4U.WebAPI/Car4U.WebAPI.csproj", "Car4U.WebAPI/"]
RUN dotnet restore "Car4U.WebAPI/Car4U.WebAPI.csproj"
COPY . .
WORKDIR "/src/Car4U.WebAPI"
RUN dotnet build "Car4U.WebAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Car4U.WebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Car4U.WebAPI.dll"]