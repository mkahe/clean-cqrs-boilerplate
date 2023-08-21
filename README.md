## CQRS CLean Architecture Boilerplate

__Welcome!__

This is a boilerplate project of the combination of _Clean Architecture_ and _CQRS_ written with .NET Core 7.0 (STS) and C#. This project is designed to provide a solid foundation for building robust and maintainable applications on top of abovementioned architectures. The architecture follows the principles of separation of concerns, promoting modularity, and improving testability. I have integrated some powerful libraries and concepts to streamline the development process and ensure code quality.

### Key Concepts and Libraries

#### CQRS (Command Query Responsibility Segregation)
The project follows the CQRS pattern to separate read and write operations. Although you might see that read/write databases are almost the same, it is not challenging to segragate these two layers (Maybe I do that sometime soon)

#### Mediator
I've employed the Mediator pattern to enable loose coupling between components and facilitate communication between different parts of the application efficiently. I have employed the powerful NuGet library [MediateR](https://github.com/jbogard/MediatR) for this case.

#### Automapper
Automapper simplifies the mapping of data between objects, reducing boilerplate code and enhancing code readability.

#### Exception Handling
I have implemented custom exceptions (HR.LeaveManagement.Application project) to handle general and specific error scenarios.

#### Fluent Validation: 
Fluent Validation NuGet library helps to define and enforce validation rules in a clear and concise manner.

I hope this boilerplate will accelerate your development process and provide a solid foundation for your projects. Feel free to customize it further based on your specific requirements and add your own functionalities. Happy coding!

## TODO Automation
Using Mock and Shouldly
Entity Framework Inmemory

## TODO NSWAG
