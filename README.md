## CQRS CLean Architecture Boilerplate

__Welcome!__

This is a boilerplate project of the combination of _Clean Architecture_ and _CQRS_ written with .NET Core 7.0 (STS) and C#. This project is designed to provide a solid foundation for building robust and maintainable applications on top of abovementioned architectures. The architecture follows the principles of separation of concerns, promoting modularity, and improving testability. I have integrated some powerful libraries and concepts to streamline the development process and ensure code quality.

### Key Concepts

#### CQRS (Command Query Responsibility Segregation)
The project follows the CQRS pattern to separate read and write operations. Although you might see that read/write databases are almost the same, it is not challenging to segragate these two layers (Maybe I do that sometime soon)

#### Mediator
I've employed the Mediator pattern to enable loose coupling between components and facilitate communication between different parts of the application efficiently. I have employed the powerful NuGet library [MediateR](https://github.com/jbogard/MediatR) for this case.

#### Automapper
Automapper simplifies the mapping of data between objects, reducing boilerplate code and enhancing code readability.

#### Exception Handling
Custom exceptions in the Application module have been implemented to handle general and specific error scenarios.

#### Validation: 
Fluent Validation NuGet library helps to define and enforce validation rules in a clear and concise manner.

#### Authentication and Authorization
I've implemented authentication and authorization using `Microsoft.AspNetCore.Authentication.JwtBearer`. This package enables secure authentication by validating JSON Web Tokens (JWTs) issued by our identity provider.

#### Unit and Integration Testing
In the `test` directory you can find UnitTests (Not completed, and just to show how to test each unit) and Integration Test (to test third party libraries such as the database)

### Technologies
1. .NET Core (6/7/8)
1. CQRS
1. AutoMapper
1. .NET API
1. EF Core
1. xUnit
1. Moq
1. Shouldly
1. Entity Framework Inmemory
1. NSwag

I hope this boilerplate will accelerate your development process and provide a solid foundation for your projects. Feel free to customize it further based on your specific requirements and add your own functionalities. Happy coding!

### Getting Started

#### Development Mode
In order to run the project on the development mode, follow these steps:
1. Clone the repository
1. Open the solution on whatever IDE you like (VS2022 recommended)
1. Restore the nuget packages
1. Go to solution properties and set HR.LeaveManagement.Api as startup project.
1. Hit the run button or use .Net CLI

#### Production Mode
TODO

### Project Structure
The structure consisting of the following components:
1. `HR.LeaveManagement.Application`: This segment encompasses the application layer, housing the application's logic and interfaces.

1. `HR.LeaveManagement.Domain`: This segment encompasses the domain layer, housing the project's domain models and governing business rules.

1. `HR.LeaveManagement.Infrastructure`: This segment encompasses the infrastructure layer, where the actual implementations of the interfaces defined in the application layer reside.

1. `HR.LeaveManagement.Api`: This section contains the API layer of the project.

The following figure illustrates each component with class libraries inside, and also their dependencies to the other modules.
![alt text](/img/clean-architecture.png)

### TODO Tasks
Of course the application is not perfect and is yet to be matured. Feel free to add some issues. I am more than happy if you like to contribute to enhance the code.
