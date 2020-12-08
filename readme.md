## project was created using the following command
```
mkdir DatingApp
cd /DatingApp ```
- command to create a new solution file : ```dotnet new sln```
- create a new project : ```dotnet new webapi -o API``` 
- add API project into the solution : ```dotnet sln add API/```
## Run/build the project
- command : ```cd /API```, then run ```dotnet run```

## update Start.cs
- replace the Start constructor with the code below
```
    private readonly IConfiguration _config;
    public Startup(IConfiguration config)
    {
         _config = config;
    }
```

- add Token service to the startup.cs configuration
```
services.AddScoped<ITokenService, TokenService>();
```



## configure connection strings in appsettings.js > appsettings.Development.js

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data source=datingapp.db"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```


## install dotnet-ef
- source url: https://www.nuget.org/packages/dotnet-ef/
- command: ```dotnet tool install --global dotnet-ef --version 5.0.0```

## create initial migration
- command: ```dotnet ef migrations add initialCreate -o Data/Migrations```

## update migration

- command : ```dotnet ef migrations add UserPasswordAdded```
```dotnet ef migrations add migrationName```
```dotnet ef migrations remove```

## create database
- command: ```dotnet ef database update```


## drop database
- command: ```dotnet ef database drop```



## VS code setup and extension installation
- C#
- c# extensions
- Material icon theme
- NuGet Gallery
- enable auto save go to File => Auto save
- exclude files from solution go to Code => Preferences => Settings => search for exclude 
- set folder compact mode Explorer go to Code => Preferences => Settings =>: Compact Folders