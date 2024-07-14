# AdminLTE 3 RTL Integration with ASP.NET Core MVC

Welcome to the AdminLTE 3 RTL integration with ASP.NET Core MVC repository! This project demonstrates how to integrate AdminLTE 3, a popular open-source admin dashboard template, with ASP.NET Core MVC to create a sleek and responsive user interface for managing web applications.

## Features

- **AdminLTE 3**: Utilizes AdminLTE 3 as the front-end framework, offering a modern and responsive admin dashboard layout.
- **RTL Support**: Integrated with Right-to-Left (RTL) language support, suitable for languages such as Arabic.
- **ASP.NET Core MVC**: Demonstrates usage with ASP.NET Core MVC, providing server-side functionality and data handling.
- **Authentication and Authorization**: Implements secure login and role-based access control (RBAC) using ASP.NET Core Identity.
- **Localization**: Supports multi-language capabilities through resource files for different cultures.
- **Error Handling Middleware**: Centralized error handling to manage and log exceptions efficiently.
- **Roles and Permissions**: Fine-grained access control with roles and permissions management.
- **JWT Authentication**: Integrated JWT (JSON Web Token) authentication for secure API access.
- **Swagger Documentation**: Includes Swagger UI for API documentation and testing.
- **Session Management**: Utilizes ASP.NET Core session middleware for managing user sessions.
- **Global Exception Handling**: Implements custom middleware for handling global exceptions.
- **Cors Configuration**: Configured CORS (Cross-Origin Resource Sharing) policies for API integration.
- **Database Integration**: Uses Entity Framework Core with SQL Server for database operations.
- **Request Localization**: Supports multiple cultures and UI cultures for localized content.


## Getting Started

To get started with this project:

1. **Clone the repository**: `git clone https://github.com/mohamedelareeg/AdminLTE-3-RTL-AspNetCore-MVC.git`
2. **Prerequisites**:
   - .NET Core SDK 8.x
   - Visual Studio IDE or your preferred code editor
3. **Setup and Run**:
   - Open the solution in Visual Studio.
   - Restore NuGet packages and build the solution.
   - Set up your database configuration if needed (check `appsettings.json` for connection strings).
   - Run the application and explore the functionalities.
4. **Explore Features**:
   - Navigate through the dashboard interface powered by AdminLTE 3.
   - Test authentication with different user roles and permissions.
   - Experiment with RTL language support and localization features.

## Directory Structure

The project structure includes:

- **Controllers**: ASP.NET Core MVC controllers handling business logic and request handling.
- **Views**: Razor views powered by ASP.NET Core MVC for rendering UI elements and layouts.
- **Models**: Entity models and view models used for data representation and business logic.
- **wwwroot**: Static assets such as CSS, JavaScript, and images.

## Prerequisites

- [.NET Core SDK 8.x](https://dotnet.microsoft.com/download)

Ensure you have the .NET Core SDK 8.x installed on your development machine to build and run the project.

## Configuration

- **Authentication**: Configure authentication settings in `Program.cs` to suit your application's requirements.
- **Localization**: Customize resource files under `Resources` for different languages supported by your application.
- **Error Handling**: Adjust error handling middleware in `Program.cs` to log exceptions and manage error responses effectively.

## Acknowledgement

This project is built upon [AdminLTE](https://adminlte.io/), an open-source admin dashboard template. AdminLTE provides the foundational UI components and styles used in this repository.

## More Information

- **AdminLTE Website**: [AdminLTE.io](https://adminlte.io/)
- **GitHub Repository**: [AdminLTE on GitHub](https://github.com/ColorlibHQ/AdminLTE)

## Contributing

Contributions are welcome! If you have suggestions, feature requests, or bug reports, please [create an issue](https://github.com/mohamedelareeg/AdminLTE-3-RTL-AspNetCore-MVC/issues) or submit a pull request.

## Author

Developed by [Mohamed EL Sayed](https://github.com/mohamedelareeg), showcasing the integration of modern front-end frameworks with robust back-end technologies to build scalable and user-friendly web applications.


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
