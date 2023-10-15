# Eau Claire's Employee & Client Management Software
### By Genesis Scott

A web application that allows managers to manage their employees' details and add clients.

### Technologies Used
- .NET 6.0
- ASP.NET Core MVC
- Entity Framework Core
- Bootstrap
- C#
- HTML
- CSS

### Setup/Installation Requirements
1. Ensure .NET SDK and runtime are installed on your machine.
2. Clone this repository to your local machine.
3. Navigate to the HairSalon.Solution directory in your terminal.
4. Touch a file in the HairSalon.Solution directory called appsettings.json add the following code, replacing the uid and pwd values with your own username and password for MySQL.

```bash
$ touch appsettings.json
```

```csharp
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=Genesis_Scott;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
  }
}
```
5. Set up the Database. Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://part-time.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the Genesis_Scott.sql file located at the top level of this repo to create a new database in MySQL Workbench with the name Genesis_Scott.
6. Run the command ```dotnet restore``` to install necessary packages.
7. Run the command ```dotnet build``` to compile the application.
8. Run ```dotnet run``` to start the server and application.
9. Visit localhost:5000 in your browser to access the Employee Manage application.
10. Follow on-screen prompts to manage employee details.
11. If you come across any difficulties or wish to give feedback, don't hesitate to get in touch or raise an issue on the repository.

## Known Bugs
- CSS styles might not be immediately applied because of caching challenges.
- There might be a need to manually stop the server (Ctrl+C) before executing dotnet watch run again.
## License
If you have queries, feedback, or are interested in contributing to the codebase, feel free to get in touch.

Single point of contact: genesis@evolve-self.org
