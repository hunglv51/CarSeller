FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app


FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Car4U.sln ./
COPY Car4U.Domain/*.csproj ./Car4U.Domain/
COPY Car4U.Application/*.csproj ./Car4U.Application/
COPY Car4U.Infrastructure/Car4U.Infrastructure.csproj ./Car4U.Infrastructure/
COPY Car4U.WebAPI/Car4U.WebAPI.csproj ./Car4U.WebAPI/

RUN dotnet restore
COPY . .
WORKDIR /src/Car4U.Domain
RUN dotnet build -c Release -o /app
WORKDIR /src/Car4U.Application
RUN dotnet build -c Release -o /app
WORKDIR /src/Car4U.Infrastructure
RUN dotnet build -c Release -o /app

WORKDIR /src/Car4U.WebAPI
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Car4U.WebAPI.dll"]