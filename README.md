# Clean Repository Pattern with .NET 7

This solution was adopted from Jason Taylor's clean architecture. While the solution starts there, there are some adjustments with the coding patterns to follow Repository Pattern that help to ease the developers to develop and maintain the application.

## Technologies

* [ASP.NET Core 7](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [Entity Framework Core 7](https://docs.microsoft.com/en-us/ef/core/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [JWT Token](https://jwt.io/)

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

## Support :star:

Has this Project helped you learn something New? or Helped you at work?
Here are a few ways by which you can support.

-   Leave a star! :star:
-   Recommend this project. 🥇
-   Or, If you want to support this project in the long run, [consider buying me a coffee](https://www.buymeacoffee.com/hansadrianus)! ☕

<br>

<a href="https://www.buymeacoffee.com/hansadrianus"><img width="250" alt="black-button" src="https://user-images.githubusercontent.com/31455818/138557309-27587d91-7b82-4cab-96bb-90f4f4e600f1.png" ></a>