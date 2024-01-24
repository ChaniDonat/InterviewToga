# Base image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

# Set the working directory in the container
WORKDIR /app

# Copy the source code into the container
COPY . ./

# Restore the dependencies
RUN dotnet restore

# Build the project
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0

# Set the working directory in the container
WORKDIR /app

# Copy the published binaries from the build-env stage
COPY --from=build-env /app/out .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "InterviewToga.dll"]