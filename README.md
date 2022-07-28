# EntityFrameworkQueries

## Getting Started
- VS 2022
- .Net6
- AP Database Installed

May need to change the DB connection string in the AP Context class.
By default it points to mssqllocaldb. If your AP script is not installed on mssqlocaldb update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
```
