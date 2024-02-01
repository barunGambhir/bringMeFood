# Bring Me Food Web Application

🚧 **Work in Progress**

## Overview

This is a fast food e-commerce web application developed using the ASP.NET framework and Microsoft SQL Server. The application allows users to browse a menu, add items to their cart, and place orders for delivery or pickup.

## Technologies Used

- **ASP.NET Framework:** The application is built using the ASP.NET framework, which provides a robust and scalable platform for building web applications.

- **Microsoft SQL Server:** The database backend is powered by Microsoft SQL Server, ensuring efficient and secure storage and retrieval of data.

## Usage

### Prerequisites

Make sure you have the following installed on your machine:

- Visual Studio (or any compatible IDE for ASP.NET development)
- Microsoft SQL Server Management Studio (SSMS)
- .NET Framework

### Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/your-username/fast-food-ecommerce.git
    ```

2. Open the project in Visual Studio.

3. Open the SQL Server Management Studio and execute the SQL scripts provided in the `database` folder to create the necessary database schema and seed data.

4. Update the connection string in the `Web.config` file with your SQL Server credentials:

    ```xml
    <connectionStrings>
        <add name="DefaultConnection" connectionString="Data Source=YourServer;Initial Catalog=YourDatabase;User ID=YourUsername;Password=YourPassword;" providerName="System.Data.SqlClient" />
    </connectionStrings>
    ```

### Running the Project

1. Build the solution in Visual Studio.

2. Press `F5` or click on the "Run" button to start the web application.

3. Open your web browser and navigate to `http://localhost:port` (replace `port` with the actual port number configured in your project).

4. You should now see the home page of the fast food e-commerce application.

## Contributing

If you'd like to contribute to this project, please follow the standard pull request process.

## License

This project is licensed under the [MIT License](LICENSE).
