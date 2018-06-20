FROM microsoft/dotnet:2.0.0-sdk-jessie
#FROM microsoft/dotnet:1.1.5-sdk-jessie

ADD ./RedisDemo /usr/local/RedisDemo
WORKDIR /usr/local/RedisDemo/

RUN cd /usr/local/RedisDemo/
RUN dotnet restore -s https://api.nuget.org/v3/index.json
RUN dotnet test