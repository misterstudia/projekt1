FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY . .
RUN dotnet build -c Release
CMD ["dotnet", "run", "-c", "Release"]