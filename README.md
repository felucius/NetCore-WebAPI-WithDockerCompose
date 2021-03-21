# .NET Core 3.1 Web API with docker-compose.yml

A Dockerfile is added to the project to handle the containerization of the .NET Core 3.1 web API project. 

### Containerization
Next to this Dockerfile a docker-compose.yml has been added to handle the creation of multiple containers
* Creating a Microsoft 2017 SQL Server
* Containerize the web API project

The web API project is dependant of the SQL Server, so this SQL Server container must be created first and have its 
environment variables defined for the user to authenticate and connect to the database.

### Web API 
The web API consists of one controller that is able to perform CRUD operations on a User object.

### Extra
#### NuGet package
The Swashbuckle.ASPNetCore NuGet package has been installed to make it easier to interact with the web API

### Xunit
XUnit test project has been added to test the model and interfaces with the help of the Moq framework.
