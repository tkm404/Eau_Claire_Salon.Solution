# Eau Claire's Salon (Week 9 ICR)

#### Week 9 Code Review at Epicodus. Section: Database Basics. A project to demonstrate my knowledge of using a Database to update a web application. Simulating an application being used by "Claire" to keep track of their employees and clients at a hair salon. 

#### By Thomas McDowell 

## Technologies Used:
* C#
* .NET 6.0
* MySql

## Description:
This will be a MVC web application to manage employees (stylists) and their clients. The user should be able to add a list of stylists working at their salon, and for each stylist, add the clients who see them. The stylists have specific specialities, so each client can only belong to a single stylist. The user needs to be able to:
1. See a list of all stylists.
2. select a stylist, see their details, and see a list of all clients that belong to them.
3. add new stylists to the system when they are hired.
4. add new clients to a specific stylist. Clients cannot be added if there are no stylists.

For the purposes of this project, my production database should be titled as firstName_lastName, and my production directory is titled HairSalon.



## Setup/Installation Req's:

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/lessons/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench). use the example of `todolist_with_ef_core_dump.sql` to create a new database in MySQL Workbench with the name of your project `project_name`.

### Set Up and Run Project
1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "CsharpTemplate". //Rename this with your project name and delete all this text between the forward-slashes. Also look carefully throughout and replace all placeholder [things in bracks] with your project's name and model names.//
3. Within the production directory "CsharpTemplate", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=project_name;uid=root;pwd=epicodus;"
  }
}
```

INSTRUCTIONS:
Follow the links on each page, and navigate to various forms where you can enter in Stylists (employees), and Clients assigned to each employee. Clicking on Stylist details will show a list of clients assigned to them. Clicking on "All Clients" links will show an overall list of Clients and which Stylists they belong to. That's about it for now! 

## Known Bugs:
WIP on styling. Tried to get ambitious (see addArt branch), but I found out a little late that my css folder was in the wrong place. Having trouble staging the images as well.

## License:
(c) 2023 Thomas McDowell ; MIT

![image](https://github.com/tkm404/Eau_Claire_Salon.Solution/assets/127699298/2eebb0f8-9312-4b47-a09d-3673dd0b9a2d)
