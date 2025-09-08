FROM mcr.microsoft.com/dotnet/sdk:9.0@sha256:3fcf6f1e809c0553f9feb222369f58749af314af6f063f389cbd2f913b4ad556 AS build

# start off by creating the directory within the image
WORKDIR /app

# Copy all of the files into the image.
COPY . .

# run restore to get all of the necessary nuget packages used for the project.
RUN dotnet restore

# Finally, compile the project into an executable called "out"
RUN dotnet publish -o out



FROM mcr.microsoft.com/dotnet/aspnet:9.0@sha256:b4bea3a52a0a77317fa93c5bbdb076623f81e3e2f201078d89914da71318b5d8

# Create a new directory for the run time
WORKDIR /app

# Copy the build fom the build stage to run
COPY --from=build /app/out .

# Finally, run the dll file from the compiled build.
ENTRYPOINT [ "dotnet", "AttendanceTrackerApp.dll" ]