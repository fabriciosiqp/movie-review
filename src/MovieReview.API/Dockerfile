FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/MovieReview.API/MovieReview.API.csproj", "src/MovieReview.API/"]
COPY ["src/MovieReview.Infra/MovieReview.Infra.csproj", "src/MovieReview.Infra/"]
COPY ["src/MovieReview.Domain/MovieReview.Domain.csproj", "src/MovieReview.Domain/"]
COPY ["src/MovieReview.Core/MovieReview.Core.csproj", "src/MovieReview.Core/"]
COPY ["src/MovieReview.Application/MovieReview.Application.csproj", "src/MovieReview.Application/"]
RUN dotnet restore "src/MovieReview.API/MovieReview.API.csproj"
COPY . .
WORKDIR "/src/src/MovieReview.API"
RUN dotnet build "MovieReview.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieReview.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieReview.API.dll"]