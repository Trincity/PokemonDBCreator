# PokemonDBCreator
Using Entity Framework and Angular 2.0, populates a database with Pokemon data.

This is a simple web application that can be used to populate and make changes to a database for Pokemon info.

Setup:
1. Install node.js
2. Using npm, install:
 - Angular
 - Angular-cli
3. Create your project using command line
 - ie. ng new myPokemonDbCreator
4. To start project, on command line type: 'ng serve' or 'ng start'
5. The server project is now Code-First Entity Framework. I don't know if other IDEs support Code-First Migrations, but here are the steps for setting it up in Visual Studio.
 - Install Entity Framework using either Nuget Package Manager or using the Package Manager Console running the "Install-Package EntityFramework" command.
 - Using the Package Manager Console:
  1. "Enable-Migrations"
  2. "Add-Migration", type the name of your migration
  3. "Update-Database"
        
Using Entity Framework to create the webai calls from Angular to Database.
