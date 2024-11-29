# BlogWeb

**BlogWeb** is a simple blog platform built with ASP.NET Web Forms. This project allows users to create, view, and manage blog posts, providing an easy-to-use interface and a basic content management system.

## Features

- User registration and authentication
- Create, edit, and delete blog posts
- Sidebar for navigating through the site
- Basic blog layout with responsive design
- Data stored in a SQL Server database

## Technologies Used

- **Frontend**: HTML, CSS, JavaScript (jQuery)
- **Backend**: ASP.NET Web Forms
- **Database**: SQL Server
- **Other**: C# for backend logic

## Getting Started

To run this project locally, follow the steps below:

1. **Clone the repository:**

    ```bash
    git clone https://github.com/bartugkeskn/BlogWeb.git
    ```

2. **Open the project in Visual Studio**: Double-click the `BlogWeb.sln` file to open it in Visual Studio.

3. **Install Dependencies**: If you are using a different database or require specific libraries, make sure they are installed.

4. **Configure the Database**: 
    - Create a database in SQL Server.
    - Update the connection string in the `web.config` file to match your database.

5. **Run the Project**: Press `F5` in Visual Studio to build and run the project.

## Project Structure

- **`default.aspx`**: The main page of the blog, where posts are displayed.
- **`default.aspx.cs`**: The code-behind for the main page, handling dynamic content and business logic.
- **`styles.css`**: Custom styles for the blog interface.
- **`Database`**: SQL scripts to set up the required tables and initial data.

## Contributing

Feel free to fork this project, submit pull requests, or raise issues for any bugs or improvements.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
