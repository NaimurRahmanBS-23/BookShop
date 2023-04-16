# BookStore a web based application
This repository contains the **BookStore** source code. 
BookStore is a web application based on **Asp.Net-core**.

# Introduction
This is simple BookStore webapplication where you can:
```
+ Can see all the books available in the store
+ Add new book to the store
+ Delete a book from store
+ Update a book information 
+ Delete an Author
+ Update an Author details
```
# Documentation to run this project locally.

This app is based on asp.net core (MVC)  ,and needs sql sever to run. 
```
+ Open the souce code with Visual Studio 2023 or higher
+ The sql server must have a database called BookStore
+ In our code we have used several NuGet Package Manger
  + Microsoft.EntityFrameworkCore
  + Microsoft.EntityFrameworkCore.SqlServer
  + Microsoft.EntityFrameworkCore.Tools
  + Microsoft.VisualStudio.Web.CodeGeneration.Design

  To Create data table :
  + Go to the Nuget Package console
  + Type add-migrate "migration Name without quota" and hit enter
  + type update-database and hit enter
 This will create all needed database table for this application
```
Now you can click the run button and application will run a port specified in the LauchSetting.json file.

# Issue
This repository is maintained actively,so if you face any issue please [raise an issue](https://github.com/NaimurRahmanBS-23/BookStore/issues).

# **Liked the work ?**

Give the repository a star:-)