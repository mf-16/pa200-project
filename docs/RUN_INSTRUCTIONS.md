# RUN_INSTRUCTIONS.md


## Running the application

First clone the repository
```
git clone git@gitlab.fi.muni.cz:xforman2/pv179-project.git
cd pv179-project
```


### Configuration Files

The application uses the following configuration files:

- `appsettings.json`: Contains default configuration settings.
- `appsettings.Development.json`: Contains settings for the development environment. This file is not tracked by git, you need to create your own. Template can be found in `template.appsettings.Development.json`
- `appsettings.Production.json`: Contains settings for the production environment. This file is not tracked by git, you need to create your own. Template can be found in `template.appsettings.Production.json`


## Running the application locally

Run the PostgreSQL database using Docker. You can use the following command to run it directly:

```
docker run -d \
  --name my-postgres \
  -e POSTGRES_USER=user \
  -e POSTGRES_PASSWORD=password \
  -e POSTGRES_DB=development \
  -p 5432:5432 \
  postgres:latest
```

Open a terminal in the project directory and run the application using the .NET CLI:

```
dotnet run --project ./WebAPI/WebAPI.csproj
```


## Running application with docker compose


Make sure to set environment variables in a `.env` file.
You should create `.env` file in the root directory of the project. This file should be created from the template `.env.example` file.

Environment variables for database in the `.env` file should check out with the `appsettings.{YOUR_ENV}.json`

Run the following command to build the Docker image and start both the Web API and the PostgreSQL database:

```
docker compose up
```

## Applying migrations

To ensure that the database you created is correctly configured for the application to run, you need to migrate the database using the following command:

```
dotnet ef database update --project ./DAL.PostgreSQL.Migrations/DAL.PostgreSQL.Migrations.csproj --startup-project ./WebAPI/WebAPI.csproj -- --environment <YOUR_ENV>
```



