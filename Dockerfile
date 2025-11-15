FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet tool install --global dotnet-ef --version 9.0.4
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet ef migrations add m1 --verbose

RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "1lab.dll"]	
