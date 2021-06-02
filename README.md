# dotnet-ng-products

CRUD project created using dotnet core 3.1 and Angular 8.2.12.

Make sure you have the .NET SDK installed in your machine.

To create the database, you need to first install the dotnet-ef lib, since is no longer part of the .NET Core SDK.

dotnet tool install --global dotnet-ef

Then open powershell inside root folder of the application and run the migration upodate command pointing to Api project.

dotnet ef database update --project=DotnetNgProducts.Api

After that, open "DotnetNgProducts.sln" using Visual Studio and run the application.
Make sure that DotnetNgProducts.Api is set as the main project of the solution.
