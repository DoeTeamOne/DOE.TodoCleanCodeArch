# DOE.Todo

# Clean Code Architecture
Contais 4 project each represent
Domain

Application

Infrastructure

Presetation


# 1. The Domain Project Contains The Core Domain Entities , Enums and Value Objects
This Project has no dependency in any of the Project   
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

It doesn’t contain any Business Logic

It contains entities and enums

# 2.  Application Project : this contains the business Logic of the app

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.
It has dependency on Domain Project 

Contain Service Abstractions but not Implementation

Mappings and DTOs

# 3. Infrastructure : contains concrete implementation of interfaces Defined in Application
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.
Hundle communication with external Database

Hundel communication with 3dr party Apis

# 4 Presentation Layer(might be UI or WebAPi Project)
This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only Startup.cs should reference Infrastructure.
Contain controllers 

Connetion string configs

Communicate with Appliction using Mediator







