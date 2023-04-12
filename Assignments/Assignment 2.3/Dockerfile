FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Assignment 2.3.csproj", "./"]
RUN dotnet restore "Assignment 2.3.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Assignment 2.3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Assignment 2.3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assignment 2.3.dll"]
