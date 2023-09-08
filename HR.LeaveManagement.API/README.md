## API Component

In this component, we handle the HTTP requests coming from the client side. Additionally, we also implement middlewares that handle errors, logs, and user authorization/authentication.

### Exception Middleware

To transform the possible exceptions that might be raised in each part of the system into user-readable messages, we have implemented an inherited class from Microsoft.AspNetCore.Mvc.ProblemDetails. Furthermore, in the ExceptionMiddleware, we embed this object in the response, allowing the user to access more information about what is going on.


### Configuring the Services
In the other projects we have implemented extension methods on `IServiceCollection` and register each dependencies separately on the respective components, and apply the configuration in `Program.cs` file:

```
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);
```
