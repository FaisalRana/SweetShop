# Pierrs's SweetShop SweetShop

### Epicodus Independent Code Review - Identity and Authentication

### By Faisal Rana

## Technologies Used

* Git
* C#
* .NET 5.0
* ASP.NET Core
* Entity Framework Core
* Razor View Engine
* MVC
* RESTful Routing, CRUD & HTTP
* REPL
* MySQL & MySQL Workbench
* Bootstrap
* CSS
* Many-to-Many Relationships
* ASP.net Core Identity 


## Description

This is a website for Pierre's Sweet Shop.  It uses authorization and a many to many relationship to create an interface that allows for a database of sweets and treatsd to be linked together and displayed.  

This webpage must have the following functionality:

- The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
- There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
- A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.


## Setup/Installation Requirements

* _Download Visual Studio Code Installation_
* _Open the terminal on your local machine_
* _Navigate to the project root directory_
* _Clone this project with the following command  `$ git clone <https://github.com/FaisalRana/SweetShop.git>`_
* _Download and install .NET Core through this link if you don't already have it: https://dotnet.microsoft.com/download_
* _Open this project in Visual Studio Code with the command `$ code .`_
* _Navigate to the `SweetShop` directory and create an **appsettings.json** file and input the following script. 
![Image of appsettings.json example](SweetShop/wwwroot/images/appsettings.json_test.png)

* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Follow instructions **below** to install mySQL abd mySQL workbench **below**_
* _Create internal content for build with the command `$ dotnet build`_
* _Follow instructions for migrating database **below**_
* _Use command `$ dotnet run`_ to launch web application.

**MySQL and MySQL Workbench Setup Instructions**

* Download MySQL Workbench here: https://dev.mysql.com/downloads/file/?id=484391
* For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
* For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)
* Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`

**Database Migration Instructions**
1. Navigate to SweetShop directory in terminal
2. Use the command `dotnet ef migrations iniital` and  `dotnet ef database update` to create database migration. 


## Diagram of the Many-To-Many relationship used in this project

![Image of SQL Designer](SweetShop/wwwroot/images/schema.png)


## User Stories 
 

## Known Bugs


## Link

Currently, this project is not hosted online. 

## License

Copyright (c) 2021 Faisal Rana

This software is licensed under the MIT license

