FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /source
COPY --from=build /source/out .
COPY ArquivoGrande.txt ./
ENTRYPOINT ["dotnet", "desafio-grandes-arquivos.dll"]