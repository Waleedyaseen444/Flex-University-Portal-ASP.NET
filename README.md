# FlexUniversity

FlexUniversity is a flexible university portal management system built on ASP.NET (C#). This application supports multiple roles including Admin, Teacher, and Student, offering tailored functionalities for each user type. 

## Features

- **Admin Role**: 
  - Manage academic schedules
  - Allocate instructors to courses
  - Generate various reports (attendance, grade counts, course allocation, course offers)
- **Teacher Role**:
  - Take attendance
  - Issue attendance sheets and reports
- **Student Role**:
  - View schedules and academic records

## Project Structure

- **C# Folder**: Contains ASP.NET Web Forms pages (`.aspx`) and their code-behind files (`.aspx.cs`) handling core functionality.
- **CSV Folder**: Stores CSV files used for data import/export.
- **SQL Folder**: Contains SQL scripts for database operations.
- **DB Project Documents**: Contains relational model PDFs, ERD, and related documentation.
- **Screenshots**: Visual documentation illustrating the UI and key features.

## Getting Started

1. **Prerequisites**:
    - Visual Studio with ASP.NET support
    - .NET Framework installed

2. **Setup**:
    - Open the solution in Visual Studio Code.
    - Restore any NuGet packages if needed.
    - Configure your database connection in the application's configuration file.

3. **Running the Application**:
    - Build the project.
    - Run the ASP.NET application using your preferred local web server (IIS Express or local IIS).

## Documentation

Refer to the provided DB Project documents for deeper insights into the database design:
- [DB Project ERD](FlexUniversity/CSV/DB%20Project%20ERD.png)
- [DB Project Relational Model](FlexUniversity/CSV/DB%20Project%20Relational%20Model.pdf)
- [DB Project Report](FlexUniversity/CSV/DB%20Project%20Report.docx)

## Contributing

Feel free to fork the repository and submit pull requests. Please follow the standard GitHub flow and ensure your changes pass all unit tests where applicable.

## License

This project is licensed under the MIT License. See the [LICENSE](FlexUniversity/LICENSE) file for details.
