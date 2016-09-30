FROM microsoft/aspnetcore-build:1.0.1

RUN mkdir /app
WORKDIR /app

ADD project.json .
RUN dotnet restore --no-cache

ADD . .
RUN dotnet publish --output /out/. --configuration Release
ADD Dockerfile.deploy /out/Dockerfile
