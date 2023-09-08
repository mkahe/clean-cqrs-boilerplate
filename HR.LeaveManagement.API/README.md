## API Component

In this component, we handle the HTTP requests coming from the client side. Additionally, we also implement middlewares that handle errors, logs, and user authorization/authentication.

## Exception Middleware

To transform the possible exceptions that might be raised in each part of the system into user-readable messages, we have implemented an inherited class from Microsoft.AspNetCore.Mvc.ProblemDetails. Furthermore, in the ExceptionMiddleware, we embed this object in the response, allowing the user to access more information about what is going on.


