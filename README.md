## Configuration

### Connection String

After cloning the project, configure the connection string to connect to your database:

1. Locate the configuration file: Open the `appsettings.json` file in the project's root directory.
2. Find the connection string section: Look for the `"ConnectionStrings"` section.
3. Update the connection string: Replace the placeholders with your actual database server, database name, username, and password.
4. Save the configuration file.

## Database Update

To update the database schema, follow these steps:

1. Open the Package Manager Console in Visual Studio.
2. Select the appropriate project in the dropdown.
3. Run the following command: `Update-Database`.
4. This command will apply any pending migrations and update the database.

## Seed Data Script

To execute the Seed data script and populate the database, do the following:

1. Locate the `script.sql` file in the `Scripts` folder.
2. Connect to your database using a management tool.
3. Open the `script.sql` file.
4. Execute the script in your database management tool to populate the database with Seed data.

## Running the Project

Instructions for running the project:

1. Ensure you have the necessary dependencies and tools installed.
2. Configure the project with the correct connection string as explained above.
3. Build the project to ensure all dependencies are resolved.
4. Run the project using your preferred development environment or IDE.
