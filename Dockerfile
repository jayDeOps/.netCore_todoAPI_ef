FROM  microsoft/aspnetcore:1.1.0

WORKDIR /app

COPY bin/Release/netcoreapp1.1/debian.8-x64/publish ./

ENTRYPOINT ["dotnet", "todoAPI.dll"]

