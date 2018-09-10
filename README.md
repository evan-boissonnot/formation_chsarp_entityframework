# formation_chsarp_entityframework

the first directory : problem class library help you to resolve a big problem
how could we generate this command in Class library : dotnet ef migrations add InitMigration

Resolved with theses steps : 
- install this, in Cli Command : 
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

- add a factory implementing IDesignTimeDbContextFactory 

- get the appsettings configuration settings with CommandBuilder

Don't use the helping VS intellicode to add using EntityFrameworkCore.dll !



