# CinemaTracker

#### _A Cinema Tracker app that allows for movies to be created by genre, and include actors that are generated as well - August 2019_

#### _By **Erik Irgens**_

## Description

This application was created with the intention of practicing an MVC application that would create relational database entities. Specifically, this app was intended to create a list of Movies that were many-to-many related to Genres and Actors, so that you may browse movies by actor, actors by movie, or movies by genre. 
### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User can visit vews to create new movies** | Visit create movie page | Movie is created and held in memory  |
| **User can view a new movie** | Movie page | Details page |
| **User can CRUD the new movie** | Details page | Options to delete, update |
| **User can visit vews to create new genres** | Visit create genre page | genre is created and held in memory  |
| **User can view a new genre** | genre page | Details page |
| **User can CRUD the new genre** | Details page | Options to delete, update |

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/erik-t-irgens/CinemaTracker
    ```
2. Update your database (using provided migrations)
    ```
    $ dotnet ef database update
    ```
3. Run the application in the root directory
    ```
    $ dotnet run
    ```
4. Visit the MVC localhost:5000/
    ```
    localhost:5000/
    ```

## Known Bugs
* Not all views are completed at this time, so full functionality is not yet present. 

## Technologies Used
* C#/.NET, ASP.NET Core 2.2, MVC architecture, Linq, MySQL and SQL databases

## Support and contact details

_Please contact Erik Irgens with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Erik Irgens_**
