# ASP.NET CORE

## Introduction to ASP.NET Core

#### What is ASP.NET core?

ASP.NET is a cross-platform, high-performance, open-source framework for building modern, cloud-enabled, internet-connected apps.

#### Why ASP.NET Core?

1. Unified Framework for UI, WEB and API
2. Testablitity 
3. Cross-Platform
4. Built in Dependency Injection
5. Support for gRPC
6. Light Weight
7. Ability to Host in
   1. Kestrel
   2. IIS
   3. HTTP.sys
   4. Apache
   5. Nginx
   6. Docker

#### Learning Paths

| App      | Use                                         | Module                |
| -------- | ------------------------------------------- | :-------------------- |
| Web      | server-side Web UI                          | Razor Pages           |
| Web      | Exisiting MVC                               | MVC with ASP.NET Core |
| Web      | Client side Web UI                          | Blazor                |
| web API  | RESTful HTTP services                       | WEB API               |
| RPC      | Contract-first services using Proto buffers | gRPC                  |
| Realtime | Bi-directional communication app            | SignalR               |

| Scene    | Module with Data Access |
| -------- | :---------------------- |
| New Site | Razor with EF core      |
| MVC      | MVC with EF Core        |

#### Compare ASP.NET 4.x and ASP.NET Core

| ASP.NET Core                  | ASP.NET                                              |
| ----------------------------- | ---------------------------------------------------- |
| Cross Platform                | Windows                                              |
| Razor Pages - Recommended     | Webforms, MVC, SignalR, WebAPI, WebHooks or WebPages |
| Multiple versions per Machine | One version only                                     |
| VS, VS for MAC, VS code       | VS                                                   |
| High Performance              | Good Performance                                     |
| .NET core runtime             | .NET framework runtime                               |

#### Compare .NET Core and .NET framework

Use .NET Core for your server application when:

- You have **cross-platform** needs.
- You're targeting **microservices**.
- You're using **Docker containers**.
- You need **high-performance and scalable** systems.
- You need **side-by-side .NET versions** per application.

Use .NET Framework for your server application when:

- Your **app currently uses .NET Framework** (recommendation is to extend instead of migrating).
- Your app uses **third-party .NET libraries** or NuGet packages not available for .NET Core.
- Your app uses **.NET technologies that aren't available** for .NET Core.
- Your app uses a platform that doesn’t support .NET Core. Windows, macOS, and Linux support .NET Core.

#### Create web project using CLI

- Create a web app project. 

  `dotnet new webapp -o aspnetcoreapp`

- Trust the development certificate.

  `dotnet dev-certs https --trust`

- Run the project.

  `cd aspnetcoreapp`
  `dotnet watch run`

- Make a change.

## ASP.NET Core fundamentals

1. [The Startup class](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#the-startup-class)
2. [Dependency injection (services)](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#dependency-injection-services)
3. [Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#middleware)
4. [Host](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#host)
5. [Servers](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#servers)
6. [Configuration](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#configuration)
7. [Environments](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#environments)
8. [Logging](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#logging)
9. [Routing](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#routing)
10. [Error handling](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#error-handling)
11. [Make HTTP requests](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#make-http-requests)
12. [Content root](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#content-root)
13. [Web root](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=macos#web-root)

#### The Startup Class

The startup class is where 

- Services & Configuration - ConfigureServices(IServiceCollection **services**)
- HTTP Pipelines config as series of middleware components - Configure(IApplicationBuilder app)

For more information, see [App startup in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-3.1).

#### The dependency injection

ASP.NET Core has built-in dependency injection (DI) framework that makes configured services available throughout an app.

```c#
` public void ConfigureServices(IServiceCollection services){
    services.AddDbContext<RazorPagesMovieContext>(options =>     options.UseSqlServer(Configuration.GetConnectionString("RazorPagesMovieContext"))); //Configure DBcontext Service
        services.AddControllersWithViews(); //MVC as service
services.AddRazorPages(); //RazorPages
}
```
You can also use thirdparty IOC container instead of built-in IOC container.

For more information, see [Dependency injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1).

#### Middleware

The request handling pipeline is composed as a series of middleware components.

Each Components - > HTTPContext -> either invokes next middleware or terminates

Use...

```c#
public void Configure(IApplicationBuilder app)
{
    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();
    
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapDefaultControllerRoute();
        endpoints.MapRazorPages();
    });

}
```

For more information, see [ASP.NET Core Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-3.1).

#### Host

OnStartup, Asp.net core builds a host. Host contains

1. HTTP server impl
2. Middleware comp
3. Logging
4. DI Services
5. Configuration

Two kinds of host: 1. NET generic host 2. ASP.NET core web host

Recommended: .NET generic Other one is for backward compatiblity

The `CreateDefaultBuilder` and `ConfigureWebHostDefaults` methods configure a host with a set of default options

1. Kestrel, Load config, logging

###### non-web scenarios

Generic Host allows other types of apps to use logging DI, config, app lifetime mgmt.

For more information, see [.NET Generic Host](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.1).

#### Servers

ASP.NET core uses HTTP server implementation to listen for HTTP requests.

The server surfaces requests to the app as a set of request features composed into a HTTPContext

For more information, see [Web server implementations in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/?view=aspnetcore-3.1).

#### Configuration

ASP.NET core provides Config Framework to read name-value. built-in - .json,.xml, env variables, cmd line args

Default: appsetting.json

Values from Environment Variable overrides appsettings.json

Prefeered way to get: Options Pattern  [options pattern](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-3.1)

For managing confidential configuration data, ASP.NET core provides SECRET Manager [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1#secret-manager).

For more information, see [Configuration in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-3.1).

#### Environments

Specify the environment an app is running in by setting the `ASPNETCORE_ENVIRONMENT` environment variable.

stores the value in an `IWebHostEnvironment` implementation.

For more information, see [Use multiple environments in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-3.1).

#### Logging

ASP.NET Core supports a logging API that works with a variety of built-in and third-party logging providers. 

- Console
- Debug
- Event Tracing on Windows
- Windows Event Log
- TraceSource
- Azure App Service
- Azure Application Insights

For more information, see [Logging in .NET Core and ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-3.1).

#### Routing

A *route* is a URL pattern that is mapped to a handler. The handler is typically a Razor page, an action method in an MVC controller, or a middleware.

For more information, see [Routing in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-3.1).

#### Error Handling

ASP.NET Core has built-in features for handling errors, such as:

- A developer exception page
- Custom error pages
- Static status code pages
- Startup exception handling

For more information, see [Handle errors in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-3.1).

#### Make HTTP requests

An implementation of `IHttpClientFactory` is available for creating `HttpClient` instances.

[Make HTTP requests using IHttpClientFactory in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1).

#### Content root

The content root is the base path for:

- The executable hosting the app (*.exe*).

- Compiled assemblies that make up the app (*.dll*).

- Content files used by the app, such as:

  - Razor files (*.cshtml*, *.razor*)
  - Configuration files (*.json*, *.xml*)
  - Data files (*.db*)

- The [Web root](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/?view=aspnetcore-3.1&tabs=linux#web-root), typically the *wwwroot* folder.

  For more information, see [Content root](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.1#contentroot).

#### Web root

The web root is the base path for public, static resource files, such as:

- Stylesheets (*.css*)
- JavaScript (*.js*)
- Images (*.png*, *.jpg*

For more information, see [Static files in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-3.1).