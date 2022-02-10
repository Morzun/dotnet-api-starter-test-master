# Dish API Test

## Api management test backend (C#/Net)
This is a test made by FrontEdge IT to be used in the recruitment process to the company. The aim is to determine the skills within C#/Net and api management.

Make sure to read the instructions carefully before starting.

Usually a api such as this is divided into several separate projects with different concerns. For simplicity we only have one here.

## Instructions
* In this test you are supposed to create a fully functional api which can retrieve all dishes along with a average price.
  You are also supposed to be able to retrieve a single dish, update a single dish and also delete a single dish.
* If needed, use the exceptions found under exceptions folder.
* Make sure that internal data models are mapped and leveraged as dtos to the one using the api.
* The application uses an inmemory database which means also changes done are gone when restarting the program.
* Once the application is started the in memory database is automatically seeded.
* Async Await is not needed since we are using an inmemory database.
* Use the dish repository to communicate with the inmemory database and call these methods from the controller.
* Use the model validation if needed.
* The logger can be used to log information during requests in the terminal. Read more: [Link](https://docs.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line)

## Get started
* Fork and clone the repo.
* Make sure to have a appropriate code editor such as Rider, Visual Studio or Visual Studio code.
* Make sure to install dotnet ef tools in order to run the project successfully: [Link](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
* To check if you successfully installed dotnet ef tools run `dotnet ef`.

## When done
* Either link you solution or zip it and send it to [fredrik.lunde@frontedgeit.se](mailto:fredrik.lunde@frontedgeit.se).
* We will then review your pull request.
* If there are any questions, feel free to contact [fredrik.lunde@frontedgeit.se](mailto:fredrik.lunde@frontedgeit.se).

## Advice
* In order to test your api successfully, use a tool such as [postman](https://www.postman.com/) or [insomnia](https://insomnia.rest/).
* Use exceptions given if needed.
* Make sure to save changes when using db context.
* Keep the controllers as clean as possible. Since we have no middle layer between the controller and repository, some might end up here though.

## Aim of the test
* Setup a fully functional api for retrieving all dishes with average price, retrieving a single dish, deleting a single dish and updating a single dish.
* Make your code as clean and reusable as possible and keep you controllers clean even if we have no middle layer between the repository.
* Follow the interfaces given and don't make changes to them. Implement according to the interfaces.
* The one calling the api should not be concerned about the internal representation of the data, therefore use mapping and return dtos.
* Make sure to not leave unused imports and structure your code correctly with indentations and white spaces.
* Using Linq when calculating average price is a bonus.
* Understanding and using model validation is a bonus.

## What we will judge
* How clean and reusable your code is.
* If you have written your code and taken care of unused imports, white spaces and indentations.
* You have taken care of edge cases and used exceptions if needed.
* You have kept your controllers as clean as possible.
* You have used mapping correctly.
* All api method connected to the dishes are implemented correctly and work as expected.
* Model validation have been used.
* Logger have been used where suitable.
* Own initiatives are allowed, but should not be prioritized over fulfilling the instructions. 

## Bonus
* Add business rule in order to not allow a price raise by more than 20% and cast appropriate exception if done.
* Add business rule in order to disallow saving dishes with the same and name and cast appropriate exception if done.

## When are you finished?
* All required methods are implemented.
* You think you have handled all edge cases and used exceptions if needed.
* You feel that your code is as structured, clean and reusable as you can achieve.
* You have used mapping in way you think is correct.
* Target framework is .NET 6.0 so make sure to have .NET 6.0 SDK installed.

## Scripts to be used

In the project directory of the api you can run the following commands.

### `dotnet run`

Runs the application without listening to changes.
Open [https://localhost:7246](https://localhost:7246) or [http://localhost:5063](http://localhost:5063) as base url when making requests to the api.

### `dotnet watch run`

Runs the application and listens to code changes.
Open [https://localhost:7246](https://localhost:7246) or [http://localhost:5063](http://localhost:5063) as base url when making requests to the api.

### `dotnet build`

Builds the project to see if any errors or warnings occur.

### `dotnet restore`

Restores the dependencies and tools of a project. Most often not needed since both dotnet build and dotnet run restores implicitly. 
