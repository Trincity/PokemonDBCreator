# PokemonDBCreator
Using Entity Framework and Angular 2.0, populates a database with Pokemon data.

This is a simple web application that can be used to populate and make changes to a database for Pokemon info.

Setup:
1. Install node.js
2. Using npm, install:
 - Angular
 - Angular-cli
3. Create your project using command line
 -ie. ng new myPokemonDbCreator
4. To start project, on command line type: 'ng serve' or 'ng start'
5. Create a Database named PokemonDb
 - Tables:
    1. Pokemon
       -id (primary key, int, not null)
       -dexNo (int, not null)
       -name (varchar(30), not null)
       -type1 (varchar(20), not null) will be changed to (int, FK, not null)
       -type2 (varchar(20), null) will be changed to (int, FK, not null)
       -baseHP (int, not null)
       -baseAttack (int, not null)
       -baseDefense (int, not null)
       -baseSpecialAttack (int, not null)
       -baseSpecialDefense (int, not null)
       -baseSpeed (int, not null)
       -baseTotal (int, not null)
    2. Moves
       -id (PK, int, not null)
       -moveid (int, not null)
       -name (varchar(100), not null)
       -description (varchar(500) not null)
       -type (FK, int, not null)
       -category (varchar(20), not null)
       -contest (varchar(20), not null)
       -pp (int, not null)
       -power (int, null)
       -accuracy (int, null)
       -gen (int, not null)
    3. Types
       -id (PK, int, not null)
       -Type (varchar(20), not null)
        
Using Entity Framework to create the webai calls from Angular to Database.
