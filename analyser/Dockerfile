FROM microsoft/dotnet:2.0.0-sdk-jessie

ADD ./JieBaDemo /usr/local/JieBaDemo
WORKDIR /usr/local/JieBaDemo/

RUN cd /usr/local/JieBaDemo/
RUN dotnet restore -s https://api.nuget.org/v3/index.json
RUN dotnet test