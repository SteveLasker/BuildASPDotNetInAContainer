#!bin/bash
set -e
dotnet restore
dotnet test test/WebTests/project.json
rm -rf $(pwd)/publish 
dotnet publish src/Web/project.json -c release -o $(pwd)/publish/web
