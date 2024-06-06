2024-05-16
Aditya
1730 UTC


####Part 1- Get Started
1730 UTC

Created a project name MVC Movies and added a controller

1745 UTC
Ran the program, Confirmed the default works:
https://localhost:[Port]/
Modified the index.cshtml title to MVC MOVIE by replacing the default title WELCOME
Created README.in the MVC Movies
Was able to confirm the default page

1810
I confirmed Part1 of the tutorial is complete, The started with part2

Part2-Add a Controller

1830 UTC

Commented the default index method which is returning to class view()
Then added new index method and changed the content to "This is my default action..."
Was running when i ran the program

https://localhost:[Port]/Helloworld

1845  UTC
Added another method called welcome with the content of "This is the Welcome action method..."
Confirmed it was running

https://localhost:\[Port]/Helloworld/welcome

1855 UTC

Change the Welcome method to include two parameters(name,numtimes)
Ran the program, Confirmed the changes works:

https://localhost:[Port]/helloworld/welcome?name=Aditya&numTimes=6

23/052024
####Part3-Add a view

0130 UTC

Added the Index in the helloworldcontroller

0135 UTC

Created a razer file in Views/HelloWorld/Index.cshtml added the CSHTML which showed the index
webpage.

0145 UTC

Change the title, footer, and menu in Views/Shared/_Layout.cshtml added the CSS code.
so than when we click on privacy it created the new page.

0155 UTC

In HelloWorldController.cs, change the Welcome method to add a Message 
and NumTimes value to the ViewData dictionary.

0205 UTC

 now that is opened https://localhost:][Port]/HelloWorld/Welcome?name=Aditya&numtimes=4

 it showd my name 4 times. and you can the numtimes to 10 and it will show your name 10 times.

####Part-4 Add a modal

 0255 UTC

 i added the scafolded the movie page and update the files in nutgets in tools and when i clicked the 
 movieapps link it showed me the database.

 0315 UTC
 Timestamp
 20240523184636_InitialCreate is the Migrations timeframe

 In the index i created some list of movies with differet columns.

 30/05/2024
####Part-5 Work with Database

14:00 Configured Database Context in Program.cs

14:03 i added Connection String in appsettings.json

14:05 Created SeedData Class in Models Folder

14:10 Implementd SeedData Initialization Logic

14:13 Modify Program.cs to Call SeedData Initialize

14:16 Verify Seeded Data in Application

14:20 Check Database Records Using SSOX

14:21 Confirmed Application Functionality with Seed Data

30/05/2024
####Part-6 Controller action and views

13:30 Added DataAnnotations for "Release Date" and price formatting.

13:32 Ensure "Release Date" shows correctly without time.

13:37 Examined the generation of Edit, Details, Delete links in Views/Movies/Index.cshtml.

13:40 Viewed the source in the browser to understand the generated markup.

13:42 Analyzed GET and POST Edit methods in MoviesController.

13:45 Confirmed use of [ValidateAntiForgeryToken] attribute for security.

13:49 Updated Views/Movies/Edit.cshtml to render form elements and handle validation.

13:53 Ran the app, navigated to /Movies, and verified the "Release Date" display.

30/05/2024
####Part-7 Add search

13:30 Added search capability to the Index action method in Controllers/MoviesController.cs.

13:32 Modified LINQ query to filter movies by title.

13:37 Updated routing to handle search title as route data.

13:40 Added UI elements for filtering movies in Views/Movies/Index.cshtml.

13:42 Explained deferred query execution and LINQ expressions.

13:45 Discussed limitations of POST method in capturing search information.

13:49 Specified request method as HTTP GET to retain search query string in URL.

13:53 Implemented search by genre functionality in the Index view.

30/05/2024

####Part-8 Add a new field

16:30 Implemented search capability in the Index action method of Controllers/MoviesController.cs.

16:32 Defined LINQ query to select movies, deferred query execution explained.

16:37 Updated routing to accept search title as route data.

16:40 Added UI elements for filtering movies in Views/Movies/Index.cshtml.

16:42 Discussed Lambda Expressions and deferred query execution in LINQ.

16:45 Noted limitations of POST method in capturing search information.

16:49 Specified request method as HTTP GET to retain search query string in URL.

16:53 Added search by genre functionality and ViewModel in the Index view.

####Part-9 Add a validation

14:05 Added Rating property to the Movie model in Models/Movie.cs.

14:10 Updated property binding list in MoviesController.cs for Create and Edit action methods to include the Rating property.

14:13 Updated view templates in Views/Movies/Index.cshtml and Views/Movies/Create.cshtml to display and include the Rating field.
 
14:16 Updated SeedData class to provide a value for the new Rating column.

14:19 Used Code First Migrations to update the database schema with the new Rating column.

At first Rating column was avilable but these was no value so i was edited the movie to add the 
rating but the validation was to add an alphabat



2024-06-06

# I created updated the seeddatabse while deleting the old data and updating new one with 5 new 
movies added in seeddabase.

20240526193525_Rating- this the migration time for Rating column