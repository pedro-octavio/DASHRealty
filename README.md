# DASHREALTY
An API to control a real estate system.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download);
* Some Database, in this case as using [MySql](https://www.mysql.com);
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in root directory
2) Insert a secret key in REALTYDash.Domain/Settings.cs
3) Insert your connectionstring in REALTYDash.API/appsettings.Development.json
4) Update database using this command:
> Update-Database
5) Run the DASHRealty.API project;
**The user master is: email: admin@admin.com, password: admin12345**
## VERSIONS
* 1.0.0 - First Commit;
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*